namespace MementoUI
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.lPersonage = new System.Windows.Forms.Label();
            this.lDefense = new System.Windows.Forms.Label();
            this.lAttaque = new System.Windows.Forms.Label();
            this.lChance = new System.Windows.Forms.Label();
            this.lDefenseValeur = new System.Windows.Forms.Label();
            this.lAttaqueValeur = new System.Windows.Forms.Label();
            this.lChanceValeur = new System.Windows.Forms.Label();
            this.bAugmenterDefense = new System.Windows.Forms.Button();
            this.bAugmenterAttaque = new System.Windows.Forms.Button();
            this.bSauvegarder = new System.Windows.Forms.Button();
            this.bRestaurer = new System.Windows.Forms.Button();
            this.cbInstantane = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lPersonage
            // 
            this.lPersonage.Image = ((System.Drawing.Image)(resources.GetObject("lPersonage.Image")));
            this.lPersonage.Location = new System.Drawing.Point(26, 62);
            this.lPersonage.Name = "lPersonage";
            this.lPersonage.Size = new System.Drawing.Size(234, 338);
            this.lPersonage.TabIndex = 0;
            // 
            // lDefense
            // 
            this.lDefense.AutoSize = true;
            this.lDefense.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lDefense.Location = new System.Drawing.Point(266, 100);
            this.lDefense.Name = "lDefense";
            this.lDefense.Size = new System.Drawing.Size(89, 25);
            this.lDefense.TabIndex = 1;
            this.lDefense.Text = "Defense :";
            // 
            // lAttaque
            // 
            this.lAttaque.AutoSize = true;
            this.lAttaque.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lAttaque.Location = new System.Drawing.Point(266, 154);
            this.lAttaque.Name = "lAttaque";
            this.lAttaque.Size = new System.Drawing.Size(87, 25);
            this.lAttaque.TabIndex = 2;
            this.lAttaque.Text = "Attaque :";
            // 
            // lChance
            // 
            this.lChance.AutoSize = true;
            this.lChance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lChance.Location = new System.Drawing.Point(268, 209);
            this.lChance.Name = "lChance";
            this.lChance.Size = new System.Drawing.Size(84, 25);
            this.lChance.TabIndex = 3;
            this.lChance.Text = "Chance :";
            // 
            // lDefenseValeur
            // 
            this.lDefenseValeur.AutoSize = true;
            this.lDefenseValeur.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lDefenseValeur.Location = new System.Drawing.Point(361, 100);
            this.lDefenseValeur.Name = "lDefenseValeur";
            this.lDefenseValeur.Size = new System.Drawing.Size(24, 25);
            this.lDefenseValeur.TabIndex = 4;
            this.lDefenseValeur.Text = "...";
            // 
            // lAttaqueValeur
            // 
            this.lAttaqueValeur.AutoSize = true;
            this.lAttaqueValeur.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lAttaqueValeur.Location = new System.Drawing.Point(361, 154);
            this.lAttaqueValeur.Name = "lAttaqueValeur";
            this.lAttaqueValeur.Size = new System.Drawing.Size(24, 25);
            this.lAttaqueValeur.TabIndex = 5;
            this.lAttaqueValeur.Text = "...";
            // 
            // lChanceValeur
            // 
            this.lChanceValeur.AutoSize = true;
            this.lChanceValeur.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lChanceValeur.Location = new System.Drawing.Point(361, 209);
            this.lChanceValeur.Name = "lChanceValeur";
            this.lChanceValeur.Size = new System.Drawing.Size(24, 25);
            this.lChanceValeur.TabIndex = 6;
            this.lChanceValeur.Text = "...";
            // 
            // bAugmenterDefense
            // 
            this.bAugmenterDefense.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAugmenterDefense.Location = new System.Drawing.Point(404, 99);
            this.bAugmenterDefense.Name = "bAugmenterDefense";
            this.bAugmenterDefense.Size = new System.Drawing.Size(35, 30);
            this.bAugmenterDefense.TabIndex = 7;
            this.bAugmenterDefense.Text = "+1";
            this.bAugmenterDefense.UseVisualStyleBackColor = true;
            this.bAugmenterDefense.Click += new System.EventHandler(this.bAugmenterDefense_Click);
            // 
            // bAugmenterAttaque
            // 
            this.bAugmenterAttaque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAugmenterAttaque.Location = new System.Drawing.Point(404, 152);
            this.bAugmenterAttaque.Name = "bAugmenterAttaque";
            this.bAugmenterAttaque.Size = new System.Drawing.Size(35, 32);
            this.bAugmenterAttaque.TabIndex = 8;
            this.bAugmenterAttaque.Text = "+1";
            this.bAugmenterAttaque.UseVisualStyleBackColor = true;
            this.bAugmenterAttaque.Click += new System.EventHandler(this.bAugmenterAttaque_Click);
            // 
            // bSauvegarder
            // 
            this.bSauvegarder.Location = new System.Drawing.Point(238, 286);
            this.bSauvegarder.Name = "bSauvegarder";
            this.bSauvegarder.Size = new System.Drawing.Size(83, 23);
            this.bSauvegarder.TabIndex = 9;
            this.bSauvegarder.Text = "Sauvegarder";
            this.bSauvegarder.UseVisualStyleBackColor = true;
            this.bSauvegarder.Click += new System.EventHandler(this.bSauvegarder_Click);
            // 
            // bRestaurer
            // 
            this.bRestaurer.Location = new System.Drawing.Point(238, 348);
            this.bRestaurer.Name = "bRestaurer";
            this.bRestaurer.Size = new System.Drawing.Size(75, 23);
            this.bRestaurer.TabIndex = 10;
            this.bRestaurer.Text = "Restaurer";
            this.bRestaurer.UseVisualStyleBackColor = true;
            this.bRestaurer.Click += new System.EventHandler(this.bRestaurer_Click);
            // 
            // cbInstantane
            // 
            this.cbInstantane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstantane.FormattingEnabled = true;
            this.cbInstantane.Location = new System.Drawing.Point(343, 348);
            this.cbInstantane.Name = "cbInstantane";
            this.cbInstantane.Size = new System.Drawing.Size(121, 23);
            this.cbInstantane.TabIndex = 11;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.cbInstantane);
            this.Controls.Add(this.bRestaurer);
            this.Controls.Add(this.bSauvegarder);
            this.Controls.Add(this.bAugmenterAttaque);
            this.Controls.Add(this.bAugmenterDefense);
            this.Controls.Add(this.lChanceValeur);
            this.Controls.Add(this.lAttaqueValeur);
            this.Controls.Add(this.lDefenseValeur);
            this.Controls.Add(this.lChance);
            this.Controls.Add(this.lAttaque);
            this.Controls.Add(this.lDefense);
            this.Controls.Add(this.lPersonage);
            this.Name = "UI";
            this.Text = "RPG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lPersonage;
        private Label lDefense;
        private Label lAttaque;
        private Label lChance;
        private Label lDefenseValeur;
        private Label lAttaqueValeur;
        private Label lChanceValeur;
        private Button bAugmenterDefense;
        private Button bAugmenterAttaque;
        private Button bSauvegarder;
        private Button bRestaurer;
        private ComboBox cbInstantane;
    }
}