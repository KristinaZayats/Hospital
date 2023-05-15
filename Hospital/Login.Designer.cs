namespace Hospital
{
    partial class Login
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
            this.LogLogin = new System.Windows.Forms.TextBox();
            this.LogPassword = new System.Windows.Forms.TextBox();
            this.LogSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogLogin
            // 
            this.LogLogin.Location = new System.Drawing.Point(225, 298);
            this.LogLogin.Name = "LogLogin";
            this.LogLogin.Size = new System.Drawing.Size(314, 22);
            this.LogLogin.TabIndex = 0;
            // 
            // LogPassword
            // 
            this.LogPassword.Location = new System.Drawing.Point(225, 408);
            this.LogPassword.Name = "LogPassword";
            this.LogPassword.Size = new System.Drawing.Size(314, 22);
            this.LogPassword.TabIndex = 1;
            // 
            // LogSubmit
            // 
            this.LogSubmit.BackColor = System.Drawing.SystemColors.Desktop;
            this.LogSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogSubmit.Location = new System.Drawing.Point(320, 521);
            this.LogSubmit.Name = "LogSubmit";
            this.LogSubmit.Size = new System.Drawing.Size(168, 64);
            this.LogSubmit.TabIndex = 2;
            this.LogSubmit.Text = "Войти";
            this.LogSubmit.UseVisualStyleBackColor = false;
            this.LogSubmit.Click += new System.EventHandler(this.LogSubmit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(225, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 93);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добро пожаловать!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkCyan;
            this.linkLabel1.Location = new System.Drawing.Point(641, 35);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(138, 37);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Регистрация";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(119, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите логин:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(119, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите пароль:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogSubmit);
            this.Controls.Add(this.LogPassword);
            this.Controls.Add(this.LogLogin);
            this.Name = "Login";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button LogSubmit;
        private System.Windows.Forms.TextBox LogPassword;

        private System.Windows.Forms.TextBox LogLogin;

        #endregion
    }
}