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
    public partial class disman : Form
    {
        public disman(int id)
        {
            InitializeComponent();
            ProjetDataContext p = new ProjetDataContext();
            Planing_mantenance pl = new Planing_mantenance();
            pl = p.Planing_mantenance.Single(pp =>  pp.id == id);
            richTextBox1.Text = pl.PL;
        }
    }
}
