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
    public partial class UserCC : Form
    {
        public UserCC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ProjetDataContext p = new ProjetDataContext();
            List<machine> LE = null;
            LE = (from eq in p.machine select eq).ToList<machine>();
            int nb = LE.Count;
            eqList eq0 = new eqList();
            eq0.Affiche1 = false;
            eq0.Affiche2 = false;
            eq0.Affiche3 = false;
            eq0.Affiche4 = false;
            flowLayoutPanel1.Controls.Add(eq0);
            eqList[] eqlist = new eqList[nb];
            for (int i = 0; i < nb; i++)
            {
                eqlist[i] = new eqList();
                int id = LE[i].ID;
                eqlist[i].ID = Convert.ToString(id);
                eqlist[i].NOM = LE[i].NOM;
                if (LE[i].PANNE == 1)
                {
                    eqlist[i].PANNE = "PANNE";
                    eqlist[i].COLOR = Color.Red;



                }
                else
                {
                    eqlist[i].PANNE = "fonctionne";
                    eqlist[i].COLOR = Color.Green;
                }
                try
                {
                    MemoryStream ms = new MemoryStream(LE[i].IMAGE.ToArray());
                    eqlist[i].icon = Image.FromStream(ms);
                }
                catch { }
                eqlist[i].Affiche1 = false;
                eqlist[i].Affiche2 = false;


                flowLayoutPanel1.Controls.Add(eqlist[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
           ProjetDataContext p = new ProjetDataContext();
            List<Piece_de_rechange> LE = null;
            LE = (from s in p.Piece_de_rechange select s).ToList<Piece_de_rechange>();
            int nb = LE.Count;
            stocklist st0 = new stocklist();
            st0.Affiche1 = false;
            st0.Affiche2 = false;
            flowLayoutPanel1.Controls.Add(st0);
            stocklist[] slist = new stocklist[nb];
            for (int i = 0; i < nb; i++)
            {
                slist[i] = new stocklist();
                int id = LE[i].id;
                slist[i].ID = id.ToString();
                slist[i].NOM = LE[i].nom;
                slist[i].Quantite = LE[i].quantite.ToString();
                slist[i].REF = LE[i].REF;
                slist[i].prix = LE[i].prix.ToString();
                slist[i].Affiche1 = false;
                slist[i].Affiche2 = false;

                flowLayoutPanel1.Controls.Add(slist[i]);


            }
        }
        //panne
        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ProjetDataContext p = new ProjetDataContext();
            List<Table_Panne> LE = null;
            LE = (from s in p.Table_Panne select s).ToList<Table_Panne>();
            int nb = LE.Count;
            listtp p0 = new listtp();
            p0.Affiche2 = false;
            p0.Affiche1 = false;
            flowLayoutPanel1.Controls.Add(p0);
            listtp[] lpt = new listtp[nb];
            for (int i = 0; i < nb; i++)
            {
                lpt[i] = new listtp();
                lpt[i].ID = LE[i].id.ToString();
                lpt[i].machine = LE[i].machine;
                lpt[i].Affiche1 = false;
                lpt[i].Affiche2 = false;
                flowLayoutPanel1.Controls.Add(lpt[i]);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ProjetDataContext p = new ProjetDataContext();
            List<Planing_mantenance> LE = null;
            listprev lp0 = new listprev();
            lp0.Affiche1 = false;
            lp0.Affiche2 = false;
            lp0.Affiche3 = false;
            lp0.Affiche4 = false;
            flowLayoutPanel1.Controls.Add(lp0);
            LE = (from eq in p.Planing_mantenance select eq).ToList<Planing_mantenance>();
            int nb = LE.Count;
            listprev[] lp = new listprev[nb];
            for (int i = 0; i < nb; i++)
            {
                lp[i] = new listprev();
                lp[i].ID = LE[i].id.ToString();
                lp[i].machine = LE[i].machine;

                lp[i].Affiche2 = false;
                lp[i].Affiche1 = false;

                flowLayoutPanel1.Controls.Add(lp[i]);



            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            statform f = new statform();
            f.Show();

        }
    }
}
