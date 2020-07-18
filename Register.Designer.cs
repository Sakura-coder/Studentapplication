namespace StudentApplication
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.MyName = new System.Windows.Forms.TextBox();
            this.RegisterImage = new System.Windows.Forms.PictureBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OKPassword = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(152, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "目前我们只提供这些信息";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(152, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(177, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(127, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "手机号码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(127, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "真实姓名";
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.RegisterButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RegisterButton.Location = new System.Drawing.Point(221, 359);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(175, 50);
            this.RegisterButton.TabIndex = 5;
            this.RegisterButton.Text = "确认注册";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.SystemColors.Control;
            this.User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.User.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.User.Location = new System.Drawing.Point(279, 72);
            this.User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User.MaxLength = 6;
            this.User.Name = "User";
            this.User.ShortcutsEnabled = false;
            this.User.Size = new System.Drawing.Size(189, 32);
            this.User.TabIndex = 1;
            this.User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.User_KeyPress);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.Control;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.Password.Location = new System.Drawing.Point(279, 118);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password.MaxLength = 6;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.ShortcutsEnabled = false;
            this.Password.Size = new System.Drawing.Size(189, 32);
            this.Password.TabIndex = 2;
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.SystemColors.Control;
            this.Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Phone.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.Phone.Location = new System.Drawing.Point(279, 211);
            this.Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Phone.MaxLength = 33777;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(189, 32);
            this.Phone.TabIndex = 3;
            // 
            // MyName
            // 
            this.MyName.BackColor = System.Drawing.SystemColors.Control;
            this.MyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MyName.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.MyName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MyName.Location = new System.Drawing.Point(279, 258);
            this.MyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MyName.MaxLength = 33777;
            this.MyName.Name = "MyName";
            this.MyName.Size = new System.Drawing.Size(189, 32);
            this.MyName.TabIndex = 4;
            // 
            // RegisterImage
            // 
            this.RegisterImage.BackColor = System.Drawing.Color.Transparent;
            this.RegisterImage.Image = ((System.Drawing.Image)(resources.GetObject("RegisterImage.Image")));
            this.RegisterImage.Location = new System.Drawing.Point(89, 22);
            this.RegisterImage.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterImage.Name = "RegisterImage";
            this.RegisterImage.Size = new System.Drawing.Size(39, 39);
            this.RegisterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RegisterImage.TabIndex = 6;
            this.RegisterImage.TabStop = false;
            // 
            // image
            // 
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.Location = new System.Drawing.Point(0, 0);
            this.image.Margin = new System.Windows.Forms.Padding(0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(573, 438);
            this.image.TabIndex = 7;
            this.image.TabStop = false;
            this.image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(127, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "确认密码";
            // 
            // OKPassword
            // 
            this.OKPassword.BackColor = System.Drawing.SystemColors.Control;
            this.OKPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OKPassword.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.OKPassword.Location = new System.Drawing.Point(279, 168);
            this.OKPassword.Margin = new System.Windows.Forms.Padding(4);
            this.OKPassword.MaxLength = 6;
            this.OKPassword.Name = "OKPassword";
            this.OKPassword.PasswordChar = '*';
            this.OKPassword.ShortcutsEnabled = false;
            this.OKPassword.Size = new System.Drawing.Size(189, 32);
            this.OKPassword.TabIndex = 9;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(48, 40);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(485, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(40, 38);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 11;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(533, 0);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(40, 38);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 12;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(127, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "电子邮箱";
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.Control;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Email.Font = new System.Drawing.Font("微软雅黑", 14.25F);
            this.Email.Location = new System.Drawing.Point(279, 305);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.MaxLength = 33777;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(189, 32);
            this.Email.TabIndex = 14;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(573, 438);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.OKPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RegisterImage);
            this.Controls.Add(this.MyName);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Register";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.RegisterImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox MyName;
        private System.Windows.Forms.PictureBox RegisterImage;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OKPassword;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox User;
    }
}