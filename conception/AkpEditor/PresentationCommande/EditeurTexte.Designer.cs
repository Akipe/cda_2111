namespace PresentationCommande
{
    partial class EditeurTexte
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.zoneSaisie = new PresentationCommande.ZoneSaisie();
            this.bGras = new System.Windows.Forms.Button();
            this.bItalique = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTaillePolice = new System.Windows.Forms.NumericUpDown();
            this.bCharger = new System.Windows.Forms.Button();
            this.bSauvegarder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbTaillePolice)).BeginInit();
            this.SuspendLayout();
            // 
            // zoneSaisie
            // 
            this.zoneSaisie.Location = new System.Drawing.Point(12, 53);
            this.zoneSaisie.Multiline = true;
            this.zoneSaisie.Name = "zoneSaisie";
            this.zoneSaisie.Size = new System.Drawing.Size(353, 154);
            this.zoneSaisie.TabIndex = 0;
            this.zoneSaisie.Text = "Ceci est un article pour la demo :)";
            // 
            // bGras
            // 
            this.bGras.Location = new System.Drawing.Point(12, 12);
            this.bGras.Name = "bGras";
            this.bGras.Size = new System.Drawing.Size(45, 23);
            this.bGras.TabIndex = 1;
            this.bGras.Text = "Gras";
            this.bGras.UseVisualStyleBackColor = true;
            this.bGras.Click += new System.EventHandler(this.QuandCliqueGras);
            // 
            // bItalique
            // 
            this.bItalique.Location = new System.Drawing.Point(63, 12);
            this.bItalique.Name = "bItalique";
            this.bItalique.Size = new System.Drawing.Size(57, 23);
            this.bItalique.TabIndex = 2;
            this.bItalique.Text = "Italique";
            this.bItalique.UseVisualStyleBackColor = true;
            this.bItalique.Click += new System.EventHandler(this.QuandCliqueItalique);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Taille :";
            // 
            // tbTaillePolice
            // 
            this.tbTaillePolice.Location = new System.Drawing.Point(170, 12);
            this.tbTaillePolice.Name = "tbTaillePolice";
            this.tbTaillePolice.Size = new System.Drawing.Size(42, 23);
            this.tbTaillePolice.TabIndex = 4;
            this.tbTaillePolice.ValueChanged += new System.EventHandler(this.QuandDefinirTaillePolice);
            // 
            // bCharger
            // 
            this.bCharger.Location = new System.Drawing.Point(218, 12);
            this.bCharger.Name = "bCharger";
            this.bCharger.Size = new System.Drawing.Size(60, 23);
            this.bCharger.TabIndex = 5;
            this.bCharger.Text = "Charger";
            this.bCharger.UseVisualStyleBackColor = true;
            this.bCharger.Click += new System.EventHandler(this.CliqueCharger);
            // 
            // bSauvegarder
            // 
            this.bSauvegarder.Location = new System.Drawing.Point(284, 12);
            this.bSauvegarder.Name = "bSauvegarder";
            this.bSauvegarder.Size = new System.Drawing.Size(81, 23);
            this.bSauvegarder.TabIndex = 6;
            this.bSauvegarder.Text = "Sauvegarder";
            this.bSauvegarder.UseVisualStyleBackColor = true;
            this.bSauvegarder.Click += new System.EventHandler(this.CliqueSauvegarder);
            // 
            // EditeurTexte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 219);
            this.Controls.Add(this.bSauvegarder);
            this.Controls.Add(this.bCharger);
            this.Controls.Add(this.tbTaillePolice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bItalique);
            this.Controls.Add(this.bGras);
            this.Controls.Add(this.zoneSaisie);
            this.Name = "EditeurTexte";
            this.Text = "Editeur texte";
            ((System.ComponentModel.ISupportInitialize)(this.tbTaillePolice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bGras;
        private Button bItalique;
        private Label label1;
        private NumericUpDown tbTaillePolice;
        private Button bCharger;
        private Button bSauvegarder;
    }
}