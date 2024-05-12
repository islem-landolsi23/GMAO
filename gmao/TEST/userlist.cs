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
    public partial class userlist : UserControl
    {
        public userlist()
        {
            InitializeComponent();
        }
        #region Properties

        private String _ID;
        private String _NOM;
        private String _prenom;

        private String _role;
        private String _dep;
        private String _mat;
        private Boolean affiche1 = true;
        private Boolean affiche2 = true;


        [Category("Custop prop")]
        public String ID
        {
            get { return _ID; }
            set { _ID = value; label1.Text = value; }
        }
        [Category("Custop prop")]
        public String NOM
        {
            get { return _NOM; }
            set { _NOM = value; label2.Text = value; }
        }

        [Category("Custop prop")]
        public String prenom
        {
            get { return _prenom; }
            set { _prenom = value; label3.Text = value; }
        }
        [Category("Custop prop")]
        public String role
        {
            get { return _role; }
            set { _role = value; label4.Text = value; }
        }
        [Category("Custop prop")]
        public String dep
        {
            get { return _dep; }
            set { _dep = value; label5.Text = value; }
        }
        [Category("Custop prop")]
        public String matricule
        {
            get { return _mat; }
            set { _mat = value; label6.Text = value; }
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

        #endregion
        //udpate
        private void button2_Click(object sender, EventArgs e)
        {
            adduserForm f = new adduserForm(Convert.ToInt32(ID));
            f.Show();
        }
        //delete
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("etes vous sur de vouloir supprimer", "ALERT", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                USER s = new USER();
                ProjetDataContext p = new ProjetDataContext();
                int id = Convert.ToInt32(ID);
                s = (from ss in p.USER where ss.id == id select ss).Single();
                p.USER.DeleteOnSubmit(s);
                p.SubmitChanges();
                Form1 f = (Form1)this.FindForm();
                f.refrech();
            }

        }

    }
}
