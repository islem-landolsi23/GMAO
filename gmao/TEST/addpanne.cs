using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class addpanne : Form
    {
        
        public addpanne()
        {
            InitializeComponent();
           
                
        }
         
        private void addpanne_Load(object sender, EventArgs e)
        {
            ProjetDataContext p = new ProjetDataContext();
            var listmachine = (from x in p.machine where x.PANNE==0 select x).ToList();
            comboBox1.ValueMember = "NOM";
            comboBox1.DataSource = listmachine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                machine m = (machine)comboBox1.SelectedItem;

                ProjetDataContext p = new ProjetDataContext();
                Table_Panne tp = new Table_Panne();
                tp.machine = m.NOM;
                tp.solution = boxs.Text;
                tp.description = boxd.Text;
                tp.date = DateTime.Today;
                p.Table_Panne.InsertOnSubmit(tp);
                machine lm2 = (from x in p.machine where x.ID == m.ID select x).Single();
                lm2.PANNE = 1;
                p.SubmitChanges();
                MessageBox.Show("5edmit");
                try
                {
                    Pann_Machine pm = new Pann_Machine();
                    pm = (from pin in p.Pann_Machine where pin.machin == tp.machine select pin).Single();
                    int i = ++pm.nbr_pann;
                    pm.nbr_pann = i;
                    p.SubmitChanges();
                }
                catch {
                    Pann_Machine pm = new Pann_Machine();
                    pm.nbr_pann = 1;
                    pm.machin = tp.machine;
                    p.Pann_Machine.InsertOnSubmit(pm);
                    p.SubmitChanges();

                }
                Pann_time pmt = new Pann_time();
                pmt.date_s = DateTime.Now;
                pmt.machin = tp.machine;
                p.Pann_time.InsertOnSubmit(pmt);
                p.SubmitChanges();

                this.Close();


            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
         



        }
    }
}
