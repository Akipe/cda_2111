namespace _05_ListBox
{
    partial class ListBoxMainForm
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
            this.LElementToAdd = new System.Windows.Forms.Label();
            this.TbElementToAdd = new System.Windows.Forms.TextBox();
            this.TbIndexElement = new System.Windows.Forms.TextBox();
            this.LIndexElement = new System.Windows.Forms.Label();
            this.LbList = new System.Windows.Forms.ListBox();
            this.LShowList = new System.Windows.Forms.Label();
            this.BAddElement = new System.Windows.Forms.Button();
            this.BShowIndex = new System.Windows.Forms.Button();
            this.LProperties = new System.Windows.Forms.Label();
            this.LListCount = new System.Windows.Forms.Label();
            this.ListCount = new System.Windows.Forms.TextBox();
            this.LSelectedIndex = new System.Windows.Forms.Label();
            this.TbSelectedIndex = new System.Windows.Forms.TextBox();
            this.TbSelectedElement = new System.Windows.Forms.TextBox();
            this.LSelectedElement = new System.Windows.Forms.Label();
            this.BEmptyingList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LElementToAdd
            // 
            this.LElementToAdd.AutoSize = true;
            this.LElementToAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LElementToAdd.Location = new System.Drawing.Point(12, 9);
            this.LElementToAdd.Name = "LElementToAdd";
            this.LElementToAdd.Size = new System.Drawing.Size(96, 15);
            this.LElementToAdd.TabIndex = 0;
            this.LElementToAdd.Text = "Nouvel Elément";
            this.LElementToAdd.Click += new System.EventHandler(this.label1_Click);
            // 
            // TbElementToAdd
            // 
            this.TbElementToAdd.Location = new System.Drawing.Point(12, 27);
            this.TbElementToAdd.Name = "TbElementToAdd";
            this.TbElementToAdd.Size = new System.Drawing.Size(134, 23);
            this.TbElementToAdd.TabIndex = 1;
            // 
            // TbIndexElement
            // 
            this.TbIndexElement.Location = new System.Drawing.Point(172, 28);
            this.TbIndexElement.Name = "TbIndexElement";
            this.TbIndexElement.Size = new System.Drawing.Size(38, 23);
            this.TbIndexElement.TabIndex = 4;
            // 
            // LIndexElement
            // 
            this.LIndexElement.AutoSize = true;
            this.LIndexElement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LIndexElement.Location = new System.Drawing.Point(172, 9);
            this.LIndexElement.Name = "LIndexElement";
            this.LIndexElement.Size = new System.Drawing.Size(96, 15);
            this.LIndexElement.TabIndex = 2;
            this.LIndexElement.Text = "Nouvel Elément";
            // 
            // LbList
            // 
            this.LbList.FormattingEnabled = true;
            this.LbList.ItemHeight = 15;
            this.LbList.Location = new System.Drawing.Point(12, 114);
            this.LbList.Name = "LbList";
            this.LbList.Size = new System.Drawing.Size(120, 94);
            this.LbList.TabIndex = 3;
            // 
            // LShowList
            // 
            this.LShowList.AutoSize = true;
            this.LShowList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LShowList.Location = new System.Drawing.Point(12, 96);
            this.LShowList.Name = "LShowList";
            this.LShowList.Size = new System.Drawing.Size(49, 15);
            this.LShowList.TabIndex = 6;
            this.LShowList.Text = "LstListe";
            // 
            // BAddElement
            // 
            this.BAddElement.Location = new System.Drawing.Point(12, 56);
            this.BAddElement.Name = "BAddElement";
            this.BAddElement.Size = new System.Drawing.Size(75, 23);
            this.BAddElement.TabIndex = 2;
            this.BAddElement.Text = "Ajout Liste";
            this.BAddElement.UseVisualStyleBackColor = true;
            // 
            // BShowIndex
            // 
            this.BShowIndex.Location = new System.Drawing.Point(216, 28);
            this.BShowIndex.Name = "BShowIndex";
            this.BShowIndex.Size = new System.Drawing.Size(121, 23);
            this.BShowIndex.TabIndex = 5;
            this.BShowIndex.Text = "Sélectionner";
            this.BShowIndex.UseVisualStyleBackColor = true;
            // 
            // LProperties
            // 
            this.LProperties.AutoSize = true;
            this.LProperties.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LProperties.Location = new System.Drawing.Point(172, 96);
            this.LProperties.Name = "LProperties";
            this.LProperties.Size = new System.Drawing.Size(65, 15);
            this.LProperties.TabIndex = 10;
            this.LProperties.Text = "Propriétés";
            // 
            // LListCount
            // 
            this.LListCount.AutoSize = true;
            this.LListCount.Location = new System.Drawing.Point(172, 117);
            this.LListCount.Name = "LListCount";
            this.LListCount.Size = new System.Drawing.Size(72, 15);
            this.LListCount.TabIndex = 11;
            this.LListCount.Text = "Items.Count";
            // 
            // ListCount
            // 
            this.ListCount.Enabled = false;
            this.ListCount.Location = new System.Drawing.Point(259, 114);
            this.ListCount.Name = "ListCount";
            this.ListCount.Size = new System.Drawing.Size(30, 23);
            this.ListCount.TabIndex = 12;
            // 
            // LSelectedIndex
            // 
            this.LSelectedIndex.AutoSize = true;
            this.LSelectedIndex.Location = new System.Drawing.Point(172, 146);
            this.LSelectedIndex.Name = "LSelectedIndex";
            this.LSelectedIndex.Size = new System.Drawing.Size(80, 15);
            this.LSelectedIndex.TabIndex = 13;
            this.LSelectedIndex.Text = "SelectedIndex";
            this.LSelectedIndex.Click += new System.EventHandler(this.label5_Click);
            // 
            // TbSelectedIndex
            // 
            this.TbSelectedIndex.Enabled = false;
            this.TbSelectedIndex.Location = new System.Drawing.Point(259, 143);
            this.TbSelectedIndex.Name = "TbSelectedIndex";
            this.TbSelectedIndex.Size = new System.Drawing.Size(30, 23);
            this.TbSelectedIndex.TabIndex = 14;
            // 
            // TbSelectedElement
            // 
            this.TbSelectedElement.Enabled = false;
            this.TbSelectedElement.Location = new System.Drawing.Point(259, 172);
            this.TbSelectedElement.Name = "TbSelectedElement";
            this.TbSelectedElement.Size = new System.Drawing.Size(84, 23);
            this.TbSelectedElement.TabIndex = 16;
            // 
            // LSelectedElement
            // 
            this.LSelectedElement.AutoSize = true;
            this.LSelectedElement.Location = new System.Drawing.Point(172, 175);
            this.LSelectedElement.Name = "LSelectedElement";
            this.LSelectedElement.Size = new System.Drawing.Size(28, 15);
            this.LSelectedElement.TabIndex = 15;
            this.LSelectedElement.Text = "Text";
            // 
            // BEmptyingList
            // 
            this.BEmptyingList.Location = new System.Drawing.Point(216, 57);
            this.BEmptyingList.Name = "BEmptyingList";
            this.BEmptyingList.Size = new System.Drawing.Size(121, 23);
            this.BEmptyingList.TabIndex = 6;
            this.BEmptyingList.Text = "Vider la Liste";
            this.BEmptyingList.UseVisualStyleBackColor = true;
            // 
            // ListBoxMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 229);
            this.Controls.Add(this.BEmptyingList);
            this.Controls.Add(this.TbSelectedElement);
            this.Controls.Add(this.LSelectedElement);
            this.Controls.Add(this.TbSelectedIndex);
            this.Controls.Add(this.LSelectedIndex);
            this.Controls.Add(this.ListCount);
            this.Controls.Add(this.LListCount);
            this.Controls.Add(this.LProperties);
            this.Controls.Add(this.BShowIndex);
            this.Controls.Add(this.BAddElement);
            this.Controls.Add(this.LShowList);
            this.Controls.Add(this.LbList);
            this.Controls.Add(this.TbIndexElement);
            this.Controls.Add(this.LIndexElement);
            this.Controls.Add(this.TbElementToAdd);
            this.Controls.Add(this.LElementToAdd);
            this.Name = "ListBoxMainForm";
            this.Text = "Les listes et leurs propriétés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LElementToAdd;
        private TextBox TbElementToAdd;
        private TextBox TbIndexElement;
        private Label LIndexElement;
        private ListBox LbList;
        private Label LShowList;
        private Button BAddElement;
        private Button BShowIndex;
        private Label LProperties;
        private Label LListCount;
        private TextBox ListCount;
        private Label LSelectedIndex;
        private TextBox TbSelectedIndex;
        private TextBox TbSelectedElement;
        private Label LSelectedElement;
        private Button BEmptyingList;
    }
}