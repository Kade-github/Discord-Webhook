using System.Windows.Forms;

namespace Discord_Webhook
{
    partial class Form1 : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.msg = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(437, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-9, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "                                                ";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.title.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Window;
            this.title.Location = new System.Drawing.Point(1, -3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(439, 39);
            this.title.TabIndex = 4;
            this.title.Text = "Discord Webhook                    ";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(227, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Created by KadePcGames";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(5, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Webhook link";
            // 
            // link
            // 
            this.link.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.link.Location = new System.Drawing.Point(10, 119);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(217, 13);
            this.link.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(5, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 27);
            this.label7.TabIndex = 9;
            this.label7.Text = "Icon link";
            // 
            // icon
            // 
            this.icon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.icon.Location = new System.Drawing.Point(10, 165);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(217, 13);
            this.icon.TabIndex = 10;
            this.icon.TextChanged += new System.EventHandler(this.icon_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(287, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Current Icon";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(234, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 234);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(5, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 27);
            this.label8.TabIndex = 13;
            this.label8.Text = "Message";
            // 
            // msg
            // 
            this.msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msg.Location = new System.Drawing.Point(10, 211);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(217, 83);
            this.msg.TabIndex = 14;
            this.msg.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(10, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 53);
            this.button1.TabIndex = 15;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(5, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 27);
            this.label9.TabIndex = 16;
            this.label9.Text = "Username";
            // 
            // user
            // 
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.Location = new System.Drawing.Point(10, 73);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(217, 13);
            this.user.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(477, 365);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.link);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Discord Webhook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox icon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox msg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox user;
    }
}

