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
    public partial class listprev : UserControl
    {
        public listprev()
        {
            InitializeComponent();
        }
        #region Properties

        private String _ID;
        private String _plan;
        private String _machine;
        private DateTime _date;
        private Boolean affiche1 = true;
        private Boolean affiche2 = true;
        private Boolean affiche3 = true;
        private Boolean affiche4 = true;






        [Category("Custop prop")]
        public String ID
        {
            get { return _ID; }
            set { _ID = value; label1.Text = value; }
        }

        [Category("Custop prop")]
        public DateTime date
        {
            get { return _date; }
            set { _date = value; dateTimePicker1.Value = value; }
        }
        [Category("Custop prop")]
        public String machine
        {
            get { return _machine; }
            set { _machine = value; label2.Text = value; }
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
            set { affiche3 = value; button3.Visible = affiche3; }
        }
        [Category("Custop prop")]
        public Boolean Affiche4
        {
            get { return affiche4; }
            set { affiche4 = value; dateTimePicker1.Visible = affiche4; }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("etes vous sur de vouloir supprimer","ALERT",MessageBoxButtons.YesNo);
            if (d==DialogResult.Yes)
            {
                Planing_mantenance f = new Planing_mantenance();
                ProjetDataContext p = new ProjetDataContext();
                int id = Convert.ToInt32(ID);
                f = (from eqs in p.Planing_mantenance where eqs.id == id select eqs).Single();
                p.Planing_mantenance.DeleteOnSubmit(f);
                p.SubmitChanges();
                Form1 f2 = (Form1)this.FindForm();
                f2.refrech();
            }
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            planform f = new planform(Convert.ToInt32(ID));
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            disman f = new disman(Convert.ToInt32(ID));
            f.Show();
        }
    }
}
