namespace StudentApplication
{
    partial class UserLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.image = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.GoLogin = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VerificationBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Register = new System.Windows.Forms.Label();
            this.FoundPwd = new System.Windows.Forms.Label();
            this.Verification = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.Location = new System.Drawing.Point(-1, 0);
            this.image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(543, 206);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(80, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(95, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码:";
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.SystemColors.Control;
            this.User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.User.Location = new System.Drawing.Point(162, 218);
            this.User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User.MaxLength = 6;
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(300, 27);
            this.User.TabIndex = 3;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordBox.Location = new System.Drawing.Point(163, 258);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordBox.MaxLength = 6;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(304, 27);
            this.PasswordBox.TabIndex = 4;
            // 
            // GoLogin
            // 
            this.GoLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.GoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GoLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.GoLogin.Location = new System.Drawing.Point(231, 342);
            this.GoLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoLogin.Name = "GoLogin";
            this.GoLogin.Size = new System.Drawing.Size(75, 32);
            this.GoLogin.TabIndex = 5;
            this.GoLogin.Text = "登录";
            this.GoLogin.UseVisualStyleBackColor = false;
            this.GoLogin.Click += new System.EventHandler(this.GoLogin_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(427, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(48, 36);
            this.Minimize.TabIndex = 7;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(481, 0);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(53, 48);
            this.Exit.TabIndex = 8;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(243, 80);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(55, 60);
            this.Logo.TabIndex = 10;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(172, 27);
            this.title.TabIndex = 11;
            this.title.Text = "学生信息管理系统";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "_____________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "_____________________________________";
            // 
            // VerificationBox
            // 
            this.VerificationBox.BackColor = System.Drawing.SystemColors.Control;
            this.VerificationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VerificationBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VerificationBox.Location = new System.Drawing.Point(162, 304);
            this.VerificationBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VerificationBox.Name = "VerificationBox";
            this.VerificationBox.Size = new System.Drawing.Size(231, 24);
            this.VerificationBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "_____________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 299);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Register.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Register.Location = new System.Drawing.Point(13, 376);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(69, 20);
            this.Register.TabIndex = 17;
            this.Register.Text = "立即注册";
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // FoundPwd
            // 
            this.FoundPwd.AutoSize = true;
            this.FoundPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FoundPwd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FoundPwd.Location = new System.Drawing.Point(454, 376);
            this.FoundPwd.Name = "FoundPwd";
            this.FoundPwd.Size = new System.Drawing.Size(69, 20);
            this.FoundPwd.TabIndex = 18;
            this.FoundPwd.Text = "找回密码";
            this.FoundPwd.Click += new System.EventHandler(this.FoundPwd_Click);
            // 
            // Verification
            // 
            this.Verification.AutoSize = true;
            this.Verification.BackColor = System.Drawing.Color.Lime;
            this.Verification.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Verification.Location = new System.Drawing.Point(394, 299);
            this.Verification.Name = "Verification";
            this.Verification.Size = new System.Drawing.Size(86, 31);
            this.Verification.TabIndex = 19;
            this.Verification.Text = "验证码";
            this.Verification.Click += new System.EventHandler(this.Verification_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(535, 398);
            this.Controls.Add(this.Verification);
            this.Controls.Add(this.FoundPwd);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VerificationBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.GoLogin);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.image);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "欢迎使用";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button GoLogin;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VerificationBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Register;
        private System.Windows.Forms.Label FoundPwd;
        private System.Windows.Forms.Label Verification;
    }
}

