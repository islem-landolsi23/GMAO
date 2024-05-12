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
    public partial class planform : Form
    {
        int role;
        public planform(int id)
        {
            InitializeComponent();
            role=id;
            if(id!=0)
            {
                ProjetDataContext p = new ProjetDataContext();
                Planing_mantenance pf = new Planing_mantenance();
                // s = (from eqs in p.Piece_de_rechange where eqs.id == role select eqs).Single();
                pf = (from eqs in p.Planing_mantenance where eqs.id == role select eqs).Single();

                combom.SelectedItem = pf.machine;
                combof.SelectedIndex = pf.frequrnce;
                boxd.Text = pf.PL;
                dateTimePicker1.Value = (DateTime)pf.date_mant;
                button1.Text = "modifier";

            }
        }

        private void planform_Load(object sender, EventArgs e)
        {
            ProjetDataContext p = new ProjetDataContext();
            var listmachine = (from x in p.machine where x.PANNE == 0 select x).ToList();
            combom.ValueMember = "NOM";
            combom.DataSource = listmachine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjetDataContext p = new ProjetDataContext();
            Planing_mantenance pf = new Planing_mantenance();
            machine m =(machine) combom.SelectedItem;
            if (role == 0) {
                pf.machine = m.NOM;
                pf.frequrnce = combof.SelectedIndex;
                pf.PL = boxd.Text;
                pf.date_mant = dateTimePicker1.Value;
                p.Planing_mantenance.InsertOnSubmit(pf);
                p.SubmitChanges();
                MessageBox.Show("5edmit");
            }
            else
            {
                pf.machine = m.NOM;
                pf.frequrnce = combof.SelectedIndex;
                pf.PL = boxd.Text;
                pf.date_mant = dateTimePicker1.Value;
                p.SubmitChanges();
                MessageBox.Show("5edmit");
            }
          

        }
    }
}
