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
    public partial class comptadmin : Form
    {
        private static int Id;
        public comptadmin(int id)
        {
            InitializeComponent();
            ProjetDataContext p = new ProjetDataContext();
            Id = id;
            USER ut = p.USER.Single(user => user.id == id);
            boxnom.Text = ut.nom;
            boxprenom.Text = ut.prenom;
            boxmdp.Text = ut.mdp;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjetDataContext p = new ProjetDataContext();
            USER ut = p.USER.Single(user => user.id == Id);
            ut.mdp = boxmdp.Text;
            ut.nom = boxnom.Text;
            ut.prenom = boxnom.Text;
            p.SubmitChanges();
            MessageBox.Show("5edmit");
        }
    }
}
