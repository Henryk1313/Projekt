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
    public partial class Form3 : Form
    {
        public string slowoDOusun;
        public bool poprawnosc = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            slowoDOusun = txtBusun.Text;
            if (!CzyPoprawne(slowoDOusun))
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
            {
                return poprawnosc;
            }
        }

        public string DoUsun
        {
            get
            {
                return slowoDOusun;
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
