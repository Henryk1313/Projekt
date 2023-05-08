using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ProjektSchwarzweller
{
    public partial class Form2 : Form
    {
        string Pol = "";
        string Ang = "";
        bool poprawnosc = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDod_Click(object sender, EventArgs e)
        {
            Pol = txtPOL.Text;
            Ang = txtANG.Text;
            if (!CzyPoprawne(Pol) || !CzyPoprawne(Ang))
            {
                MessageBox.Show("PODAJ SLOWA SKLADAJACE SIE Z MALYCH LITER", "BLAD");
            }
            else
            {
                poprawnosc = true;
                this.Close();
            }
        }
        public bool czydobrze
        {
            get
            { return poprawnosc; }
        }
        public string Polskie
        {
            get
            {
                return Pol;
            }
        }
        public string Angielskie
        {
            get
            {
                return Ang;
            }
        }

        private bool CzyPoprawne(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > 'z' || s[i] < 'a')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
