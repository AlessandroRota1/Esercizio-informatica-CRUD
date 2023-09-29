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
            this.R = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Insprod
            // 
            this.Insprod.AutoSize = true;
            this.Insprod.Location = new System.Drawing.Point(66, 65);
            this.Insprod.Name = "Insprod";
            this.Insprod.Size = new System.Drawing.Size(97, 13);
            this.Insprod.TabIndex = 0;
            this.Insprod.Text = "Inserisci il prodotto:";
            // 
            // Insprez
            // 
            this.Insprez.AutoSize = true;
            this.Insprez.Location = new System.Drawing.Point(66, 114);
            this.Insprez.Name = "Insprez";
            this.Insprez.Size = new System.Drawing.Size(89, 13);
            this.Insprez.TabIndex = 1;
            this.Insprez.Text = "Inserisci il prezzo:";
            // 
            // Prodotto
            // 
            this.Prodotto.Location = new System.Drawing.Point(69, 81);
            this.Prodotto.Name = "Prodotto";
            this.Prodotto.Size = new System.Drawing.Size(118, 20);
            this.Prodotto.TabIndex = 2;
            // 
            // Prezzo
            // 
            this.Prezzo.Location = new System.Drawing.Point(69, 130);
            this.Prezzo.Name = "Prezzo";
            this.Prezzo.Size = new System.Drawing.Size(118, 20);
            this.Prezzo.TabIndex = 3;
            // 
            // Listaprod
            // 
            this.Listaprod.FormattingEnabled = true;
            this.Listaprod.Location = new System.Drawing.Point(453, 81);
            this.Listaprod.Name = "Listaprod";
            this.Listaprod.Size = new System.Drawing.Size(237, 342);
            this.Listaprod.TabIndex = 4;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(69, 174);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(100, 44);
            this.C.TabIndex = 5;
            this.C.Text = "Inserisci il prodotto in lista:";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.Create);
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(69, 234);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(100, 44);
            this.R.TabIndex = 6;
            this.R.Text = "Visualizza lista prodotti:";
            this.R.UseVisualStyleBackColor = true;
            this.R.Click += new System.EventHandler(this.Read);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.R);
            this.Controls.Add(this.C);
            this.Controls.Add(this.Listaprod);
            this.Controls.Add(this.Prezzo);
            this.Controls.Add(this.Prodotto);
            this.Controls.Add(this.Insprez);
            this.Controls.Add(this.Insprod);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button R;
    }
}

