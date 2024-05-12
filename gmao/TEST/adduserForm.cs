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
    public partial class adduserForm : Form
    {
        int role;
        public adduserForm(int id)
        {
            InitializeComponent();
            role = id;
            if(role!=0)
            {
                ProjetDataContext p = new ProjetDataContext();
                USER u = new USER();
                u = (from us in p.USER where us.id == role select us).Single();
                boxnom.Text = u.nom;
                boxprenom.Text = u.prenom;
                comboBox1.SelectedItem = u.role;
                comboBox2.SelectedItem = u.departement;
                boxmat.Text = u.matricule.ToString();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjetDataContext p = new ProjetDataContext();
            USER u = new USER();
            if(role==0)
            {
                try
                {
                    u.nom = boxnom.Text;
                    u.prenom = boxprenom.Text;
                    u.mdp = "change me";
                    u.role = comboBox1.SelectedItem.ToString();
                    u.departement = comboBox2.SelectedItem.ToString();
                    u.matricule = Convert.ToInt32(boxmat.Text);
                    p.USER.InsertOnSubmit(u);
                    p.SubmitChanges();
                    MessageBox.Show("5edmit");
                }
                catch
                {
                    MessageBox.Show("Veuillez remplir les champs vides");
                }
              

            }
            else
            {
                try {
                    u = (from us in p.USER where us.id == role select us).Single();
                    u.nom = boxnom.Text;
                    u.prenom = boxprenom.Text;

                    u.role = comboBox1.SelectedItem.ToString();
                    u.departement = comboBox2.SelectedItem.ToString();
                    u.matricule = Convert.ToInt32(boxmat.Text);
                    p.SubmitChanges();
                    MessageBox.Show("5edmit");
                }
                catch
                {
                    MessageBox.Show("Veuillez remplir les champs vides");
                }
             
            }
        }
    }
}
