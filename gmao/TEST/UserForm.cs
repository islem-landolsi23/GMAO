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
    public partial class UserForm : Form
    {
        public int ID;
        public UserForm(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(panel1.Location.X>-503)
            {
                panel1.Location = new Point(panel1.Location.X - 70, panel1.Location.Y);

            }
            else
            { timer1.Stop(); }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel1.Location.X<0)
            {
                panel1.Location = new Point(panel1.Location.X + 70, panel1.Location.Y);

            }
            else
            { timer2.Stop(); }
        }
        //gestion user
        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            timer1.Start();
            Changeuser ch = new Changeuser();
            flowLayoutPanel1.Controls.Add(ch);

        }
        //add pann
        private void button3_Click(object sender, EventArgs e)
        {
            addpanne f = new addpanne();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();

        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            flowLayoutPanel1.Controls.Clear();
            ProjetDataContext p = new ProjetDataContext();
            USER u = p.USER.Single(user => user.id == ID);
            List<travaux> LE = null;
            LE = (from s in p.travaux where s.matricule_user == u.matricule select s).ToList<travaux>();
            int nb = LE.Count;
           listtravauxutilisteur[] lt = new listtravauxutilisteur[nb];
            for (int i = 0; i < nb; i++)
            {
                lt[i] = new listtravauxutilisteur();
                lt[i].ID = LE[i].id.ToString();
                lt[i].machine = LE[i].machin;
              
                lt[i].date = LE[i].deadline;
             


                flowLayoutPanel1.Controls.Add(lt[i]);



            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserCC f = new UserCC();
            f.Show();
        }
    }
}
