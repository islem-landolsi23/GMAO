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
    public partial class Changeuser : UserControl
    {
        public Changeuser()
        {
            InitializeComponent();
        }

        private void Changeuser_Load(object sender, EventArgs e)
        {
            int i;
            // (Form1)this.FindForm();
            UserForm u =(UserForm)this.FindForm();
            i=u.ID;
            ProjetDataContext p = new ProjetDataContext();
            USER ut = p.USER.Single(user => user.id == i);
            boxnom.Text = ut.nom;
            boxprenom.Text = ut.prenom;
            boxmdp.Text = ut.mdp;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int i;
            // (Form1)this.FindForm();
            UserForm u = (UserForm)this.FindForm();
            i = u.ID;
            ProjetDataContext p = new ProjetDataContext();
            USER ut = p.USER.Single(user => user.id == i);
            ut.mdp = boxmdp.Text;
            ut.nom = boxnom.Text;
            ut.prenom = boxnom.Text;
            p.SubmitChanges();
            MessageBox.Show("5edmit");

        }
    }
}
