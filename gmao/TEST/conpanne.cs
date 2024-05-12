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
    public partial class conpanne : Form
    {
        public conpanne(int id)
        {
            InitializeComponent();
            ProjetDataContext p = new ProjetDataContext();
             Table_Panne tb = (from x in p.Table_Panne where x.id == id select x).Single();
            labm.Text = tb.machine;
            dateTimePicker1.Value = tb.date;
            if (tb.description != null)
                boxd.Text = tb.description;
            if (tb.solution != null)
                boxs.Text = tb.solution;
        }
    }
}
