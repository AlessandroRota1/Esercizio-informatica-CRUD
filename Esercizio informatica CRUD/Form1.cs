using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_informatica_CRUD
{
    public partial class Form1 : Form
    {
        public struct PrezzoProdotto
        {
            public string prodotto;
            public double prezzo;
        }
        public PrezzoProdotto[] p = new PrezzoProdotto[100];
        public int dim = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void Aggiunta()
        {
            p[dim].prodotto = Prodotto.Text;
            p[dim].prezzo = double.Parse(Prezzo.Text);
            dim++;
        }

        private void Create(object sender, EventArgs e)
        {
            Aggiunta();
        }
    }
}
