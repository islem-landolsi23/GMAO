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
    public partial class listtp : UserControl
    {
        public listtp()
        {
            InitializeComponent();
        }
        #region Properties

        private String _ID;
        private String _machine;
        private Boolean affiche1 = true;
        private Boolean affiche2 = true;


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
        public Boolean Affiche1
        {
            get { return affiche1; }
            set { affiche1 = value; button1.Visible = affiche1; }
        }
        [Category("Custop prop")]
        public Boolean Affiche2
        {
            get { return affiche2; }
            set { affiche2 = value; button3.Visible = affiche2; }
        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult d = MessageBox.Show("etes vous sur de vouloir supprimer", "ALERT", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes) {
                Table_Panne eq = new Table_Panne();
            ProjetDataContext p = new ProjetDataContext();
            int id = Convert.ToInt32(ID);
            eq = (from eqs in p.Table_Panne where eqs.id == id select eqs).Single();
            p.Table_Panne.DeleteOnSubmit(eq);
            p.SubmitChanges();
            Form1 f = (Form1)this.FindForm();
            f.refrech();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conpanne f = new conpanne(Convert.ToInt32(ID));
            f.Show();
        }
    }
}
