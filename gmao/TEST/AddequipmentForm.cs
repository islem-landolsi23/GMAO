using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class AddequipmentForm : Form
    {
        int role;
        public AddequipmentForm(int id)
        {
            InitializeComponent();
            role = id;
            if (role != 0)
            {
                ProjetDataContext p = new ProjetDataContext();
               machine eq = new machine();
                ajouter.Text = "Modifier";
                eq = (from eqs in p.machine where eqs.ID == role select eqs).Single();
                boxnom.Text = eq.NOM;
                boxfg.Text = eq.equipement;
                boxunite.Text = eq.UNITE;
                boxref.Text = eq.REFERENCE;
        
                comboBox1.SelectedIndex = eq.PANNE;
                try
                {
                    MemoryStream ms = new MemoryStream(eq.IMAGE.ToArray());
                    pictureBox1.Image = Image.FromStream(ms);
                }
                catch { }
            }
        }
        Image imag;
        byte[] photobyte;
        private void ajouter_Click(object sender, EventArgs e)
        {
            ProjetDataContext p = new ProjetDataContext();
            machine equipment = new machine();
            ImageConverter convert = new ImageConverter();


            if ( role== 0) {
                try
                {

                    equipment.NOM = boxnom.Text;
                    equipment.equipement = boxfg.Text;
                    equipment.UNITE = boxunite.Text;
                    equipment.REFERENCE = boxref.Text;

                    equipment.PANNE = comboBox1.SelectedIndex;
                    imag = pictureBox1.Image;
                    photobyte = (byte[])convert.ConvertTo(imag, typeof(byte[]));
                    equipment.IMAGE = photobyte;
                    p.machine.InsertOnSubmit(equipment);
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
                equipment = (from eqs in p.machine where eqs.ID == role select eqs).Single();
                String nom = equipment.NOM;
             
                try
                {

                    equipment.NOM = boxnom.Text;
                    equipment.equipement = boxfg.Text;
                    equipment.UNITE = boxunite.Text;
                    equipment.REFERENCE = boxref.Text;

                    equipment.PANNE = comboBox1.SelectedIndex;
                    imag = pictureBox1.Image;
                    photobyte = (byte[])convert.ConvertTo(imag, typeof(byte[]));
                    equipment.IMAGE = photobyte;
                   
                    

                    p.SubmitChanges();
                    MessageBox.Show("5edmit");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Boolean ok = false;
                try
                {
                    

                    if (nom != equipment.NOM)
                    {
                        Pann_Machine pn = (from pp in p.Pann_Machine where pp.machin == nom select pp).Single();
                        pn.machin = equipment.NOM;
                        List<Pann_time> lpt = (from tt in p.Pann_time where tt.machin == nom select tt).ToList<Pann_time>();
                        foreach (Pann_time pt in lpt)
                        {
                            pt.machin = equipment.NOM;

                        }
                        p.SubmitChanges();
                    }

                }
                catch { }

            }
            
    

        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "image jpg(*.jpg)|*.jpg| image png(*.png)|*.png";
           
            if (op.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
              
            }
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if(data!=null)
            {
                var Filename = data as String[];
                if (Filename.Length > 0)
                    pictureBox1.Image = Image.FromFile(Filename[0]);
            }

        }

        private void AddequipmentForm_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
