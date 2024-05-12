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
    public partial class listtrav : UserControl
    {
        public listtrav()
        {
            InitializeComponent();
        }
        #region Properties

        private String _ID;
        private String _machine;
        private String _agent;
        private String _etat;
        private DateTime _date;
        private Boolean affiche1 = true;
        private Boolean affiche2 = true;
        private Boolean affiche3 = true;
        




        [Category("Custop prop")]
        public String ID
        {
            get { return _ID; }
            set { _ID = value; label4.Text = value; }
        }
        [Category("Custop prop")]
        public String machine
        {
            get { return _machine; }
            set { _machine = value; label1.Text = value; }
        }


        [Category("Custop prop")]
        public String agent
        {
            get { return _agent; }
            set { _agent = value; label2.Text = value; }
        }

        [Category("Custop prop")]
        public String etat
        {
            get { return _etat; }
            set { _etat = value; label3.Text = value; }
        }
        [Category("Custop prop")]
        public DateTime date
        {
            get { return _date; }
            set { _date = value; dateTimePicker1.Value= value; }
        }
        [Category("Custop prop")]
        public Boolean Affiche1
        {
            get { return affiche1; }
            set { affiche1 = value; button1.Visible = affiche1; }
        }
        [Category("Custop prop")]
        public Boolean Affiche2
        {
            get { return affiche2; }
            set { affiche2 = value; button2.Visible = affiche2; }
        }
        [Category("Custop prop")]
        public Boolean Affiche3
        {
            get { return affiche3; }
            set { affiche3 = value; dateTimePicker1.Visible = affiche2; }
        }

        #endregion
        //delet
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("etes vous sur de vouloir supprimer", "ALERT", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                travaux f = new travaux();
                ProjetDataContext p = new ProjetDataContext();
                int id = Convert.ToInt32(ID);
                f = (from eqs in p.travaux where eqs.id == id select eqs).Single();
                p.travaux.DeleteOnSubmit(f);
                p.SubmitChanges();
                Form1 f2 = (Form1)this.FindForm();
                f2.refrech();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addt f = new addt(Convert.ToInt32(ID));
            f.Show();
        }
    }
}
