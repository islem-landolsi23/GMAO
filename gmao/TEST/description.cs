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
    public partial class description : Form
    {
        public description(int id)
        {
            InitializeComponent();
            ProjetDataContext p = new ProjetDataContext();
            travaux t = p.travaux.Single(tt=>tt.id==id);
            try { richTextBox1.Text = t.description; }
            catch { }
            
        }
    }
}
