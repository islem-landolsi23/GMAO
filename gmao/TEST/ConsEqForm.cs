using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class ConsEqForm : Form
    {
        public ConsEqForm(int id)
        {
            InitializeComponent();

            ProjetDataContext p = new ProjetDataContext();
            machine eq = new machine();
            eq = (from eqs in p.machine where eqs.ID == id select eqs).Single();
            labnom.Text = eq.NOM;
            labfg.Text = eq.equipement;
            labunite.Text = eq.UNITE;
            labref .Text= eq.REFERENCE;
            if(eq.PANNE==1)
            { labpanne.Text = "panne";
                labpanne.ForeColor = Color.Red;
            }
            else
            {
                labpanne.Text = "fonction";
                labpanne.ForeColor = Color.Green;
            }
            try
            {
                MemoryStream ms = new MemoryStream(eq.IMAGE.ToArray());
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch { }

        }

        
    }
}
