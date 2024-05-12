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
    public partial class statform : Form
    {
        public statform()
        {
            InitializeComponent();
        }

        private void statform_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'baseProjetDataSet1.Pann_Machine'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.pann_MachineTableAdapter.Fill(this.baseProjetDataSet1.Pann_Machine);
            // TODO: cette ligne de code charge les données dans la table 'baseProjetDataSet.Pann_Machine'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.pann_MachineTableAdapter.Fill(this.baseProjetDataSet.Pann_Machine);
            //TTF
            ProjetDataContext p = new ProjetDataContext();
            List<Pann_Machine> LE = null;
            LE = (from s in p.Pann_Machine select s).ToList<Pann_Machine>();


            try
            {
                int nbr = LE.Count();
              //  TimeSpan[] Lspan = new TimeSpan[nbr];
                for (int i = 0; i < LE.Count; i++)
                {

               
                    List<Pann_time> Lpt = null;
                    Lpt = (from s in p.Pann_time where s.machin == LE[i].machin select s).ToList<Pann_time>();
                    TimeSpan total = new TimeSpan();
                    total = DateTime.Now - DateTime.Now;
                    for (int j = 0; j < Lpt.Count; j++)
                    {
                        if (Lpt[j].date_s != null && Lpt[j].date_f != null)
                        {
                            total = (TimeSpan)(Lpt[j].date_f - Lpt[j].date_s) + total;
                        }
                    }
                     //= total.TotalHours.ToString() ;
                //   this.chart3.Series["TTR"].Points.AddXY(LE[i].machin,Convert.ToDouble(total.TotalHours));
                    this.chart3.Series["TTR"].Points.AddXY(LE[i].machin,(total.TotalHours));



                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
           
          
        }
    }
}
