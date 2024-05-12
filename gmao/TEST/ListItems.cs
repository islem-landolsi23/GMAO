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
    public partial class ListItems : UserControl
    {
        public ListItems()
        {
            InitializeComponent();
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            AddequipmentForm f = new AddequipmentForm(0);
            f.ShowDialog();
        }
        #region Properties

        private String _title;

        [Category("Custop prop")]
        public String title
        {
            get { return _title; }
            set { _title = value;label1.Text = value; }
        }



        #endregion

        private void pic1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(title+"clicked");
        }
    }
}
