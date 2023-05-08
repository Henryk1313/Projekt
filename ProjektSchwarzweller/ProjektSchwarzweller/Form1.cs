using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Specialized;

namespace ProjektSchwarzweller
{
    public partial class Form1 : Form
    {
        IDictionary<string, string> slowaPol = new Dictionary<string, string>();
        IDictionary<string, string> slowaAng = new Dictionary<string, string>();
        int iloscslow = 0;
        bool zapisane = true;
        string nazwa = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tlumacz - H.S. 2023", "O programie");
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numUD.Value == 1)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
                bool dobrze = f2.czydobrze;
                if (dobrze)
                {
                    string poPolsku = f2.Polskie;
                    string poAngielsku = f2.Angielskie;
                    if (!slowaPol.ContainsKey(poPolsku) && !slowaAng.ContainsKey(poAngielsku))
                    {
                        slowaPol.Add(poPolsku, poAngielsku);
                        slowaAng.Add(poAngielsku, poPolsku);
                        iloscslow++;
                        zapisane = true;
                        txtilosc.Text = "ILOSC SLOW: " + iloscslow;
                        if (richTextBox1.Text == "")
                        {
                            richTextBox1.AppendText(poPolsku + " - " + poAngielsku);
                        }
                        else
                        {
                            richTextBox1.AppendText(Environment.NewLine + poPolsku + " - " + poAngielsku);
                        }
                    }
                    else
                    {
                        var odp = MessageBox.Show("slowa sie powtarzaja, czy chcesz zamienic znaczenia", "BLAD", MessageBoxButtons.YesNo);
                        if (odp == DialogResult.Yes)
                        {
                            if (slowaAng.ContainsKey(poAngielsku) && slowaPol.ContainsKey(poPolsku))
                            {
                                if (slowaAng[poAngielsku] == poPolsku && slowaPol[poPolsku] == poAngielsku)
                                {
                                    MessageBox.Show("TE SLOWA SA JUZ W BAZIE DANYCH", "BLAD");
                                }
                                else
                                {
                                    slowaPol.Remove(slowaAng[poAngielsku]);
                                    slowaAng.Remove(slowaPol[poPolsku]);
                                    slowaPol.Remove(poPolsku);
                                    slowaAng.Remove(poAngielsku);
                                    slowaPol.Add(poPolsku, poAngielsku);
                                    slowaAng.Add(poAngielsku, poPolsku);
                                    List<string> keys = slowaPol.Keys.ToList();
                                    richTextBox1.Text = keys[0] + " - " + slowaPol[keys[0]];
                                    for (int i = 1; i < keys.Count; i++)
                                    {
                                        richTextBox1.Text = richTextBox1.Text + Environment.NewLine + keys[i] + " - " + slowaPol[keys[i]];
                                    }
                                    iloscslow--;
                                    txtilosc.Text = "ILOSC SLOW: " + iloscslow;
                                    MessageBox.Show("slowo " + poPolsku + " jest zapisane jako: " + slowaPol[poPolsku], "ZMIANA SLOWA");
                                }
                            }
                            if (slowaPol.ContainsKey(poPolsku) && !slowaAng.ContainsKey(poAngielsku))
                            {
                                slowaAng.Remove(slowaPol[poPolsku]);
                                slowaPol.Remove(poPolsku);
                                slowaPol.Add(poPolsku, poAngielsku);
                                slowaAng.Add(poAngielsku, poPolsku);
                                List<string> keys = slowaPol.Keys.ToList();
                                richTextBox1.Text = keys[0] + " - " + slowaPol[keys[0]];
                                for (int i = 1; i < keys.Count; i++)
                                {
                                    richTextBox1.Text = richTextBox1.Text + Environment.NewLine + keys[i] + " - " + slowaPol[keys[i]];
                                }
                                MessageBox.Show("slowo " + poPolsku + " jest zapisane jako: " + slowaPol[poPolsku], "ZMIANA SLOWA");
                            }
                            if (slowaAng.ContainsKey(poAngielsku) && !slowaPol.ContainsKey(poPolsku))
                            {
                                slowaPol.Remove(slowaAng[poAngielsku]);
                                slowaAng.Remove(poAngielsku);
                                slowaPol.Add(poPolsku, poAngielsku);
                                slowaAng.Add(poAngielsku, poPolsku);
                                List<string> keys = slowaPol.Keys.ToList();
                                richTextBox1.Text = keys[0] + " - " + slowaPol[keys[0]];
                                for (int i = 1; i < keys.Count; i++)
                                {
                                    richTextBox1.Text = richTextBox1.Text + Environment.NewLine + keys[i] + " - " + slowaPol[keys[i]];
                                }
                                MessageBox.Show("slowo " + poPolsku + " jest zapisane jako: " + slowaPol[poPolsku], "ZMIANA SLOWA");
                            }
                            zapisane = false;
                        }
                        if (odp == DialogResult.No)
                        {
                            MessageBox.Show(poPolsku + " jest zapisane jako " + slowaPol[poPolsku], "BRAK ZMIANY");
                        }


                    }
                }
            }
            else
            {
                Form3 f3 = new Form3();
                DialogResult odp = f3.ShowDialog();
                if (odp == DialogResult.OK)
                {
                    bool dobrze = f3.czydobrze;
                    if (dobrze)
                    {
                        string DoUsun = f3.DoUsun;
                        if (!slowaPol.ContainsKey(DoUsun) && !slowaAng.ContainsKey(DoUsun))
                        {
                            MessageBox.Show("nie ma takiego slowa", "BLAD");
                        }
                        if (slowaPol.ContainsKey(DoUsun) && !slowaAng.ContainsKey(DoUsun))
                        {
                            slowaAng.Remove(slowaPol[DoUsun]);
                            slowaPol.Remove(DoUsun);
                            iloscslow--;
                            zapisane = false;
                            txtilosc.Text = "ILOSC SLOW: " + iloscslow;
                            List<string> keys = slowaPol.Keys.ToList();
                            if (keys.Count > 0)
                            {
                                richTextBox1.Text = keys[0] + " - " + slowaPol[keys[0]];
                                for (int i = 1; i < keys.Count; i++)
                                {
                                    richTextBox1.Text = richTextBox1.Text + Environment.NewLine + keys[i] + " - " + slowaPol[keys[i]];
                                }
                            }
                            else
                            {
                                richTextBox1.Text = "";
                            }

                        }
                        if (!slowaPol.ContainsKey(DoUsun) && slowaAng.ContainsKey(DoUsun))
                        {
                            slowaPol.Remove(slowaAng[DoUsun]);
                            slowaAng.Remove(DoUsun);
                            iloscslow--;
                            zapisane = false;
                            txtilosc.Text = "ILOSC SLOW: " + iloscslow;
                            List<string> keys = slowaPol.Keys.ToList();
                            if (keys.Count > 0)
                            {
                                richTextBox1.Text = keys[0] + " - " + slowaPol[keys[0]];
                                for (int i = 1; i < keys.Count; i++)
                                {
                                    richTextBox1.Text = richTextBox1.Text + Environment.NewLine + keys[i] + " - " + slowaPol[keys[i]];
                                }
                            }
                            else
                            {
                                richTextBox1.Text = "";
                            }
                        }
                    }
                }
            }
        }

        private void txtDoTlum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTlum_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbox_podp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbuttPolAng_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbuttAngPol_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonTlum_Click(object sender, EventArgs e)
        {
            if (chbox_podp.Checked)
            {
                if (rbuttPolAng.Checked)
                {
                    string PoPolsku = txtDoTlum.Text;
                    if (slowaPol.ContainsKey(PoPolsku))
                    {
                        txtTlum.Text = slowaPol[PoPolsku];
                    }
                    else
                    {
                        List<string> keys = slowaPol.Keys.ToList();
                        int najblizej = 0;
                        int w;
                        int minimalne = 9999999;
                        int dl = PoPolsku.Length;
                        for (int i = 0; i < keys.Count; i++)
                        {
                            w = 0;
                            int k = Math.Min(dl, keys[i].Length);
                            for (int j = 0; j < k; j++)
                            {
                                if (PoPolsku[j] != keys[i][j])
                                {
                                    w++;
                                }
                            }
                            w = w + Math.Max(dl, keys[i].Length) - k;
                            if (minimalne > w)
                            {
                                minimalne = w;
                                najblizej = i;
                            }
                        }
                        var odp = MessageBox.Show("NIE MA TAKIEGO SLOWA CZY CHODIZLO CI O " + keys[najblizej], "BLAD", MessageBoxButtons.YesNo);
                        if (odp == DialogResult.Yes)
                        {
                            PoPolsku = keys[najblizej];
                            txtDoTlum.Text = PoPolsku;
                            txtTlum.Text = slowaPol[PoPolsku];
                        }
                        else
                        {
                            MessageBox.Show("PODAJ INNE SLOWO", "BLAD");
                        }
                    }

                }
                else
                {
                    string PoAngielsku = txtDoTlum.Text;
                    if (slowaAng.ContainsKey(PoAngielsku))
                    {
                        txtTlum.Text = slowaAng[PoAngielsku];
                    }
                    else
                    {
                        List<string> keys = slowaAng.Keys.ToList();
                        int najblizej = 0;
                        int w;
                        int minimalne = 9999999;
                        int dl = PoAngielsku.Length;
                        for (int i = 0; i < keys.Count; i++)
                        {
                            w = 0;
                            int k = Math.Min(dl, keys[i].Length);
                            for (int j = 0; j < k; j++)
                            {
                                if (PoAngielsku[j] != keys[i][j])
                                {
                                    w++;
                                }
                            }
                            w = w + Math.Max(dl, keys[i].Length) - k;
                            if (minimalne > w)
                            {
                                minimalne = w;
                                najblizej = i;
                            }
                        }
                        var odp = MessageBox.Show("NIE MA TAKIEGO SLOWA CZY CHODIZLO CI O " + keys[najblizej], "BLAD", MessageBoxButtons.YesNo);
                        if (odp == DialogResult.Yes)
                        {
                            PoAngielsku = keys[najblizej];
                            txtDoTlum.Text = PoAngielsku;
                            txtTlum.Text = slowaAng[PoAngielsku];
                        }
                        else
                        {
                            MessageBox.Show("PODAJ INNE SLOWO", "BLAD");
                        }
                    }
                }
            }
            else
            {
                if (rbuttPolAng.Checked)
                {
                    string PoPolsku = txtDoTlum.Text;
                    if (slowaPol.ContainsKey(PoPolsku))
                    {
                        txtTlum.Text = slowaPol[PoPolsku];
                    }
                    else
                    {
                        MessageBox.Show("NIE MA TAKIEGO SLOWA W BAZIE DANYCH", "BLAD");
                    }
                }
                if (rbuttAngPol.Checked)
                {
                    string PoAngielsk = txtDoTlum.Text;
                    if (slowaAng.ContainsKey(PoAngielsk))
                    {
                        txtTlum.Text = slowaAng[PoAngielsk];
                    }
                    else
                    {
                        MessageBox.Show("NIE MA TAKIEGO SLOWA W BAZIE DANYCH", "BLAD");
                    }
                }
            }
        }

        private void numUD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void otworzToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var odp = MessageBox.Show("Czy chcesz wyzerowac baze danych? WSZYSTKIE SLOWA ZOSTANA UTRACONE", "TLUMACZ", MessageBoxButtons.YesNo);
            if (odp == DialogResult.Yes)
            {
                iloscslow = 0;
                txtilosc.Text = "ILOSC SLOW: " + iloscslow;
                slowaAng.Clear();
                slowaPol.Clear();
                richTextBox1.Text = "";
                zapisane = true;
            }
            
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
            nazwa = saveFileDialog1.FileName;
            zapisane = true;
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nazwa == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                }
                nazwa = saveFileDialog1.FileName;
            }
            else
            {
                richTextBox1.SaveFile(nazwa);
            }
            zapisane = true;
        }
    }
    
}
