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
    public partial class testtimecs : Form
    {
        public testtimecs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime t1 = d1.Value;
            DateTime t2 = d2.Value;
          TimeSpan tf = t2 - t1;
            label1.Text = tf.ToString();
//TimeSpan tt = Convert.ToDateTime(label1.Text);
        }

    }
}
