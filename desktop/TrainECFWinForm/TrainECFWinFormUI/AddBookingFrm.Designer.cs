namespace TrainECFWinFormUI
{
    partial class AddBookingFrm
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
            this.bAdd = new System.Windows.Forms.Button();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.lBookStart = new System.Windows.Forms.Label();
            this.lBookEnd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.gbCustomer.SuspendLayout();
            this.gbBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(379, 143);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Ajout";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(6, 19);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(49, 15);
            this.lFirstName.TabIndex = 1;
            this.lFirstName.Text = "Prénom";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(6, 47);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(34, 15);
            this.lLastName.TabIndex = 2;
            this.lLastName.Text = "Nom";
            // 
            // lBookStart
            // 
            this.lBookStart.AutoSize = true;
            this.lBookStart.Location = new System.Drawing.Point(6, 19);
            this.lBookStart.Name = "lBookStart";
            this.lBookStart.Size = new System.Drawing.Size(81, 15);
            this.lBookStart.TabIndex = 3;
            this.lBookStart.Text = "Date de début";
            // 
            // lBookEnd
            // 
            this.lBookEnd.AutoSize = true;
            this.lBookEnd.Location = new System.Drawing.Point(6, 47);
            this.lBookEnd.Name = "lBookEnd";
            this.lBookEnd.Size = new System.Drawing.Size(64, 15);
            this.lBookEnd.TabIndex = 4;
            this.lBookEnd.Text = "Date de fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prix";
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.textBox2);
            this.gbCustomer.Controls.Add(this.textBox1);
            this.gbCustomer.Controls.Add(this.lFirstName);
            this.gbCustomer.Controls.Add(this.lLastName);
            this.gbCustomer.Location = new System.Drawing.Point(12, 16);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(200, 105);
            this.gbCustomer.TabIndex = 6;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Client";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 23);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 23);
            this.textBox1.TabIndex = 7;
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.textBox5);
            this.gbBook.Controls.Add(this.textBox3);
            this.gbBook.Controls.Add(this.lBookStart);
            this.gbBook.Controls.Add(this.textBox4);
            this.gbBook.Controls.Add(this.lBookEnd);
            this.gbBook.Controls.Add(this.label4);
            this.gbBook.Location = new System.Drawing.Point(218, 16);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(246, 105);
            this.gbBook.TabIndex = 3;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "Réservation";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(93, 73);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(133, 23);
            this.textBox5.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 23);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(93, 15);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 23);
            this.textBox4.TabIndex = 9;
            // 
            // AddBookingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 178);
            this.Controls.Add(this.gbBook);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.bAdd);
            this.Name = "AddBookingFrm";
            this.Text = "Ajout d\'une réservation";
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bAdd;
        private Label lFirstName;
        private Label lLastName;
        private Label lBookStart;
        private Label lBookEnd;
        private Label label4;
        private GroupBox gbCustomer;
        private GroupBox gbBook;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}