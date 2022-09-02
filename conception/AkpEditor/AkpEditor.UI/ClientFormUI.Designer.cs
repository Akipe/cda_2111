using AkpEditor.UI.Recepteur;

namespace AkpEditor.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientFormUI));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.cCouleurNoire = new System.Windows.Forms.ToolStripMenuItem();
            this.cCouleurRouge = new System.Windows.Forms.ToolStripMenuItem();
            this.cCouleurVert = new System.Windows.Forms.ToolStripMenuItem();
            this.cCouleurOrange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.cTailleAugmenter1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cTailleDiminuer1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cTaillePersonalise = new System.Windows.Forms.ToolStripTextBox();
            this.cGras = new System.Windows.Forms.ToolStripButton();
            this.cItalique = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cAnnuler = new System.Windows.Forms.ToolStripButton();
            this.afficherHistorique = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoDerniereCommande = new System.Windows.Forms.ToolStripStatusLabel();
            this.recepteurContenu = new AkpEditor.UI.Recepteur.RecepteurContenu();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.cGras,
            this.cItalique,
            this.toolStripLabel1,
            this.cAnnuler,
            this.afficherHistorique});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(488, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cCouleurNoire,
            this.cCouleurRouge,
            this.cCouleurVert,
            this.cCouleurOrange});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(65, 22);
            this.toolStripSplitButton1.Text = "Couleur";
            // 
            // cCouleurNoire
            // 
            this.cCouleurNoire.Name = "cCouleurNoire";
            this.cCouleurNoire.Size = new System.Drawing.Size(113, 22);
            this.cCouleurNoire.Text = "Noire";
            this.cCouleurNoire.Click += new System.EventHandler(this.cCouleurNoire_Click);
            // 
            // cCouleurRouge
            // 
            this.cCouleurRouge.Name = "cCouleurRouge";
            this.cCouleurRouge.Size = new System.Drawing.Size(113, 22);
            this.cCouleurRouge.Text = "Rouge";
            this.cCouleurRouge.Click += new System.EventHandler(this.cCouleurRouge_Click);
            // 
            // cCouleurVert
            // 
            this.cCouleurVert.Name = "cCouleurVert";
            this.cCouleurVert.Size = new System.Drawing.Size(113, 22);
            this.cCouleurVert.Text = "Vert";
            this.cCouleurVert.Click += new System.EventHandler(this.cCouleurVert_Click);
            // 
            // cCouleurOrange
            // 
            this.cCouleurOrange.Name = "cCouleurOrange";
            this.cCouleurOrange.Size = new System.Drawing.Size(113, 22);
            this.cCouleurOrange.Text = "Orange";
            this.cCouleurOrange.Click += new System.EventHandler(this.cCouleurOrange_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cTailleAugmenter1,
            this.cTailleDiminuer1,
            this.cTaillePersonalise});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(95, 22);
            this.toolStripSplitButton2.Text = "Taille du texte";
            // 
            // cTailleAugmenter1
            // 
            this.cTailleAugmenter1.Name = "cTailleAugmenter1";
            this.cTailleAugmenter1.Size = new System.Drawing.Size(160, 22);
            this.cTailleAugmenter1.Text = "Augmenter de 1";
            this.cTailleAugmenter1.Click += new System.EventHandler(this.cTailleAugmenter1_Click);
            // 
            // cTailleDiminuer1
            // 
            this.cTailleDiminuer1.Name = "cTailleDiminuer1";
            this.cTailleDiminuer1.Size = new System.Drawing.Size(160, 22);
            this.cTailleDiminuer1.Text = "Diminuer de 1";
            this.cTailleDiminuer1.Click += new System.EventHandler(this.cTailleDiminuer1_Click);
            // 
            // cTaillePersonalise
            // 
            this.cTaillePersonalise.Name = "cTaillePersonalise";
            this.cTaillePersonalise.Size = new System.Drawing.Size(100, 23);
            this.cTaillePersonalise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cTaillePersonalise_KeyPress);
            // 
            // cGras
            // 
            this.cGras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cGras.Image = ((System.Drawing.Image)(resources.GetObject("cGras.Image")));
            this.cGras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cGras.Name = "cGras";
            this.cGras.Size = new System.Drawing.Size(34, 22);
            this.cGras.Text = "Gras";
            this.cGras.Click += new System.EventHandler(this.cGras_Click);
            // 
            // cItalique
            // 
            this.cItalique.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cItalique.Image = ((System.Drawing.Image)(resources.GetObject("cItalique.Image")));
            this.cItalique.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cItalique.Name = "cItalique";
            this.cItalique.Size = new System.Drawing.Size(50, 22);
            this.cItalique.Tag = "";
            this.cItalique.Text = "Italique";
            this.cItalique.Click += new System.EventHandler(this.cItalique_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            // 
            // cAnnuler
            // 
            this.cAnnuler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("cAnnuler.Image")));
            this.cAnnuler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cAnnuler.Name = "cAnnuler";
            this.cAnnuler.Size = new System.Drawing.Size(53, 22);
            this.cAnnuler.Text = "Annuler";
            this.cAnnuler.ToolTipText = "Annuler";
            this.cAnnuler.Click += new System.EventHandler(this.cAnnuler_Click);
            // 
            // afficherHistorique
            // 
            this.afficherHistorique.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.afficherHistorique.Image = ((System.Drawing.Image)(resources.GetObject("afficherHistorique.Image")));
            this.afficherHistorique.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.afficherHistorique.Name = "afficherHistorique";
            this.afficherHistorique.Size = new System.Drawing.Size(66, 22);
            this.afficherHistorique.Text = "Historique";
            this.afficherHistorique.Click += new System.EventHandler(this.afficherHistorique_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.infoDerniereCommande});
            this.statusStrip1.Location = new System.Drawing.Point(0, 272);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(488, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel1.Text = "Dernière commande :";
            // 
            // infoDerniereCommande
            // 
            this.infoDerniereCommande.Name = "infoDerniereCommande";
            this.infoDerniereCommande.Size = new System.Drawing.Size(118, 17);
            this.infoDerniereCommande.Text = "toolStripStatusLabel2";
            // 
            // recepteurContenu
            // 
            this.recepteurContenu.Location = new System.Drawing.Point(12, 28);
            this.recepteurContenu.Name = "recepteurContenu";
            this.recepteurContenu.Size = new System.Drawing.Size(466, 236);
            this.recepteurContenu.TabIndex = 4;
            this.recepteurContenu.Load += new System.EventHandler(this.recepteurContenu_Load);
            // 
            // ClientFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 294);
            this.Controls.Add(this.recepteurContenu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ClientFormUI";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientFormUI_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem cCouleurNoire;
        private ToolStripMenuItem cCouleurRouge;
        private ToolStripMenuItem cCouleurVert;
        private ToolStripSplitButton toolStripSplitButton2;
        private ToolStripMenuItem cTailleAugmenter1;
        private ToolStripMenuItem cTailleDiminuer1;
        private ToolStripButton cAnnuler;
        private ToolStripMenuItem cCouleurOrange;
        private ToolStripTextBox cTaillePersonalise;
        private ToolStripButton cGras;
        private ToolStripButton cItalique;
        private ToolStripButton afficherHistorique;
        private ToolStripLabel toolStripLabel1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel infoDerniereCommande;
        private RecepteurContenu recepteurContenu;
    }
}