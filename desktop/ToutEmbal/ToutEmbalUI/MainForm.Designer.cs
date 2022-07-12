namespace ToutEmbalUI
{
    partial class MainForm
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
            this.menuApp = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiQuitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiStopApp = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiInit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiInitA = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiInitB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiInitC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiShutdownA = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiShutdownB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiShutdownC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiResume = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiResumeA = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiResumeB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiResumeC = new System.Windows.Forms.ToolStripMenuItem();
            this.tabcProducersSpec = new System.Windows.Forms.TabControl();
            this.tabpA = new System.Windows.Forms.TabPage();
            this.producerSpecsA = new ToutEmbalUI.ProducerSpecs();
            this.tabpB = new System.Windows.Forms.TabPage();
            this.producerSpecsB = new ToutEmbalUI.ProducerSpecs();
            this.tabpC = new System.Windows.Forms.TabPage();
            this.producerSpecsC = new ToutEmbalUI.ProducerSpecs();
            this.producerLoadingA = new ToutEmbalUI.ProducerLoading();
            this.producerLoadingB = new ToutEmbalUI.ProducerLoading();
            this.producerLoadingC = new ToutEmbalUI.ProducerLoading();
            this.menuApp.SuspendLayout();
            this.tabcProducersSpec.SuspendLayout();
            this.tabpA.SuspendLayout();
            this.tabpB.SuspendLayout();
            this.tabpC.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuApp
            // 
            this.menuApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.productionToolStripMenuItem});
            this.menuApp.Location = new System.Drawing.Point(0, 0);
            this.menuApp.Name = "menuApp";
            this.menuApp.Size = new System.Drawing.Size(486, 24);
            this.menuApp.TabIndex = 2;
            this.menuApp.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuiQuitApp,
            this.menuiStopApp});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // menuiQuitApp
            // 
            this.menuiQuitApp.Name = "menuiQuitApp";
            this.menuiQuitApp.Size = new System.Drawing.Size(188, 22);
            this.menuiQuitApp.Text = "Quitter";
            // 
            // menuiStopApp
            // 
            this.menuiStopApp.Name = "menuiStopApp";
            this.menuiStopApp.Size = new System.Drawing.Size(188, 22);
            this.menuiStopApp.Text = "Terminer l\'application";
            this.menuiStopApp.Click += new System.EventHandler(this.Event_ShutdownAll);
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuiInit,
            this.menuiShutdown,
            this.menuiResume});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // menuiInit
            // 
            this.menuiInit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuiInitA,
            this.menuiInitB,
            this.menuiInitC});
            this.menuiInit.Name = "menuiInit";
            this.menuiInit.Size = new System.Drawing.Size(180, 22);
            this.menuiInit.Text = "Démarrer";
            // 
            // menuiInitA
            // 
            this.menuiInitA.Name = "menuiInitA";
            this.menuiInitA.Size = new System.Drawing.Size(180, 22);
            this.menuiInitA.Text = "A";
            this.menuiInitA.Click += new System.EventHandler(this.Event_StartProduction);
            // 
            // menuiInitB
            // 
            this.menuiInitB.Name = "menuiInitB";
            this.menuiInitB.Size = new System.Drawing.Size(180, 22);
            this.menuiInitB.Text = "B";
            this.menuiInitB.Click += new System.EventHandler(this.Event_StartProduction);
            // 
            // menuiInitC
            // 
            this.menuiInitC.Name = "menuiInitC";
            this.menuiInitC.Size = new System.Drawing.Size(180, 22);
            this.menuiInitC.Text = "C";
            this.menuiInitC.Click += new System.EventHandler(this.Event_StartProduction);
            // 
            // menuiShutdown
            // 
            this.menuiShutdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuiShutdownA,
            this.menuiShutdownB,
            this.menuiShutdownC});
            this.menuiShutdown.Name = "menuiShutdown";
            this.menuiShutdown.Size = new System.Drawing.Size(180, 22);
            this.menuiShutdown.Text = "Arrêter";
            this.menuiShutdown.Click += new System.EventHandler(this.Event_StopProduction);
            // 
            // menuiShutdownA
            // 
            this.menuiShutdownA.Name = "menuiShutdownA";
            this.menuiShutdownA.Size = new System.Drawing.Size(180, 22);
            this.menuiShutdownA.Text = "A";
            // 
            // menuiShutdownB
            // 
            this.menuiShutdownB.Name = "menuiShutdownB";
            this.menuiShutdownB.Size = new System.Drawing.Size(180, 22);
            this.menuiShutdownB.Text = "B";
            this.menuiShutdownB.Click += new System.EventHandler(this.Event_StopProduction);
            // 
            // menuiShutdownC
            // 
            this.menuiShutdownC.Name = "menuiShutdownC";
            this.menuiShutdownC.Size = new System.Drawing.Size(180, 22);
            this.menuiShutdownC.Text = "C";
            this.menuiShutdownC.Click += new System.EventHandler(this.Event_StopProduction);
            // 
            // menuiResume
            // 
            this.menuiResume.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuiResumeA,
            this.menuiResumeB,
            this.menuiResumeC});
            this.menuiResume.Name = "menuiResume";
            this.menuiResume.Size = new System.Drawing.Size(180, 22);
            this.menuiResume.Text = "Continuer";
            // 
            // menuiResumeA
            // 
            this.menuiResumeA.Name = "menuiResumeA";
            this.menuiResumeA.Size = new System.Drawing.Size(82, 22);
            this.menuiResumeA.Text = "A";
            // 
            // menuiResumeB
            // 
            this.menuiResumeB.Name = "menuiResumeB";
            this.menuiResumeB.Size = new System.Drawing.Size(82, 22);
            this.menuiResumeB.Text = "B";
            // 
            // menuiResumeC
            // 
            this.menuiResumeC.Name = "menuiResumeC";
            this.menuiResumeC.Size = new System.Drawing.Size(82, 22);
            this.menuiResumeC.Text = "C";
            // 
            // tabcProducersSpec
            // 
            this.tabcProducersSpec.Controls.Add(this.tabpA);
            this.tabcProducersSpec.Controls.Add(this.tabpB);
            this.tabcProducersSpec.Controls.Add(this.tabpC);
            this.tabcProducersSpec.Location = new System.Drawing.Point(35, 27);
            this.tabcProducersSpec.Name = "tabcProducersSpec";
            this.tabcProducersSpec.SelectedIndex = 0;
            this.tabcProducersSpec.Size = new System.Drawing.Size(378, 161);
            this.tabcProducersSpec.TabIndex = 3;
            // 
            // tabpA
            // 
            this.tabpA.Controls.Add(this.producerSpecsA);
            this.tabpA.Location = new System.Drawing.Point(4, 24);
            this.tabpA.Name = "tabpA";
            this.tabpA.Padding = new System.Windows.Forms.Padding(3);
            this.tabpA.Size = new System.Drawing.Size(370, 133);
            this.tabpA.TabIndex = 0;
            this.tabpA.Text = "Type A";
            this.tabpA.UseVisualStyleBackColor = true;
            // 
            // producerSpecsA
            // 
            this.producerSpecsA.Location = new System.Drawing.Point(0, 0);
            this.producerSpecsA.Manager = null;
            this.producerSpecsA.Name = "producerSpecsA";
            this.producerSpecsA.Size = new System.Drawing.Size(365, 135);
            this.producerSpecsA.TabIndex = 0;
            // 
            // tabpB
            // 
            this.tabpB.Controls.Add(this.producerSpecsB);
            this.tabpB.Location = new System.Drawing.Point(4, 24);
            this.tabpB.Name = "tabpB";
            this.tabpB.Padding = new System.Windows.Forms.Padding(3);
            this.tabpB.Size = new System.Drawing.Size(370, 133);
            this.tabpB.TabIndex = 1;
            this.tabpB.Text = "Type B";
            this.tabpB.UseVisualStyleBackColor = true;
            // 
            // producerSpecsB
            // 
            this.producerSpecsB.Location = new System.Drawing.Point(0, 0);
            this.producerSpecsB.Manager = null;
            this.producerSpecsB.Name = "producerSpecsB";
            this.producerSpecsB.Size = new System.Drawing.Size(365, 135);
            this.producerSpecsB.TabIndex = 0;
            // 
            // tabpC
            // 
            this.tabpC.Controls.Add(this.producerSpecsC);
            this.tabpC.Location = new System.Drawing.Point(4, 24);
            this.tabpC.Name = "tabpC";
            this.tabpC.Padding = new System.Windows.Forms.Padding(3);
            this.tabpC.Size = new System.Drawing.Size(370, 133);
            this.tabpC.TabIndex = 2;
            this.tabpC.Text = "Type C";
            this.tabpC.UseVisualStyleBackColor = true;
            // 
            // producerSpecsC
            // 
            this.producerSpecsC.Location = new System.Drawing.Point(0, 0);
            this.producerSpecsC.Manager = null;
            this.producerSpecsC.Name = "producerSpecsC";
            this.producerSpecsC.Size = new System.Drawing.Size(365, 135);
            this.producerSpecsC.TabIndex = 0;
            // 
            // producerLoadingA
            // 
            this.producerLoadingA.Location = new System.Drawing.Point(12, 194);
            this.producerLoadingA.Manager = null;
            this.producerLoadingA.Name = "producerLoadingA";
            this.producerLoadingA.Size = new System.Drawing.Size(459, 38);
            this.producerLoadingA.TabIndex = 4;
            // 
            // producerLoadingB
            // 
            this.producerLoadingB.Location = new System.Drawing.Point(12, 238);
            this.producerLoadingB.Manager = null;
            this.producerLoadingB.Name = "producerLoadingB";
            this.producerLoadingB.Size = new System.Drawing.Size(459, 40);
            this.producerLoadingB.TabIndex = 5;
            // 
            // producerLoadingC
            // 
            this.producerLoadingC.Location = new System.Drawing.Point(11, 284);
            this.producerLoadingC.Manager = null;
            this.producerLoadingC.Name = "producerLoadingC";
            this.producerLoadingC.Size = new System.Drawing.Size(459, 38);
            this.producerLoadingC.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 328);
            this.Controls.Add(this.producerLoadingC);
            this.Controls.Add(this.producerLoadingB);
            this.Controls.Add(this.producerLoadingA);
            this.Controls.Add(this.tabcProducersSpec);
            this.Controls.Add(this.menuApp);
            this.MainMenuStrip = this.menuApp;
            this.Name = "MainForm";
            this.Text = "Production des caisses";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuApp.ResumeLayout(false);
            this.menuApp.PerformLayout();
            this.tabcProducersSpec.ResumeLayout(false);
            this.tabpA.ResumeLayout(false);
            this.tabpB.ResumeLayout(false);
            this.tabpC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuApp;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem productionToolStripMenuItem;
        private ToolStripMenuItem menuiInit;
        private ToolStripMenuItem menuiInitA;
        private ToolStripMenuItem menuiInitB;
        private ToolStripMenuItem menuiInitC;
        private ToolStripMenuItem menuiShutdown;
        private ToolStripMenuItem menuiShutdownA;
        private ToolStripMenuItem menuiShutdownB;
        private ToolStripMenuItem menuiShutdownC;
        private ToolStripMenuItem menuiResume;
        private ToolStripMenuItem menuiResumeA;
        private ToolStripMenuItem menuiResumeB;
        private ToolStripMenuItem menuiResumeC;
        private TabControl tabcProducersSpec;
        private TabPage tabpA;
        private TabPage tabpB;
        private ProducerSpecs producerSpecsA;
        private TabPage tabpC;
        private ProducerLoading producerLoadingA;
        private ProducerLoading producerLoadingB;
        private ProducerLoading producerLoadingC;
        private ToolStripMenuItem menuiQuitApp;
        private ToolStripMenuItem menuiStopApp;
        private ProducerSpecs producerSpecsB;
        private ProducerSpecs producerSpecsC;
        private Label labelPRoduceA;
    }
}