using System;
using System.Collections;
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
    public partial class Creerboncs : Form
    {
        public static ArrayList L = new ArrayList();
        public static int nbrclick = 0;
    
        public Creerboncs()
        {
            InitializeComponent();
          
       

        }
        public static ArrayList Lcm = new ArrayList();
        public static ArrayList Lq = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
         
                ComboBox cm = new ComboBox();
                NumericUpDown q = new NumericUpDown();

            ProjetDataContext p = new ProjetDataContext();
            var listpieces = (from x in p.Piece_de_rechange select x).ToList();

            cm.ValueMember = "nom";
            cm.DataSource = listpieces;


                Lcm.Add(cm);

                Lq.Add(q);



                flowLayoutPanel1.Controls.Add(cm);

                flowLayoutPanel1.Controls.Add(q);
                bonForm bn = new bonForm();

                flowLayoutPanel1.Controls.Add(bn);


           




            
            
           







        }
        private void button2_Click(object sender, EventArgs e)
        {
            int i=0;
        
            ProjetDataContext p = new ProjetDataContext();
            bon_srt bn = new bon_srt();
            Boolean ok = false;
            var listcode = (from x in p.bon_srt select x).ToList();
            ArrayList Lcode = new ArrayList();
            for (int j = 0; j < listcode.Count(); j++)
            {
                Lcode.Add(listcode[j].code);
            }

            String code="";

            while (ok==false)
            {
                code = generatecode();
                if(Lcode.Contains(code))
                { }
                else { ok = true; }

            }


           
            bn.code = code;
            bn.date = DateTime.Now;
            p.bon_srt.InsertOnSubmit(bn);
            p.SubmitChanges();
           
          
          
            foreach (var val in Lcm)
            {
                ComboBox cm = new ComboBox();
                cm = (ComboBox)val;
                NumericUpDown q = new NumericUpDown();
                q = (NumericUpDown)Lq[i];
                i++;
                Piece_de_rechange pr = new Piece_de_rechange();
                piece_bon pb = new piece_bon();
                pr = (from x in p.Piece_de_rechange where x.nom== cm.SelectedValue.ToString() select x).Single();
                pb.nom = pr.nom;
                pb.REF = pr.REF;
                pb.quantite =(int) q.Value;
                pb.code_bon = code;
                p.piece_bon.InsertOnSubmit(pb);
                p.SubmitChanges();
            }

            MessageBox.Show("5edmit");
        }
        private String generatecode()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[6];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }

        
    }
}
