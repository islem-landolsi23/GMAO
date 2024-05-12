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
    public partial class affichebon : Form
    {
        public affichebon(String code)
        {
            InitializeComponent();
            Label l1 = new Label();
            Label l2 = new Label();
            Label l3 = new Label();
            Label l4 = new Label();

            l1.Text = "piece";
            l2.Text = "ref";
            l3.Text = "quantite";
            l4.Text = "prix";
            flowLayoutPanel1.Controls.Add(l1);
            flowLayoutPanel2.Controls.Add(l2);
            flowLayoutPanel3.Controls.Add(l3);
            flowLayoutPanel4.Controls.Add(l4);

            label2.Text = code;
            ProjetDataContext p = new ProjetDataContext();
            bon_srt bnn = new bon_srt();
            bnn= (from eqs in p.bon_srt where eqs.code == code select eqs).Single();
            label4.Text = bnn.date.ToString();
            List<piece_bon> pbn = null;
             pbn = (from eqs in p.piece_bon where eqs.code_bon == code select eqs).ToList<piece_bon>();
            int nbr = pbn.Count;
            int somme = 0;
            for(int i=0;i<nbr;i++)
            {
                Label ll1 = new Label();
                Label ll2 = new Label();
                Label ll3 = new Label();
                Label ll4 = new Label();
                ll1.Text = pbn[i].nom;
                ll2.Text = pbn[i].REF;
                ll3.Text = pbn[i].quantite.ToString();
                Piece_de_rechange prr = new Piece_de_rechange();
                prr = (from eqs in p.Piece_de_rechange where eqs.nom == pbn[i].nom select eqs).Single();
                ll4.Text = (prr.prix*pbn[i].quantite).ToString();
                flowLayoutPanel1.Controls.Add(ll1);
                flowLayoutPanel2.Controls.Add(ll2);
                flowLayoutPanel3.Controls.Add(ll3);
                flowLayoutPanel4.Controls.Add(ll4);
                somme = somme + (prr.prix * pbn[i].quantite);



            }

            label6.Text = somme.ToString();




        }
        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();

        }
     
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
