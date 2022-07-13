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
            this.components = new System.ComponentModel.Container();
            this.menuApp = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiQuitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiShutdownProduction = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiLaunch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiLaunchA = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiLaunchB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiLaunchC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiStop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiStopA = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiStopB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiStopC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiStartA = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiStartB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuiStartC = new System.Windows.Forms.ToolStripMenuItem();
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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusProdA = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProdB = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProdC = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.bALaunch = new System.Windows.Forms.Button();
            this.bAStop = new System.Windows.Forms.Button();
            this.bAStart = new System.Windows.Forms.Button();
            this.bBStart = new System.Windows.Forms.Button();
            this.bBStop = new System.Windows.Forms.Button();
            this.bBLaunch = new System.Windows.Forms.Button();
            this.bCStart = new System.Windows.Forms.Button();
            this.bCStop = new System.Windows.Forms.Button();
            this.bCLaunch = new System.Windows.Forms.Button();
            this.menuApp.SuspendLayout();
            this.tabcProducersSpec.SuspendLayout();
            this.tabpA.SuspendLayout();
            this.tabpB.SuspendLayout();
            this.tabpC.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuApp
            // 
            this.menuApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.productionToolStripMenuItem});
            this.menuApp.Location = new System.Drawing.Point(0, 0);
            this.menuApp.Name = "menuApp";
            this.menuApp.Size = new System.Drawing.Size(529, 24);
            this.menuApp.TabIndex = 2;
            this.menuApp.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuiQuitApp,
            this.menuiShutdownProduction});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // menuiQuitApp
            // 
            this.menuiQuitApp.Name = "menuiQuitApp";
            this.menuiQuitApp.Size = new System.Drawing.Size(188, 22);
            this.menuiQuitApp.Text = "Quitter";
            this.menuiQuitApp.Click += new System.EventHandler(this.menuiQuitApp_Click);
            // 
            // menuiShutdownProduction
            // 
            this.menuiShutdownProduction.Name = "menuiShutdownProduction";
            this.menuiShutdownProduction.Size = new System.Drawing.Size(188, 22);
            this.menuiShutdownProduction.Text = "Terminer l\'application";
            this.menuiShutdownProduction.Click += new System.EventHandler(this.Event_ShutdownAll);
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuiLaunch,
            this.menuiStop,
            this.menuiStart});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // menuiLaunch
            // 
            this.menuiLaunch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuiLaunchA,
            this.menuiLaunchB,
            this.menuiLaunchC});
            this.menuiLaunch.Name = "menuiLaunch";
            this.menuiLaunch.Size = new System.Drawing.Size(127, 22);
            this.menuiLaunch.Text = "Démarrer";
            // 
            // menuiLaunchA
            // 
            this.menuiLaunchA.Name = "menuiLaunchA";
            this.menuiLaunchA.Size = new System.Drawing.Size(82, 22);
            this.menuiLaunchA.Text = "A";
            this.menuiLaunchA.Click += new System.EventHandler(this.Event_LaunchProduction);
            // 
            // menuiLaunchB
            // 
            this.menuiLaunchB.Name = "menuiLaunchB";
            this.menuiLaunchB.Size = new System.Drawing.Size(82, 22);
            this.menuiLaunchB.Text = "B";
            this.menuiLaunchB.Click += new System.EventHandler(this.Event_LaunchProduction);
            // 
            // menuiLaunchC
            // 
            this.menuiLaunchC.Name = "menuiLaunchC";
            this.menuiLaunchC.Size = new System.Drawing.Size(82, 22);
            this.menuiLaunchC.Text = "C";
            this.menuiLaunchC.Click += new System.EventHandler(this.Event_LaunchProduction);
            // 
            // menuiStop
            // 
            this.menuiStop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuiStopA,
            this.menuiStopB,
            this.menuiStopC});
            this.menuiStop.Name = "menuiStop";
            this.menuiStop.Size = new System.Drawing.Size(127, 22);
            this.menuiStop.Text = "Arrêter";
            this.menuiStop.Click += new System.EventHandler(this.Event_StopProduction);
            // 
            // menuiStopA
            // 
            this.menuiStopA.Name = "menuiStopA";
            this.menuiStopA.Size = new System.Drawing.Size(82, 22);
            this.menuiStopA.Text = "A";
            this.menuiStopA.Click += new System.EventHandler(this.Event_StopProduction);
            // 
            // menuiStopB
            // 
            this.menuiStopB.Name = "menuiStopB";
            this.menuiStopB.Size = new System.Drawing.Size(82, 22);
            this.menuiStopB.Text = "B";
            this.menuiStopB.Click += new System.EventHandler(this.Event_StopProduction);
            // 
            // menuiStopC
            // 
            this.menuiStopC.Name = "menuiStopC";
            this.menuiStopC.Size = new System.Drawing.Size(82, 22);
            this.menuiStopC.Text = "C";
            this.menuiStopC.Click += new System.EventHandler(this.Event_StopProduction);
            // 
            // menuiStart
            // 
            this.menuiStart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuiStartA,
            this.menuiStartB,
            this.menuiStartC});
            this.menuiStart.Name = "menuiStart";
            this.menuiStart.Size = new System.Drawing.Size(127, 22);
            this.menuiStart.Text = "Continuer";
            // 
            // menuiStartA
            // 
            this.menuiStartA.Name = "menuiStartA";
            this.menuiStartA.Size = new System.Drawing.Size(82, 22);
            this.menuiStartA.Text = "A";
            this.menuiStartA.Click += new System.EventHandler(this.Event_StartProduction);
            // 
            // menuiStartB
            // 
            this.menuiStartB.Name = "menuiStartB";
            this.menuiStartB.Size = new System.Drawing.Size(82, 22);
            this.menuiStartB.Text = "B";
            this.menuiStartB.Click += new System.EventHandler(this.Event_StartProduction);
            // 
            // menuiStartC
            // 
            this.menuiStartC.Name = "menuiStartC";
            this.menuiStartC.Size = new System.Drawing.Size(82, 22);
            this.menuiStartC.Text = "C";
            this.menuiStartC.Click += new System.EventHandler(this.Event_StartProduction);
            // 
            // tabcProducersSpec
            // 
            this.tabcProducersSpec.Controls.Add(this.tabpA);
            this.tabcProducersSpec.Controls.Add(this.tabpB);
            this.tabcProducersSpec.Controls.Add(this.tabpC);
            this.tabcProducersSpec.Location = new System.Drawing.Point(35, 59);
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
            this.producerLoadingA.Location = new System.Drawing.Point(12, 226);
            this.producerLoadingA.Manager = null;
            this.producerLoadingA.Name = "producerLoadingA";
            this.producerLoadingA.Size = new System.Drawing.Size(459, 38);
            this.producerLoadingA.TabIndex = 4;
            // 
            // producerLoadingB
            // 
            this.producerLoadingB.Location = new System.Drawing.Point(12, 270);
            this.producerLoadingB.Manager = null;
            this.producerLoadingB.Name = "producerLoadingB";
            this.producerLoadingB.Size = new System.Drawing.Size(459, 40);
            this.producerLoadingB.TabIndex = 5;
            // 
            // producerLoadingC
            // 
            this.producerLoadingC.Location = new System.Drawing.Point(11, 316);
            this.producerLoadingC.Manager = null;
            this.producerLoadingC.Name = "producerLoadingC";
            this.producerLoadingC.Size = new System.Drawing.Size(459, 38);
            this.producerLoadingC.TabIndex = 6;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProdA,
            this.statusProdB,
            this.statusProdC,
            this.statusTime});
            this.statusBar.Location = new System.Drawing.Point(0, 381);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(529, 22);
            this.statusBar.TabIndex = 7;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusProdA
            // 
            this.statusProdA.Name = "statusProdA";
            this.statusProdA.Size = new System.Drawing.Size(71, 17);
            this.statusProdA.Text = "statusProdA";
            // 
            // statusProdB
            // 
            this.statusProdB.Name = "statusProdB";
            this.statusProdB.Size = new System.Drawing.Size(70, 17);
            this.statusProdB.Text = "statusProdB";
            // 
            // statusProdC
            // 
            this.statusProdC.Name = "statusProdC";
            this.statusProdC.Size = new System.Drawing.Size(71, 17);
            this.statusProdC.Text = "statusProdC";
            // 
            // statusTime
            // 
            this.statusTime.Name = "statusTime";
            this.statusTime.Size = new System.Drawing.Size(64, 17);
            this.statusTime.Text = "statusTime";
            this.statusTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bALaunch
            // 
            this.bALaunch.Location = new System.Drawing.Point(12, 27);
            this.bALaunch.Name = "bALaunch";
            this.bALaunch.Size = new System.Drawing.Size(65, 23);
            this.bALaunch.TabIndex = 8;
            this.bALaunch.Text = "A Launch";
            this.bALaunch.UseVisualStyleBackColor = true;
            // 
            // bAStop
            // 
            this.bAStop.Location = new System.Drawing.Point(77, 27);
            this.bAStop.Name = "bAStop";
            this.bAStop.Size = new System.Drawing.Size(51, 23);
            this.bAStop.TabIndex = 9;
            this.bAStop.Text = "A Stop";
            this.bAStop.UseVisualStyleBackColor = true;
            // 
            // bAStart
            // 
            this.bAStart.Location = new System.Drawing.Point(128, 27);
            this.bAStart.Name = "bAStart";
            this.bAStart.Size = new System.Drawing.Size(50, 23);
            this.bAStart.TabIndex = 10;
            this.bAStart.Text = "A Start";
            this.bAStart.UseVisualStyleBackColor = true;
            // 
            // bBStart
            // 
            this.bBStart.Location = new System.Drawing.Point(300, 27);
            this.bBStart.Name = "bBStart";
            this.bBStart.Size = new System.Drawing.Size(50, 23);
            this.bBStart.TabIndex = 13;
            this.bBStart.Text = "B Start";
            this.bBStart.UseVisualStyleBackColor = true;
            // 
            // bBStop
            // 
            this.bBStop.Location = new System.Drawing.Point(249, 27);
            this.bBStop.Name = "bBStop";
            this.bBStop.Size = new System.Drawing.Size(51, 23);
            this.bBStop.TabIndex = 12;
            this.bBStop.Text = "B Stop";
            this.bBStop.UseVisualStyleBackColor = true;
            // 
            // bBLaunch
            // 
            this.bBLaunch.Location = new System.Drawing.Point(184, 27);
            this.bBLaunch.Name = "bBLaunch";
            this.bBLaunch.Size = new System.Drawing.Size(65, 23);
            this.bBLaunch.TabIndex = 11;
            this.bBLaunch.Text = "B Launch";
            this.bBLaunch.UseVisualStyleBackColor = true;
            // 
            // bCStart
            // 
            this.bCStart.Location = new System.Drawing.Point(472, 27);
            this.bCStart.Name = "bCStart";
            this.bCStart.Size = new System.Drawing.Size(50, 23);
            this.bCStart.TabIndex = 16;
            this.bCStart.Text = "C Start";
            this.bCStart.UseVisualStyleBackColor = true;
            // 
            // bCStop
            // 
            this.bCStop.Location = new System.Drawing.Point(421, 27);
            this.bCStop.Name = "bCStop";
            this.bCStop.Size = new System.Drawing.Size(51, 23);
            this.bCStop.TabIndex = 15;
            this.bCStop.Text = "C Stop";
            this.bCStop.UseVisualStyleBackColor = true;
            // 
            // bCLaunch
            // 
            this.bCLaunch.Location = new System.Drawing.Point(356, 27);
            this.bCLaunch.Name = "bCLaunch";
            this.bCLaunch.Size = new System.Drawing.Size(65, 23);
            this.bCLaunch.TabIndex = 14;
            this.bCLaunch.Text = "C Launch";
            this.bCLaunch.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 403);
            this.Controls.Add(this.bCStart);
            this.Controls.Add(this.bCStop);
            this.Controls.Add(this.bCLaunch);
            this.Controls.Add(this.bBStart);
            this.Controls.Add(this.bBStop);
            this.Controls.Add(this.bBLaunch);
            this.Controls.Add(this.bAStart);
            this.Controls.Add(this.bAStop);
            this.Controls.Add(this.bALaunch);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.producerLoadingC);
            this.Controls.Add(this.producerLoadingB);
            this.Controls.Add(this.producerLoadingA);
            this.Controls.Add(this.tabcProducersSpec);
            this.Controls.Add(this.menuApp);
            this.MainMenuStrip = this.menuApp;
            this.Name = "MainForm";
            this.Text = "Production des caisses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuApp.ResumeLayout(false);
            this.menuApp.PerformLayout();
            this.tabcProducersSpec.ResumeLayout(false);
            this.tabpA.ResumeLayout(false);
            this.tabpB.ResumeLayout(false);
            this.tabpC.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuApp;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem productionToolStripMenuItem;
        private ToolStripMenuItem menuiLaunch;
        private ToolStripMenuItem menuiLaunchA;
        private ToolStripMenuItem menuiLaunchB;
        private ToolStripMenuItem menuiLaunchC;
        private ToolStripMenuItem menuiStop;
        private ToolStripMenuItem menuiStopA;
        private ToolStripMenuItem menuiStopB;
        private ToolStripMenuItem menuiStopC;
        private ToolStripMenuItem menuiStart;
        private ToolStripMenuItem menuiStartA;
        private ToolStripMenuItem menuiStartB;
        private ToolStripMenuItem menuiStartC;
        private TabControl tabcProducersSpec;
        private TabPage tabpA;
        private TabPage tabpB;
        private ProducerSpecs producerSpecsA;
        private TabPage tabpC;
        private ProducerLoading producerLoadingA;
        private ProducerLoading producerLoadingB;
        private ProducerLoading producerLoadingC;
        private ToolStripMenuItem menuiQuitApp;
        private ToolStripMenuItem menuiShutdownProduction;
        private ProducerSpecs producerSpecsB;
        private ProducerSpecs producerSpecsC;
        private Label labelPRoduceA;
        private StatusStrip statusBar;
        private ToolStripStatusLabel statusProdA;
        private ToolStripStatusLabel statusProdB;
        private ToolStripStatusLabel statusProdC;
        private ToolStripStatusLabel statusTime;
        private System.Windows.Forms.Timer timerTime;
        private Button bALaunch;
        private Button bAStop;
        private Button bAStart;
        private Button bBStart;
        private Button bBStop;
        private Button bBLaunch;
        private Button bCStart;
        private Button bCStop;
        private Button bCLaunch;
    }
}