using System;
using System.IO;
using System.Windows.Forms;

namespace osztalypenztranzakcio
{
    public partial class Form1 : Form
    {
        int listadarab = 0;
        int osszeg = 0;

        public Form1()
        {
            
            InitializeComponent();
        }
        public void Szamol()
        {
            if (nev.Text != "" && penz.Text != "")
            {
                {
                    int penz = int.Parse(this.penz.Text);
                    
                        if (rdBefizet.Checked)
                        {
                            listadarab++;
                            osszeg += penz;
                            label5.Text = osszeg.ToString()+"FT";
                            lbLista.Items.Add(listadarab.ToString()+". tranzakció: "+nev.Text+" befizetett "+penz.ToString()+ " Ft ot.  Ekkor:" + dtpIdo.Value);
                        }
                    
                        else
                        {
                            if (osszeg >= penz)
                            {
                                listadarab++;
                                osszeg -= penz;
                                label5.Text = osszeg.ToString()+"FT";
                                lbLista.Items.Add(listadarab.ToString()+". tranzakció: "+penz.ToString()+" Ft ot fizettünk "+nev.Text+" számára.  Ekkor:"+dtpIdo.Value);
                            }
                           
                        }
                        nev.Text = "";
                        this.penz.Text = "";
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Szamol();
        }

        private void Fajlkiiras()
        {
            StreamWriter ki = File.CreateText("osztalypenz.txt");
            ki.WriteLine(osszeg);
            for (int i = 0; i < lbLista.Items.Count; i++)
            {
                ki.WriteLine(lbLista.Items[i]);
            }
            ki.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fajlkiiras();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Beolvas();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Beolvas()
        {
            if (!File.Exists("osztalypenz.txt"))
            {
                MessageBox.Show("Nincs ilyen fájl");
            }
            else
            {
                lbLista.Items.Clear();
                listadarab = 0;
                StreamReader be = File.OpenText("osztalypenz.txt");
                osszeg = int.Parse(be.ReadLine());
                label5.Text = osszeg.ToString() + " Ft";
                while (!be.EndOfStream)
                {
                    lbLista.Items.Add(be.ReadLine());
                    listadarab++;
                }
                be.Close();
            }
        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
