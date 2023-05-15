using System.ComponentModel;

namespace Hospital
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.RegFullname = new System.Windows.Forms.TextBox();
            this.RegPhoneNumber = new System.Windows.Forms.TextBox();
            this.RegInsuranceNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RegAddress = new System.Windows.Forms.TextBox();
            this.RegEmail = new System.Windows.Forms.TextBox();
            this.RegSex = new System.Windows.Forms.ListBox();
            this.RegSubmit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.RegLogin = new System.Windows.Forms.TextBox();
            this.RegPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegFullname
            // 
            this.RegFullname.Location = new System.Drawing.Point(51, 68);
            this.RegFullname.Name = "RegFullname";
            this.RegFullname.Size = new System.Drawing.Size(399, 22);
            this.RegFullname.TabIndex = 0;
            // 
            // RegPhoneNumber
            // 
            this.RegPhoneNumber.Location = new System.Drawing.Point(51, 295);
            this.RegPhoneNumber.Name = "RegPhoneNumber";
            this.RegPhoneNumber.Size = new System.Drawing.Size(396, 22);
            this.RegPhoneNumber.TabIndex = 1;
            // 
            // RegInsuranceNumber
            // 
            this.RegInsuranceNumber.Location = new System.Drawing.Point(51, 372);
            this.RegInsuranceNumber.Name = "RegInsuranceNumber";
            this.RegInsuranceNumber.Size = new System.Drawing.Size(399, 22);
            this.RegInsuranceNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(641, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Регистрация";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите ФИО:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(35, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 27);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите дату рождения:";
            // 
            // RegBirthdate
            // 
            this.RegBirthdate.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegBirthdate.Location = new System.Drawing.Point(51, 141);
            this.RegBirthdate.Name = "RegBirthdate";
            this.RegBirthdate.Size = new System.Drawing.Size(233, 22);
            this.RegBirthdate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(30, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Введите адрес:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Введите свой номер телефона:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(30, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(382, 33);
            this.label7.TabIndex = 10;
            this.label7.Text = "Введите номер страхового полиса:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(35, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(394, 27);
            this.label8.TabIndex = 11;
            this.label8.Text = "Введите адрес электронной почты:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(35, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "Выберите пол:";
            // 
            // RegAddress
            // 
            this.RegAddress.Location = new System.Drawing.Point(51, 214);
            this.RegAddress.Name = "RegAddress";
            this.RegAddress.Size = new System.Drawing.Size(600, 22);
            this.RegAddress.TabIndex = 13;
            // 
            // RegEmail
            // 
            this.RegEmail.Location = new System.Drawing.Point(51, 453);
            this.RegEmail.Name = "RegEmail";
            this.RegEmail.Size = new System.Drawing.Size(394, 22);
            this.RegEmail.TabIndex = 14;
            // 
            // RegSex
            // 
            this.RegSex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegSex.FormattingEnabled = true;
            this.RegSex.ItemHeight = 23;
            this.RegSex.Items.AddRange(new object[] { "Женский", "Мужской" });
            this.RegSex.Location = new System.Drawing.Point(51, 534);
            this.RegSex.Name = "RegSex";
            this.RegSex.Size = new System.Drawing.Size(219, 50);
            this.RegSex.TabIndex = 15;
            // 
            // RegSubmit
            // 
            this.RegSubmit.BackColor = System.Drawing.SystemColors.Desktop;
            this.RegSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegSubmit.Location = new System.Drawing.Point(338, 593);
            this.RegSubmit.Name = "RegSubmit";
            this.RegSubmit.Size = new System.Drawing.Size(264, 92);
            this.RegSubmit.TabIndex = 16;
            this.RegSubmit.Text = "Зарегистрироваться";
            this.RegSubmit.UseVisualStyleBackColor = false;
            this.RegSubmit.Click += new System.EventHandler(this.RegSubmit_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(558, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Введите логин:";
            // 
            // RegLogin
            // 
            this.RegLogin.Location = new System.Drawing.Point(571, 433);
            this.RegLogin.Name = "RegLogin";
            this.RegLogin.Size = new System.Drawing.Size(278, 22);
            this.RegLogin.TabIndex = 18;
            // 
            // RegPassword
            // 
            this.RegPassword.Location = new System.Drawing.Point(571, 509);
            this.RegPassword.Name = "RegPassword";
            this.RegPassword.Size = new System.Drawing.Size(278, 22);
            this.RegPassword.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(558, 474);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 32);
            this.label11.TabIndex = 20;
            this.label11.Text = "Введите пароль:";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 715);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RegPassword);
            this.Controls.Add(this.RegLogin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RegSubmit);
            this.Controls.Add(this.RegSex);
            this.Controls.Add(this.RegEmail);
            this.Controls.Add(this.RegAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RegBirthdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegInsuranceNumber);
            this.Controls.Add(this.RegPhoneNumber);
            this.Controls.Add(this.RegFullname);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RegLogin;
        private System.Windows.Forms.TextBox RegPassword;
        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Button RegSubmit;

        private System.Windows.Forms.ListBox RegSex;

        private System.Windows.Forms.TextBox RegAddress;
        private System.Windows.Forms.TextBox RegEmail;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker RegBirthdate;

        private System.Windows.Forms.TextBox RegFullname;
        private System.Windows.Forms.TextBox RegPhoneNumber;
        private System.Windows.Forms.TextBox RegInsuranceNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        #endregion
    }
}