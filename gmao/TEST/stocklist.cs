using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class stocklist : UserControl
    {
        public stocklist()
        {
            InitializeComponent();
        }
        #region Properties

        private String _ID;
        private String _NOM;
        private String _ref;
        
        private String _Quantite;
        private String _prix;
        private Boolean affiche1 = true;
        private Boolean affiche2 = true;


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
            set { affiche1 = value; button1.Visible = affiche1; }
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
            get { return _NOM; }
            set { _NOM = value; label2.Text = value; }
        }
        
        [Category("Custop prop")]
        public String REF
        {
            get { return _ref; }
            set { _ref = value; label3.Text = value; }
        }
        [Category("Custop prop")]
        public String Quantite
        {
            get { return _Quantite; }
            set { _Quantite = value; label4.Text = value; }
        }
        [Category("Custop prop")]
        public String prix
        {
            get { return _prix; }
            set { _prix = value; label5.Text = value; }
        }

        #endregion
        //suprimer
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("etes vous sur de vouloir supprimer", "ALERT", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                Piece_de_rechange s = new Piece_de_rechange();
                ProjetDataContext p = new ProjetDataContext();
                int id = Convert.ToInt32(ID);
                s = (from ss in p.Piece_de_rechange where ss.id == id select ss).Single();
                p.Piece_de_rechange.DeleteOnSubmit(s);
                p.SubmitChanges();
                Form1 f = (Form1)this.FindForm();
                f.refrech();
            }

        }
        //modifier
        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ID);
            StockForm f = new StockForm(id);
            f.ShowDialog();

        }
    }
}
