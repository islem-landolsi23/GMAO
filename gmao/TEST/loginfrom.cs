using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TEST
{
    public partial class loginfrom : Form
    {
        public static int ID=0;
        public loginfrom()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int counter = 0;
        int len = 0;
        String text;
        private void loginfrom_Load(object sender, EventArgs e)
        {
            text = label1.Text;
            label1.Text = "";
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            checkBox1.Visible = false;
            pictureBox1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            len = text.Length;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = text.Substring(0, counter);
            ++counter;
            if(counter>len)
            {
                label2.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                checkBox1.Visible = true;
                button2.Visible = true;
                // button3.Visible = true;
                //  button4.Visible = true;
                pictureBox1.Visible = true;
                timer1.Stop(); }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {if (checkBox1.Checked)
            { textBox2.UseSystemPasswordChar =false; }

            else
            { textBox2.UseSystemPasswordChar = true; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProjetDataContext p = new ProjetDataContext();
            USER u = new USER();
            try { u = p.USER.Single(user => user.matricule == (Convert.ToInt32(textBox1.Text)) && user.mdp == textBox2.Text);
                if (u != null)
                {
                    if (u.role == "admin")
                    {
                        Form1 f = new Form1(u.id);
                        this.Hide();
                        f.Show();
                        ID = u.id;
                    }
                    else if (u.role == "user")
                    {
                        UserForm f = new UserForm(u.id);
                        this.Hide();
                        f.Show();
                    }
                }
                else { MessageBox.Show("verifier vos cordonees"); }
                 
            }
            catch(Exception ex) { MessageBox.Show("verifier vos cordonees"); }
         
            
                    

            }
            
        

        private void button3_Click(object sender, EventArgs e)
        {
            UserCC f = new UserCC();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(ID);
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Creerboncs f = new Creerboncs();
            f.Show();
        }
    }
}
