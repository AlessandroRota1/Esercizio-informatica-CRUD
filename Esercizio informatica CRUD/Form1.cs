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
        public void Visualizza()
        {
            Listaprod.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                Listaprod.Items.Add("Prodotto: " + p[i].prodotto + " Prezzo: " + p[i].prezzo);
            }
        }

        private void Create(object sender, EventArgs e)
        {
            Aggiunta();
        }

        private void Read(object sender, EventArgs e)
        {
            Visualizza();
        }

        private void Update(object sender, EventArgs e)
        {
            for (int i=0; i<dim; i++)
            {
                if (p[i].prodotto == Prodvecchio.Text)
                {
                    p[i].prodotto = Prodnuovo.Text;
                    p[i].prezzo = double.Parse(Prezzonuovo.Text);
                }
            }
            Visualizza();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Delete(object sender, EventArgs e)
        {
            bool controllo = false;
            int i = 0;
            while (controllo == false)
            {
                if (p[i].prodotto == Prodcancellato.Text)
                {
                    controllo = true;
                }
                i++;
            }
            if (controllo == true)
            {
                for (int k = i - 1; k < dim; k++)
                {
                    p[k].prodotto = p[k + 1].prodotto;
                    p[k].prezzo = p[k + 1].prezzo;
                }

                dim--;
            }
            Visualizza();
        }
    }
}
