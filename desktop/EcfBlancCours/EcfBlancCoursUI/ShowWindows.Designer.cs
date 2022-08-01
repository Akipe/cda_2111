namespace EcfBlancCoursUI
{
    partial class ShowWindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDiplomaName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDiplomaYear = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmployability = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbYearRegistered = new System.Windows.Forms.TextBox();
            this.tbLevel = new System.Windows.Forms.TextBox();
            this.lIdJobSeeker = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(148, 311);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 24);
            this.bClose.TabIndex = 21;
            this.bClose.Text = "Fermer";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDiplomaName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbDiplomaYear);
            this.groupBox1.Location = new System.Drawing.Point(2, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 87);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diplôme";
            // 
            // tbDiplomaName
            // 
            this.tbDiplomaName.Location = new System.Drawing.Point(100, 22);
            this.tbDiplomaName.Name = "tbDiplomaName";
            this.tbDiplomaName.ReadOnly = true;
            this.tbDiplomaName.Size = new System.Drawing.Size(121, 23);
            this.tbDiplomaName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Année";
            // 
            // tbDiplomaYear
            // 
            this.tbDiplomaYear.Location = new System.Drawing.Point(100, 51);
            this.tbDiplomaYear.Name = "tbDiplomaYear";
            this.tbDiplomaYear.ReadOnly = true;
            this.tbDiplomaYear.Size = new System.Drawing.Size(121, 23);
            this.tbDiplomaYear.TabIndex = 6;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(108, 64);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(121, 23);
            this.tbLastName.TabIndex = 19;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(108, 93);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(121, 23);
            this.tbFirstName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Niveau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Date d\'inscription";
            // 
            // tbEmployability
            // 
            this.tbEmployability.Location = new System.Drawing.Point(102, 282);
            this.tbEmployability.Name = "tbEmployability";
            this.tbEmployability.ReadOnly = true;
            this.tbEmployability.Size = new System.Drawing.Size(121, 23);
            this.tbEmployability.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Employabilité";
            // 
            // tbYearRegistered
            // 
            this.tbYearRegistered.Location = new System.Drawing.Point(108, 158);
            this.tbYearRegistered.Name = "tbYearRegistered";
            this.tbYearRegistered.ReadOnly = true;
            this.tbYearRegistered.Size = new System.Drawing.Size(121, 23);
            this.tbYearRegistered.TabIndex = 27;
            // 
            // tbLevel
            // 
            this.tbLevel.Location = new System.Drawing.Point(108, 125);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.ReadOnly = true;
            this.tbLevel.Size = new System.Drawing.Size(121, 23);
            this.tbLevel.TabIndex = 28;
            // 
            // lIdJobSeeker
            // 
            this.lIdJobSeeker.AutoSize = true;
            this.lIdJobSeeker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lIdJobSeeker.Location = new System.Drawing.Point(20, 21);
            this.lIdJobSeeker.Name = "lIdJobSeeker";
            this.lIdJobSeeker.Size = new System.Drawing.Size(52, 21);
            this.lIdJobSeeker.TabIndex = 29;
            this.lIdJobSeeker.Text = "label8";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(41, 311);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(85, 24);
            this.bSave.TabIndex = 30;
            this.bSave.Text = "Sauvegarder";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // ShowWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 351);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.lIdJobSeeker);
            this.Controls.Add(this.tbLevel);
            this.Controls.Add(this.tbYearRegistered);
            this.Controls.Add(this.tbEmployability);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ShowWindows";
            this.Text = "Affichage demandeur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowWindows_FormClosing);
            this.Load += new System.EventHandler(this.ShowWindows_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button bClose;
        private GroupBox groupBox1;
        private TextBox tbDiplomaName;
        private Label label4;
        private Label label5;
        private TextBox tbDiplomaYear;
        private TextBox tbLastName;
        private TextBox tbFirstName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox tbEmployability;
        private Label label7;
        private TextBox tbYearRegistered;
        private TextBox tbLevel;
        private Label lIdJobSeeker;
        private Button bSave;
    }
}