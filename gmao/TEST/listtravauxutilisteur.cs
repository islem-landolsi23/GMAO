using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class listtravauxutilisteur : UserControl
    {
        public listtravauxutilisteur()
        {
            InitializeComponent();
        }
        #region Properties
        private String _ID;
        private DateTime _date;
        private String _machine;



        [Category("Custop prop")]
        public String ID
        {
            get { return _ID; }
            set { _ID = value; label1.Text = value; }
        }
        [Category("Custop prop")]
        public String machine
        {
            get { return _machine; }
            set { _machine = value; label2.Text = value; }
        }


        [Category("Custop prop")]
        public DateTime date
        {
            get { return _date; }
            set { _date = value; dateTimePicker1.Value = value; }
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("avez vous termines le teminer", "ALERT", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                travaux t = new travaux();
                ProjetDataContext p = new ProjetDataContext();
                int id = Convert.ToInt32(ID);
                t = (from eqs in p.travaux where eqs.id == id select eqs).Single();
                t.etat = 1;
            
                p.SubmitChanges();
                button2.Visible = false;
                label3.Visible = true;
                machine tp = new machine();
                tp = (from eqs in p.machine where eqs.NOM ==t.machin select eqs).Single();
                tp.PANNE = 0;
                p.SubmitChanges();
                Pann_time pt = (from pp in p.Pann_time where pp.machin == t.machin && pp.date_f==null select pp).Single();
                pt.date_f = DateTime.Now;
                p.SubmitChanges();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            description f = new description(Convert.ToInt32(ID));
            f.Show();
        }

        private void listtravauxutilisteur_Load(object sender, EventArgs e)
        {
            travaux t = new travaux();
            int id = Convert.ToInt32(ID);
            ProjetDataContext p = new ProjetDataContext();
            t = (from eqs in p.travaux where eqs.id == id select eqs).Single();
            if(t.etat==1)
            {
                button2.Visible = false;
                label3.Visible = true;
            }else
            { label3.Visible = false; }
        }
    }
}
