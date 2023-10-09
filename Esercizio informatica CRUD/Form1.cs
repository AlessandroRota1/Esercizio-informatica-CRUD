using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            double prezzo;
            if (double.TryParse(Prezzo.Text, out prezzo))
            {
                p[dim].prezzo = prezzo;
                dim++;
            }
            else
            {
                MessageBox.Show("Il carattere inserito non è un numero");
            }

        }
        public void Visualizza()
        {
            Listaprod.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                Listaprod.Items.Add("Prodotto: " + p[i].prodotto + " Prezzo: " + p[i].prezzo);
            }
        }
        public int GetLength(string str)
        {
            int lunghezza = 0, l = 0;
            str += '^';
            while (str[l] != '^')
            {
                lunghezza++;
                l++;
            }

            return lunghezza;
        }

        public string[] Split(string stringa)
        {
            string[] array = new string[20];
            string frase = "";
            int p = 0;
            for (int i = 0; i < GetLength(stringa); i++)
            {
                if (stringa[i] == ';')
                {
                    array[p] = frase;
                    p++;
                    frase = "";
                }
                else
                {
                    frase += stringa[i];
                }

                if (i == stringa.Length - 1)
                {
                    array[p] = frase;
                }
            }
            return array;
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
            bool controllo = false;
            for (int i=0; i<dim; i++)
            {
                if (p[i].prodotto == Prodvecchio.Text)
                {
                    p[i].prodotto = Prodnuovo.Text;
                    p[i].prezzo = double.Parse(Prezzonuovo.Text);
                    controllo = true;
                }
            }
            if (controllo==false)
            {
                MessageBox.Show("Il prodotto digitato non è presente in lista");
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

        private void Min_Click(object sender, EventArgs e)
        {
            double a = p[0].prezzo;
            string b = p[0].prodotto;
            for (int i=0; i<dim; i++)
            {
                if (p[i].prezzo<a)
                {
                    a = p[i].prezzo;
                    b = p[i].prodotto;
                }
            }
            minimo.Text = "Prodotto: " + b + " Prezzo: " + a;
        }

        private void max_Click(object sender, EventArgs e)
        {
            double a = 0;
            string b = p[0].prodotto;
            for (int i=0; i<dim; i++)
            {
                if (p[i].prezzo>a)
                {
                    a=p[i].prezzo;
                    b=p[i].prodotto;
                }
            }
            massimo.Text = "Prodotto: " + b + " Prezzo: " + a;
        }

        private void Lettura_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("lettura.txt");
            do
            {
                string[] prodprez = new string[2];
                string array = file.ReadLine();
                prodprez = Split(array);
                Listaprod.Items.Add("Prodotto: " + prodprez[0]+" Prezzo: " + prodprez[1]) ;
            } while (!file.EndOfStream);
            file.Close();
        }

        private void Scrittura_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("scrittura.txt");
            for (int i=0; i<dim; i++)
            {
                file.WriteLine((p[i].prodotto)+"; " + p[i].prezzo );
            }
            file.Close();
        }
    }
}
