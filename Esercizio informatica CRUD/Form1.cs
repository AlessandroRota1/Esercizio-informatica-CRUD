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
            Visualizza();
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

        private void Alfabetico(object sender, EventArgs e)
        {
            for (int i=0; i<dim; i++)
            {
                for (int j=i+1; j<dim; j++)
                {
                    if (string.Compare(p[i].prodotto, p[j].prodotto)>0)
                    {
                        string a = p[i].prodotto;
                        double b = p[i].prezzo;
                        p[i].prodotto = p[j].prodotto;
                        p[i].prezzo = p[j].prezzo;
                        p[j].prodotto = a;
                        p[j].prezzo = b;
                    }
                }
            }
            Visualizza();
            
        }

        private void Somm(object sender, EventArgs e)
        {
            double somma = 0;
            for (int i =0; i<dim; i++)
            {
                somma = somma+ p[i].prezzo;
            }
            Mostrasom.Text = "La somma è " + somma;
        }

        private void Per(object sender, EventArgs e)
        {
            double a= Convert.ToDouble(Percentuale.Text); ;
            for (int i=0; i<dim; i++)
            {
                if (Prodperc.Text == p[i].prodotto)
                {
                    p[i].prezzo = p[i].prezzo - (p[i].prezzo / 100*a);
                }
            }
            Visualizza();
        }
    }
}
