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
    public partial class listbon : UserControl
    {
        public listbon()
        {
            InitializeComponent();
        }

        #region Properties
        private String _ID;
        private String _code;
        private DateTime _date;
        private Boolean affiche1 = true;
        private Boolean affiche2 = true;


        [Category("Custop prop")]
        public String ID
        {
            get { return _ID; }
            set { _ID = value; label1.Text = value; }
        }

        [Category("Custop prop")]
        public String code
        {
            get { return _code; }
            set { _code = value; label2.Text = value; }
        }
        [Category("Custop prop")]
        public DateTime date
        {
            get { return _date; }
            set { _date = value; dateTimePicker1.Value = value; }
        }
        public Boolean Affiche1
        {
            get { return affiche1; }
            set { affiche1 = value; button1.Visible = affiche1; }
        }
        public Boolean Affiche2
        {
            get { return affiche2; }
            set { affiche2 = value; dateTimePicker1.Visible = affiche2; }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            affichebon f = new affichebon(_code);
            f.Show();
        }
    }
}
