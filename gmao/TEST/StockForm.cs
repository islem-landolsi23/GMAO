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
    public partial class StockForm : Form
    {
        int role;
        public StockForm(int id )
        {
            InitializeComponent();
            role = id;
            if (id != 0)
            { button1.Text = "Modifier";
                ProjetDataContext p = new ProjetDataContext();
                Piece_de_rechange s = new Piece_de_rechange();
                s = (from eqs in p.Piece_de_rechange where eqs.id == role select eqs).Single();
                boxnom.Text = s.nom;
                Quantitbox.Value =Convert.ToDecimal(s.quantite);
                PrixBox.Value= Convert.ToDecimal(s.prix); ;
                boxref.Text = s.REF;
              


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjetDataContext p = new ProjetDataContext();
            Piece_de_rechange s = new Piece_de_rechange();
            if (role == 0)
            {

                try
                {

                    s.nom= boxnom.Text;
                    s.quantite = Convert.ToInt32(Quantitbox.Value);
                    s.prix = Convert.ToInt32(PrixBox.Value);
                    s.REF = boxref.Text;

                    p.Piece_de_rechange.InsertOnSubmit(s);
                    p.SubmitChanges();
                    MessageBox.Show("5edmit");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    s = (from eqs in p.Piece_de_rechange where eqs.id == role select eqs).Single();
                    s.nom = boxnom.Text;
                    s.quantite = Convert.ToInt32(Quantitbox.Value);
                    s.prix = Convert.ToInt32(Quantitbox.Value);
                    s.REF = boxref.Text;
                    p.SubmitChanges();
                    MessageBox.Show("5edmit");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

         

        }
        }
            
    }
