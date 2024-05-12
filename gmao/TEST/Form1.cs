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
    public partial class Form1 : Form
    {
        private int page = 1;
        private static int ident;
        public Form1(int id)
        {
            InitializeComponent();
            if (id == 0)
            { button12.Visible = false; }
            else
                ident = id;


        }
        // ajouter
        private void button5_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                AddequipmentForm f = new AddequipmentForm(0);
                f.ShowDialog();
            }
            else if(page==2){
                StockForm f = new StockForm(0);
                f.ShowDialog();
            }
            else if (page == 3)
            {
                adduserForm f = new adduserForm(0);
                f.ShowDialog();
            }
            else if (page == 5)
            {
               planform f = new planform(0);
                f.ShowDialog();
            }else if(page==6)
            {
                addt f = new addt(0);
                f.Show();
            }

            else if (page == 4)
            {
                addpanne f = new addpanne();
                f.Show();
            }

            else if (page == 7)
            {
               Creerboncs f = new Creerboncs();
                f.Show();
            }



        }
        //list machine
        public  void showlist()
        {
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
                {     eqlist[i].PANNE = "PANNE";
                    eqlist[i].COLOR =Color.Red;



                 }
                else { eqlist[i].PANNE = "fonctionne";
                    eqlist[i].COLOR = Color.Green;
                }
                try {
                    MemoryStream ms = new MemoryStream(LE[i].IMAGE.ToArray());
                    eqlist[i].icon = Image.FromStream(ms);
                }
                catch { }

              

             flowLayoutPanel1.Controls.Add(eqlist[i]);



            }
        }//list preventif
        public void showlistpreventife()
        {
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

            for (int i=0;i<nb;i++)
            {
                lp[i] = new listprev();
                lp[i].ID = LE[i].id.ToString();
                lp[i].machine = LE[i].machine;
           



                flowLayoutPanel1.Controls.Add(lp[i]);



            }

        }
        //list bon 
        public void showlistbon()
        {

            ProjetDataContext p = new ProjetDataContext();
            List<bon_srt> LE = null;
            LE = (from eq in p.bon_srt select eq).ToList<bon_srt>();
            listbon lb0 = new listbon();
            lb0.Affiche1 = false;
            lb0.Affiche2 = false;
            flowLayoutPanel1.Controls.Add(lb0);
            int nb = LE.Count;
            listbon[] lbon = new listbon[nb];
            for (int i = 0; i < nb; i++)
            {
                lbon[i] = new listbon();
                lbon[i].ID = LE[i].id.ToString();
                lbon[i].code = LE[i].code;
                lbon[i].date = LE[i].date;




                flowLayoutPanel1.Controls.Add(lbon[i]);



            }



        }



        //list pann felsa mil fou9
        public void showlistpanne()
        {
            ProjetDataContext p = new ProjetDataContext();
            List<machine> LE = null;
            LE = (from eq in p.machine where eq.PANNE==1 select eq).ToList<machine>();
            int nb = LE.Count;
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

                flowLayoutPanel1.Controls.Add(eqlist[i]);



            }
        }
        // list pieces
        public void showliststock()
        {
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
                flowLayoutPanel1.Controls.Add(slist[i]);


            }

        }
        ///list user  
        public void showlistuser()
        {
            ProjetDataContext p = new ProjetDataContext();
            List<USER> LE = null;
            LE = (from s in p.USER select s).ToList<USER>();
            int nb = LE.Count;
            userlist[] ulist = new userlist[nb];
            userlist u0 = new userlist();
            u0.Affiche2 = false;
            u0.Affiche1 = false;
            flowLayoutPanel1.Controls.Add(u0);
            for (int i = 0; i < nb; i++)
            {
                ulist[i] = new userlist();
                ulist[i].ID = LE[i].id.ToString();
                ulist[i].NOM = LE[i].nom;
                ulist[i].prenom = LE[i].prenom;
                ulist[i].role = LE[i].role;
                ulist[i].dep = LE[i].departement;
                try
                {
                    ulist[i].matricule = LE[i].matricule.ToString();
                }
                catch { }
                flowLayoutPanel1.Controls.Add(ulist[i]);

            }

        }
        //list li tjib les panne mech el makinet
        public void showlp()
        {
            ProjetDataContext p = new ProjetDataContext();
            List<Table_Panne> LE = null;
            LE = (from s in p.Table_Panne select s).ToList<Table_Panne>();
            int nb = LE.Count;
            listtp[] lpt = new listtp[nb];
            listtp p0 = new listtp();
            p0.Affiche2 = false;
            p0.Affiche1 = false;
            flowLayoutPanel1.Controls.Add(p0);

            for (int i = 0; i < nb; i++)
            {
                lpt[i] = new listtp();
                lpt[i].ID = LE[i].id.ToString();
                lpt[i].machine = LE[i].machine;
                flowLayoutPanel1.Controls.Add(lpt[i]);

            }

        }
        //list travaux
        public void showtravaux()
        {
            ProjetDataContext p = new ProjetDataContext();
            List<travaux> LE = null;
            listtrav l0 = new listtrav();
            l0.Affiche1 = false;
            l0.Affiche2 = false;
            l0.Affiche3 = false;
            flowLayoutPanel1.Controls.Add(l0);
            LE = (from s in p.travaux select s).ToList<travaux>();
            int nb = LE.Count;
            listtrav[] lt = new listtrav[nb];
            for (int i = 0; i < nb; i++)
            {
                lt[i] = new listtrav();
                lt[i].ID = LE[i].id.ToString();
                lt[i].machine = LE[i].machin;
                lt[i].agent = LE[i].agent;
                lt[i].date = LE[i].deadline;
                if (LE[i].etat == 0)
                    lt[i].etat = "en attente";
                else
                    lt[i].etat = "Travail fini";


                flowLayoutPanel1.Controls.Add(lt[i]);



            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            showlist();
        }
        public void refrech()
        {
            flowLayoutPanel1.Controls.Clear();
            if (page == 1)
                showlist();
            else if (page == 2)
                showliststock();
            else if (page == 3)
                showlistuser();
            else if (page == 4)
                showlp();
            else if (page == 5)
                showlistpreventife();
            else if (page == 6)
                showtravaux();
            else if (page == 7)
                showlistbon();

        }
        private void rifrech_Click(object sender, EventArgs e)
        {
            refrech();
        }
        // gestion des piece
        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            page = 2;
            button7.Visible = false;
            showliststock();
            button6.Visible = true;
            textBox1.Visible = true;
        }
        //gestion de machine
        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            showlist();
            page = 1;
            button7.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            textBox1.Visible = true;

        }
        //gestion utilisateurs
        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            showlistuser();
            page = 3;
            button7.Visible = false;
            button5.Visible = true;
            button6.Visible = true;
            textBox1.Visible = true;
        }

        private void minpic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
        //affichagelist machin en pann
        int col=0;
        private void button7_Click(object sender, EventArgs e)
        {if (col == 0)
            {
                button7.BackColor = Color.Red;
                col = 1;
                flowLayoutPanel1.Controls.Clear();
                showlistpanne();
            }
            else
            {
                button7.BackColor = Color.Transparent;
                col = 0;
                flowLayoutPanel1.Controls.Clear();
                showlist();
            }
        }
        //recherche

        private void button6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ProjetDataContext p = new ProjetDataContext();
            if (page == 1) {

                List<machine> LE = null;
                LE = (from eq in p.machine where eq.NOM == textBox1.Text select eq).ToList<machine>();
                int nb = LE.Count;
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

                    flowLayoutPanel1.Controls.Add(eqlist[i]);



                }
            }else if (page==2)
            {
                List<Piece_de_rechange> LE = null;
                LE = (from s in p.Piece_de_rechange where s.nom ==textBox1.Text   select s).ToList<Piece_de_rechange>();
                int nb = LE.Count;
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
                    flowLayoutPanel1.Controls.Add(slist[i]);

                }


            }else if(page==3)
            {
                List<USER> LE = null;
                LE = (from s in p.USER where s.nom == textBox1.Text  select s).ToList<USER>();
                int nb = LE.Count;
                userlist[] ulist = new userlist[nb];
                for (int i = 0; i < nb; i++)
                {
                    ulist[i] = new userlist();
                    ulist[i].ID = LE[i].id.ToString();
                    ulist[i].NOM = LE[i].nom;
                    ulist[i].prenom = LE[i].prenom;
                    ulist[i].role = LE[i].role;
                    ulist[i].dep = LE[i].departement;
                    flowLayoutPanel1.Controls.Add(ulist[i]);

                }
            }else if (page == 4)
            {
                List<Table_Panne> LE = null;
                LE = (from s in p.Table_Panne where s.machine==textBox1.Text select s).ToList<Table_Panne>();
                int nb = LE.Count;
                listtp[] lpt = new listtp[nb];
                for (int i = 0; i < nb; i++)
                {
                    lpt[i] = new listtp();
                    lpt[i].ID = LE[i].id.ToString();
                    lpt[i].machine = LE[i].machine;
                    flowLayoutPanel1.Controls.Add(lpt[i]);

                }

            }else if(page==5)
            {
                List<Planing_mantenance> LE = null;
                LE = (from eq in p.Planing_mantenance where eq.machine==textBox1.Text select eq).ToList<Planing_mantenance>();
                int nb = LE.Count;
                listprev[] lp = new listprev[nb];
                for (int i = 0; i < nb; i++)
                {
                    lp[i] = new listprev();
                    lp[i].ID = LE[i].id.ToString();
                    lp[i].machine = LE[i].machine;
                  


                    flowLayoutPanel1.Controls.Add(lp[i]);



                }

            }else if(page==6)
            {
                List<travaux> LE = null;
                LE = (from s in p.travaux where s.machin==textBox1.Text select s).ToList<travaux>();
                int nb = LE.Count;
              
                listtrav[] lt = new listtrav[nb];
                for (int i = 0; i < nb; i++)
                {
                    lt[i] = new listtrav();
                    lt[i].ID = LE[i].id.ToString();
                    lt[i].machine = LE[i].machin;
                    lt[i].agent = LE[i].agent;
                    lt[i].date = LE[i].deadline;
                    if (LE[i].etat == 0)
                        lt[i].etat = "en attente";
                    else
                        lt[i].etat = "Travail fini";


                    flowLayoutPanel1.Controls.Add(lt[i]);



                }
            }

        }
        //close
        private void closepic_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //gestion panne
        private void button4_Click(object sender, EventArgs e)
        {
            page = 4;
            button5.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            showlp();
            button7.Visible = true;
            textBox1.Visible = true;
            button6.Visible = true;
        }
        //gestio des paln preventive
        private void button8_Click(object sender, EventArgs e)
        {
            page = 5;
          
            flowLayoutPanel1.Controls.Clear();
            showlistpreventife();
            button7.Visible = false;
            button5.Visible = true;
            button6.Visible = true;
            textBox1.Visible = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            page = 6;
            flowLayoutPanel1.Controls.Clear();
            showtravaux();
            button7.Visible = false;
            button5.Visible = true;
            button6.Visible = true;
            textBox1.Visible = true;
        }
        //stats
        private void button11_Click(object sender, EventArgs e)
        {
            statform f = new statform();
            f.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            page = 7;
            flowLayoutPanel1.Controls.Clear();
            showlistbon();
            button7.Visible = false;
            textBox1.Visible = false;
            button6.Visible = false;
          


        }
        //compte
        private void button12_Click(object sender, EventArgs e)
        {
            comptadmin f = new comptadmin(ident);
            f.Show();
        }
    }
}
