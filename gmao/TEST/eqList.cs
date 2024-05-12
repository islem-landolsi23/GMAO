using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TEST
{
    public partial class eqList : UserControl
    {
        public eqList()
        {
            InitializeComponent();
        
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Properties

        private String _ID;
        private String _NOM;
        private String _PANNE;
        private Image _icon;
        private Color color;
        private Boolean affiche1 = true;
        private Boolean affiche2 = true;
        private Boolean affiche3 = true;
        private Boolean affiche4 = true;



        [Category("Custop prop")]
        public String ID
        {
            get { return _ID; }
            set { _ID = value; label1.Text = value; }
        }
        [Category("Custop prop")]
        public Boolean Affiche1
        {
            get { return affiche1; }
            set { affiche1= value;button1.Visible = affiche1; }
        }
        [Category("Custop prop")]
        public Boolean Affiche3
        {
            get { return affiche3; }
            set { affiche3 = value; button3.Visible = affiche3; }
        }
        [Category("Custop prop")]
        public Boolean Affiche4
        {
            get { return affiche4; }
            set { affiche4 = value; pictureBox1.Visible = affiche4; }
        }

        [Category("Custop prop")]
        public Boolean Affiche2
        {
            get { return affiche2; }
            set { affiche2 = value; button2.Visible = affiche2; }
        }
        [Category("Custop prop")]
        public String NOM
        {
            get { return _NOM ; }
            set { _NOM = value; label2.Text = value; }
        }
      
        [Category("Custop prop")]
        public Color COLOR
        {
            get { return color; }
            set { color = value; label3.ForeColor=value; }
        }
        [Category("Custop prop")]
        public String PANNE
        {
            get { return _PANNE; }
            set { _PANNE = value; label3.Text = value; }
        }
        [Category("Custop prop")]
        public Image icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }

        #endregion

        //consulter
        private void button3_Click(object sender, EventArgs e)
        {
            ConsEqForm f = new ConsEqForm(Convert.ToInt32(ID));
            f.Show();
        }
        //delete
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("etes vous sur de vouloir supprimer", "ALERT", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                machine eq = new machine();
                ProjetDataContext p = new ProjetDataContext();
                int id = Convert.ToInt32(ID);
                eq = (from eqs in p.machine where eqs.ID == id select eqs).Single();

                var pm = (from ee in p.Pann_Machine select ee).ToList();
                ArrayList Lpm = new ArrayList();
                for (int j = 0; j < pm.Count(); j++)
                {
                    Lpm.Add(pm[j].machin);
                }
                if (Lpm.Contains(eq.NOM))
                {
                    Pann_Machine pop = (from rr in p.Pann_Machine where rr.machin == eq.NOM select rr).Single();
                    p.Pann_Machine.DeleteOnSubmit(pop);
                }

                    List<Pann_time> ptt = (from ee in p.Pann_time select ee).ToList<Pann_time>();
                ArrayList Ltime = new ArrayList();
                for (int j = 0; j < ptt.Count(); j++)
                {
                    Ltime.Add(ptt[j].machin);
                }


                if (Ltime.Contains(eq.NOM)) { p.Pann_time.DeleteAllOnSubmit(ptt); }
             

                p.machine.DeleteOnSubmit(eq);
              
                p.SubmitChanges();
                

               
                Form1 f = (Form1)this.FindForm();
                f.refrech();
            }

        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ID);
            AddequipmentForm f = new AddequipmentForm(id);
            f.ShowDialog();

        }
    }
}
