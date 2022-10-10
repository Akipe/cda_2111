namespace ValidationTraining.UI
{
    partial class FormExample
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
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lFirstname = new System.Windows.Forms.Label();
            this.tbFistName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbPhoneHome = new System.Windows.Forms.MaskedTextBox();
            this.mtbPhoneOutside = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDateToOneYear = new System.Windows.Forms.DateTimePicker();
            this.mtbBirthDay = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(126, 6);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(192, 23);
            this.tbLastName.TabIndex = 0;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 9);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(34, 15);
            this.lName.TabIndex = 1;
            this.lName.Text = "Nom";
            // 
            // lFirstname
            // 
            this.lFirstname.AutoSize = true;
            this.lFirstname.Location = new System.Drawing.Point(12, 38);
            this.lFirstname.Name = "lFirstname";
            this.lFirstname.Size = new System.Drawing.Size(49, 15);
            this.lFirstname.TabIndex = 3;
            this.lFirstname.Text = "Prenom";
            // 
            // tbFistName
            // 
            this.tbFistName.Location = new System.Drawing.Point(126, 35);
            this.tbFistName.Name = "tbFistName";
            this.tbFistName.Size = new System.Drawing.Size(192, 23);
            this.tbFistName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date naissance";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(126, 93);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(192, 23);
            this.tbStreet.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Téléphone fix";
            // 
            // mtbPhoneHome
            // 
            this.mtbPhoneHome.Location = new System.Drawing.Point(126, 122);
            this.mtbPhoneHome.Name = "mtbPhoneHome";
            this.mtbPhoneHome.Size = new System.Drawing.Size(192, 23);
            this.mtbPhoneHome.TabIndex = 10;
            // 
            // mtbPhoneOutside
            // 
            this.mtbPhoneOutside.Location = new System.Drawing.Point(126, 151);
            this.mtbPhoneOutside.Name = "mtbPhoneOutside";
            this.mtbPhoneOutside.Size = new System.Drawing.Size(192, 23);
            this.mtbPhoneOutside.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Téléphone portable";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 48);
            this.label5.TabIndex = 14;
            this.label5.Text = "Une date entre maintenant dans 1 ans";
            // 
            // dtDateToOneYear
            // 
            this.dtDateToOneYear.Location = new System.Drawing.Point(126, 180);
            this.dtDateToOneYear.Name = "dtDateToOneYear";
            this.dtDateToOneYear.Size = new System.Drawing.Size(200, 23);
            this.dtDateToOneYear.TabIndex = 13;
            // 
            // mtbBirthDay
            // 
            this.mtbBirthDay.Location = new System.Drawing.Point(126, 64);
            this.mtbBirthDay.Name = "mtbBirthDay";
            this.mtbBirthDay.Size = new System.Drawing.Size(192, 23);
            this.mtbBirthDay.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 248);
            this.Controls.Add(this.mtbBirthDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtDateToOneYear);
            this.Controls.Add(this.mtbPhoneOutside);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtbPhoneHome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lFirstname);
            this.Controls.Add(this.tbFistName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tbLastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbLastName;
        private Label lName;
        private Label lFirstname;
        private TextBox tbFistName;
        private Label label1;
        private TextBox tbStreet;
        private Label label2;
        private Label label3;
        private MaskedTextBox mtbPhoneHome;
        private MaskedTextBox mtbPhoneOutside;
        private Label label4;
        private Label label5;
        private DateTimePicker dtDateToOneYear;
        private MaskedTextBox mtbBirthDay;
    }
}