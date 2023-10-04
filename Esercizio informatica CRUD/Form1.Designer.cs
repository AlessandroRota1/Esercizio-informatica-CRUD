namespace Esercizio_informatica_CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Insprod = new System.Windows.Forms.Label();
            this.Insprez = new System.Windows.Forms.Label();
            this.Prodotto = new System.Windows.Forms.TextBox();
            this.Prezzo = new System.Windows.Forms.TextBox();
            this.Listaprod = new System.Windows.Forms.ListBox();
            this.C = new System.Windows.Forms.Button();
            this.Prodvecchio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Prodnuovo = new System.Windows.Forms.TextBox();
            this.U = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Prezzonuovo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Prodcancellato = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.Button();
            this.Ordalf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Insprod
            // 
            this.Insprod.AutoSize = true;
            this.Insprod.Location = new System.Drawing.Point(66, 35);
            this.Insprod.Name = "Insprod";
            this.Insprod.Size = new System.Drawing.Size(97, 13);
            this.Insprod.TabIndex = 0;
            this.Insprod.Text = "Inserisci il prodotto:";
            // 
            // Insprez
            // 
            this.Insprez.AutoSize = true;
            this.Insprez.Location = new System.Drawing.Point(66, 74);
            this.Insprez.Name = "Insprez";
            this.Insprez.Size = new System.Drawing.Size(89, 13);
            this.Insprez.TabIndex = 1;
            this.Insprez.Text = "Inserisci il prezzo:";
            // 
            // Prodotto
            // 
            this.Prodotto.Location = new System.Drawing.Point(69, 51);
            this.Prodotto.Name = "Prodotto";
            this.Prodotto.Size = new System.Drawing.Size(118, 20);
            this.Prodotto.TabIndex = 2;
            // 
            // Prezzo
            // 
            this.Prezzo.Location = new System.Drawing.Point(69, 90);
            this.Prezzo.Name = "Prezzo";
            this.Prezzo.Size = new System.Drawing.Size(118, 20);
            this.Prezzo.TabIndex = 3;
            // 
            // Listaprod
            // 
            this.Listaprod.FormattingEnabled = true;
            this.Listaprod.Location = new System.Drawing.Point(420, 35);
            this.Listaprod.Name = "Listaprod";
            this.Listaprod.Size = new System.Drawing.Size(237, 342);
            this.Listaprod.TabIndex = 4;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(214, 51);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(100, 44);
            this.C.TabIndex = 5;
            this.C.Text = "Inserisci il prodotto in lista:";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.Create);
            // 
            // Prodvecchio
            // 
            this.Prodvecchio.Location = new System.Drawing.Point(69, 178);
            this.Prodvecchio.Name = "Prodvecchio";
            this.Prodvecchio.Size = new System.Drawing.Size(118, 20);
            this.Prodvecchio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Inserisci il prodotto da modificare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Inserisci il nuovo nome del prodotto:";
            // 
            // Prodnuovo
            // 
            this.Prodnuovo.Location = new System.Drawing.Point(69, 217);
            this.Prodnuovo.Name = "Prodnuovo";
            this.Prodnuovo.Size = new System.Drawing.Size(118, 20);
            this.Prodnuovo.TabIndex = 10;
            // 
            // U
            // 
            this.U.Location = new System.Drawing.Point(248, 162);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(100, 44);
            this.U.TabIndex = 11;
            this.U.Text = "Modifica lista:";
            this.U.UseVisualStyleBackColor = true;
            this.U.Click += new System.EventHandler(this.Update);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Inserisci il nuovo prezzo del prodotto:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Prezzonuovo
            // 
            this.Prezzonuovo.Location = new System.Drawing.Point(69, 256);
            this.Prezzonuovo.Name = "Prezzonuovo";
            this.Prezzonuovo.Size = new System.Drawing.Size(114, 20);
            this.Prezzonuovo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Inserisci il prodotto da cancellare:";
            // 
            // Prodcancellato
            // 
            this.Prodcancellato.Location = new System.Drawing.Point(69, 333);
            this.Prodcancellato.Name = "Prodcancellato";
            this.Prodcancellato.Size = new System.Drawing.Size(118, 20);
            this.Prodcancellato.TabIndex = 15;
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(248, 314);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(111, 39);
            this.D.TabIndex = 16;
            this.D.Text = "Cancella prodotto:";
            this.D.UseVisualStyleBackColor = true;
            // 
            // Ordalf
            // 
            this.Ordalf.Location = new System.Drawing.Point(69, 384);
            this.Ordalf.Name = "Ordalf";
            this.Ordalf.Size = new System.Drawing.Size(135, 45);
            this.Ordalf.TabIndex = 17;
            this.Ordalf.Text = "Visualizza lista in ordine alfabetico:";
            this.Ordalf.UseVisualStyleBackColor = true;
            this.Ordalf.Click += new System.EventHandler(this.Alfabetico);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ordalf);
            this.Controls.Add(this.D);
            this.Controls.Add(this.Prodcancellato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Prezzonuovo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.U);
            this.Controls.Add(this.Prodnuovo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prodvecchio);
            this.Controls.Add(this.C);
            this.Controls.Add(this.Listaprod);
            this.Controls.Add(this.Prezzo);
            this.Controls.Add(this.Prodotto);
            this.Controls.Add(this.Insprez);
            this.Controls.Add(this.Insprod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Delete);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Insprod;
        private System.Windows.Forms.Label Insprez;
        private System.Windows.Forms.TextBox Prodotto;
        private System.Windows.Forms.TextBox Prezzo;
        private System.Windows.Forms.ListBox Listaprod;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.TextBox Prodvecchio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Prodnuovo;
        private System.Windows.Forms.Button U;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Prezzonuovo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Prodcancellato;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button Ordalf;
    }
}

