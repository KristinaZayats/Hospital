using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace Hospital
{
    partial class idk
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(64, 195);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(642, 420);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(64, 195);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(642, 420);
            this.listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(64, 195);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(641, 420);
            this.listBox3.TabIndex = 3;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(64, 195);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(640, 420);
            this.listBox4.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 658);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "Выбрать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(251, 658);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(310, 55);
            this.button3.TabIndex = 6;
            this.button3.Text = "Выбрать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(251, 658);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(310, 55);
            this.button4.TabIndex = 7;
            this.button4.Text = "Выбрать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(186, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 77);
            this.label1.TabIndex = 8;
            this.label1.Text = "Запись к врачу";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(44, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(691, 420);
            this.label2.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(624, 661);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 51);
            this.button5.TabIndex = 10;
            this.button5.Text = "Да";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(82, 661);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 51);
            this.button6.TabIndex = 11;
            this.button6.Text = "Нет";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // idk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 757);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "idk";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;

        private System.Windows.Forms.ListBox listBox2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}