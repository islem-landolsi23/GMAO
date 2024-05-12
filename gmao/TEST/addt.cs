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
    public partial class addt : Form
    {
        int role;
        public addt(int id)
        {
            InitializeComponent();
            role = id;
            if(role!=0)
            {
                ProjetDataContext p = new ProjetDataContext();
                //u = p.USER.Single(user => user.matricule == (Convert.ToInt32(textBox1.Text)
                travaux t = p.travaux.Single(travail => travail.id == role);
                USER u = p.USER.Single(user => user.nom == t.agent);
                machine m = p.machine.Single(mac => mac.NOM == t.machin);
                combom.SelectedItem = m;
                combou.SelectedItem = u;
                richTextBox1.Text = t.description;
                dateTimePicker1.Value = t.deadline;
                button1.Text = "modifier";
            }
        }

        private void addt_Load(object sender, EventArgs e)
        {
            ProjetDataContext p = new ProjetDataContext();
            var listmachine = (from x in p.machine where x.PANNE == 1 select x).ToList();
            var listuser = (from x in p.USER where x.role != "admin" select x).ToList();
            combom.ValueMember = "NOM";
            combom.DataSource = listmachine;
            combou.ValueMember = "nom";
            combou.DataSource = listuser;
            dataGridView1.DataSource = listuser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (role == 0)
            {
                machine m = (machine)combom.SelectedItem;
                USER u = (USER)combou.SelectedItem;
                ProjetDataContext p = new ProjetDataContext();
                travaux t = new travaux();
                t.machin = m.NOM;
                t.agent = u.nom;
                t.matricule_user = (int)u.matricule;
                t.description = richTextBox1.Text;
                t.etat = 0;
                t.deadline = dateTimePicker1.Value;


                p.travaux.InsertOnSubmit(t);
                p.SubmitChanges();
                MessageBox.Show("5edmit");
            }
            else {
                machine m = (machine)combom.SelectedItem;
                USER u = (USER)combou.SelectedItem;
                ProjetDataContext p = new ProjetDataContext();
                travaux t = p.travaux.Single(travail => travail.id == role);
                t.machin = m.NOM;
                t.agent = u.nom;
                t.matricule_user = (int)u.matricule;
                t.description = richTextBox1.Text;
               
                t.deadline = dateTimePicker1.Value;


           
                p.SubmitChanges();
                MessageBox.Show("5edmit");
            }
       
            
       


            
                
        }

        private void combou_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjetDataContext p = new ProjetDataContext();
            USER us = (USER)combou.SelectedItem;
            string name = us.nom;
            var listuser = (from x in p.USER where x.role != "admin" &&x.nom==name select x).ToList();
            dataGridView1.DataSource = listuser;
        }
    }
}
