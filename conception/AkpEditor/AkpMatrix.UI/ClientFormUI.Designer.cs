namespace AkpMatrix.UI
{
    partial class ClientFormUI
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
            this.lbListSauvegarde = new System.Windows.Forms.ListBox();
            this.bSauvegarde = new System.Windows.Forms.Button();
            this.bRestaurer = new System.Windows.Forms.Button();
            this.Document = new AkpEditor.UI.Recepteur.RecepteurContenu();
            this.SuspendLayout();
            // 
            // lbListSauvegarde
            // 
            this.lbListSauvegarde.FormattingEnabled = true;
            this.lbListSauvegarde.ItemHeight = 15;
            this.lbListSauvegarde.Location = new System.Drawing.Point(485, 41);
            this.lbListSauvegarde.Name = "lbListSauvegarde";
            this.lbListSauvegarde.Size = new System.Drawing.Size(184, 169);
            this.lbListSauvegarde.TabIndex = 1;
            // 
            // bSauvegarde
            // 
            this.bSauvegarde.Location = new System.Drawing.Point(485, 12);
            this.bSauvegarde.Name = "bSauvegarde";
            this.bSauvegarde.Size = new System.Drawing.Size(184, 23);
            this.bSauvegarde.TabIndex = 2;
            this.bSauvegarde.Text = "Sauvegarder";
            this.bSauvegarde.UseVisualStyleBackColor = true;
            // 
            // bRestaurer
            // 
            this.bRestaurer.Location = new System.Drawing.Point(484, 216);
            this.bRestaurer.Name = "bRestaurer";
            this.bRestaurer.Size = new System.Drawing.Size(184, 23);
            this.bRestaurer.TabIndex = 3;
            this.bRestaurer.Text = "Restaurer";
            this.bRestaurer.UseVisualStyleBackColor = true;
            // 
            // Document
            // 
            this.Document.Location = new System.Drawing.Point(12, 12);
            this.Document.Name = "Document";
            this.Document.Size = new System.Drawing.Size(466, 236);
            this.Document.TabIndex = 4;
            // 
            // ClientFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 265);
            this.Controls.Add(this.Document);
            this.Controls.Add(this.bRestaurer);
            this.Controls.Add(this.bSauvegarde);
            this.Controls.Add(this.lbListSauvegarde);
            this.Name = "ClientFormUI";
            this.Text = "Interface";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbListSauvegarde;
        private Button bSauvegarde;
        private Button bRestaurer;
        private AkpEditor.UI.Recepteur.RecepteurContenu Document;
    }
}