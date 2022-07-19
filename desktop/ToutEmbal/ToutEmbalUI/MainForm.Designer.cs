using ToutEmbalCore;

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
        /// 
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
            this.producerSpecsA = new ToutEmbalUI.ManagerSpecs();
            this.tabpB = new System.Windows.Forms.TabPage();
            this.producerSpecsB = new ToutEmbalUI.ManagerSpecs();
            this.tabpC = new System.Windows.Forms.TabPage();
            this.producerSpecsC = new ToutEmbalUI.ManagerSpecs();
            this.producerLoadingA = new ToutEmbalUI.ManagerLoading();
            this.producerLoadingB = new ToutEmbalUI.ManagerLoading();
            this.producerLoadingC = new ToutEmbalUI.ManagerLoading();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusProdA = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProdB = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProdC = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.bLaunchA = new System.Windows.Forms.Button();
            this.bStopA = new System.Windows.Forms.Button();
            this.bStartA = new System.Windows.Forms.Button();
            this.bStartB = new System.Windows.Forms.Button();
            this.bStopB = new System.Windows.Forms.Button();
            this.bLaunchB = new System.Windows.Forms.Button();
            this.bStartC = new System.Windows.Forms.Button();
            this.bStopC = new System.Windows.Forms.Button();
            this.bLaunchC = new System.Windows.Forms.Button();
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
            this.menuiLaunch.Size = new System.Drawing.Size(180, 22);
            this.menuiLaunch.Text = "Initialiser";
            // 
            // menuiLaunchA
            // 
            this.menuiLaunchA.Name = "menuiLaunchA";
            this.menuiLaunchA.Size = new System.Drawing.Size(82, 22);
            this.menuiLaunchA.Text = "A";
            // 
            // menuiLaunchB
            // 
            this.menuiLaunchB.Name = "menuiLaunchB";
            this.menuiLaunchB.Size = new System.Drawing.Size(82, 22);
            this.menuiLaunchB.Text = "B";
            // 
            // menuiLaunchC
            // 
            this.menuiLaunchC.Name = "menuiLaunchC";
            this.menuiLaunchC.Size = new System.Drawing.Size(82, 22);
            this.menuiLaunchC.Text = "C";
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
            // 
            // menuiStopA
            // 
            this.menuiStopA.Name = "menuiStopA";
            this.menuiStopA.Size = new System.Drawing.Size(82, 22);
            this.menuiStopA.Text = "A";
            // 
            // menuiStopB
            // 
            this.menuiStopB.Name = "menuiStopB";
            this.menuiStopB.Size = new System.Drawing.Size(82, 22);
            this.menuiStopB.Text = "B";
            // 
            // menuiStopC
            // 
            this.menuiStopC.Name = "menuiStopC";
            this.menuiStopC.Size = new System.Drawing.Size(82, 22);
            this.menuiStopC.Text = "C";
            // 
            // menuiStart
            // 
            this.menuiStart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuiStartA,
            this.menuiStartB,
            this.menuiStartC});
            this.menuiStart.Name = "menuiStart";
            this.menuiStart.Size = new System.Drawing.Size(180, 22);
            this.menuiStart.Text = "Reprendre";
            // 
            // menuiStartA
            // 
            this.menuiStartA.Name = "menuiStartA";
            this.menuiStartA.Size = new System.Drawing.Size(82, 22);
            this.menuiStartA.Text = "A";
            // 
            // menuiStartB
            // 
            this.menuiStartB.Name = "menuiStartB";
            this.menuiStartB.Size = new System.Drawing.Size(82, 22);
            this.menuiStartB.Text = "B";
            // 
            // menuiStartC
            // 
            this.menuiStartC.Name = "menuiStartC";
            this.menuiStartC.Size = new System.Drawing.Size(82, 22);
            this.menuiStartC.Text = "C";
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
            this.toolStripStatusLabel1,
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
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(150, 17);
            // 
            // statusTime
            // 
            this.statusTime.Name = "statusTime";
            this.statusTime.Size = new System.Drawing.Size(64, 17);
            this.statusTime.Text = "statusTime";
            this.statusTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bLaunchA
            // 
            this.bLaunchA.Location = new System.Drawing.Point(12, 27);
            this.bLaunchA.Name = "bLaunchA";
            this.bLaunchA.Size = new System.Drawing.Size(65, 23);
            this.bLaunchA.TabIndex = 8;
            this.bLaunchA.Text = "A Init";
            this.bLaunchA.UseVisualStyleBackColor = true;
            // 
            // bStopA
            // 
            this.bStopA.Location = new System.Drawing.Point(77, 27);
            this.bStopA.Name = "bStopA";
            this.bStopA.Size = new System.Drawing.Size(51, 23);
            this.bStopA.TabIndex = 9;
            this.bStopA.Text = "A Stop";
            this.bStopA.UseVisualStyleBackColor = true;
            // 
            // bStartA
            // 
            this.bStartA.Location = new System.Drawing.Point(128, 27);
            this.bStartA.Name = "bStartA";
            this.bStartA.Size = new System.Drawing.Size(50, 23);
            this.bStartA.TabIndex = 10;
            this.bStartA.Text = "A ReS";
            this.bStartA.UseVisualStyleBackColor = true;
            // 
            // bStartB
            // 
            this.bStartB.Location = new System.Drawing.Point(300, 27);
            this.bStartB.Name = "bStartB";
            this.bStartB.Size = new System.Drawing.Size(50, 23);
            this.bStartB.TabIndex = 13;
            this.bStartB.Text = "B ReS";
            this.bStartB.UseVisualStyleBackColor = true;
            // 
            // bStopB
            // 
            this.bStopB.Location = new System.Drawing.Point(249, 27);
            this.bStopB.Name = "bStopB";
            this.bStopB.Size = new System.Drawing.Size(51, 23);
            this.bStopB.TabIndex = 12;
            this.bStopB.Text = "B Stop";
            this.bStopB.UseVisualStyleBackColor = true;
            // 
            // bLaunchB
            // 
            this.bLaunchB.Location = new System.Drawing.Point(184, 27);
            this.bLaunchB.Name = "bLaunchB";
            this.bLaunchB.Size = new System.Drawing.Size(65, 23);
            this.bLaunchB.TabIndex = 11;
            this.bLaunchB.Text = "B Init";
            this.bLaunchB.UseVisualStyleBackColor = true;
            // 
            // bStartC
            // 
            this.bStartC.Location = new System.Drawing.Point(472, 27);
            this.bStartC.Name = "bStartC";
            this.bStartC.Size = new System.Drawing.Size(50, 23);
            this.bStartC.TabIndex = 16;
            this.bStartC.Text = "C ReS";
            this.bStartC.UseVisualStyleBackColor = true;
            // 
            // bStopC
            // 
            this.bStopC.Location = new System.Drawing.Point(421, 27);
            this.bStopC.Name = "bStopC";
            this.bStopC.Size = new System.Drawing.Size(51, 23);
            this.bStopC.TabIndex = 15;
            this.bStopC.Text = "C Stop";
            this.bStopC.UseVisualStyleBackColor = true;
            // 
            // bLaunchC
            // 
            this.bLaunchC.Location = new System.Drawing.Point(356, 27);
            this.bLaunchC.Name = "bLaunchC";
            this.bLaunchC.Size = new System.Drawing.Size(65, 23);
            this.bLaunchC.TabIndex = 14;
            this.bLaunchC.Text = "C Init";
            this.bLaunchC.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 403);
            this.Controls.Add(this.bStartC);
            this.Controls.Add(this.bStopC);
            this.Controls.Add(this.bLaunchC);
            this.Controls.Add(this.bStartB);
            this.Controls.Add(this.bStopB);
            this.Controls.Add(this.bLaunchB);
            this.Controls.Add(this.bStartA);
            this.Controls.Add(this.bStopA);
            this.Controls.Add(this.bLaunchA);
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
        private ManagerSpecs producerSpecsA;
        private TabPage tabpC;
        private ManagerLoading producerLoadingA;
        private ManagerLoading producerLoadingB;
        private ManagerLoading producerLoadingC;
        private ToolStripMenuItem menuiQuitApp;
        private ToolStripMenuItem menuiShutdownProduction;
        private ManagerSpecs producerSpecsB;
        private ManagerSpecs producerSpecsC;
        private StatusStrip statusBar;
        private ToolStripStatusLabel statusProdA;
        private ToolStripStatusLabel statusProdB;
        private ToolStripStatusLabel statusProdC;
        private ToolStripStatusLabel statusTime;
        private System.Windows.Forms.Timer timerTime;
        private Button bLaunchA;
        private Button bStopA;
        private Button bStartA;
        private Button bStartB;
        private Button bStopB;
        private Button bLaunchB;
        private Button bStartC;
        private Button bStopC;
        private Button bLaunchC;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}