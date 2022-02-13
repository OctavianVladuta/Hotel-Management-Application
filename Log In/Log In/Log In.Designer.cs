
namespace Log_In
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginCheck = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.forgetPasswordButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.registerButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.signinButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 168);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Devanagari", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN IN";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.Location = new System.Drawing.Point(134, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 1);
            this.panel3.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(134, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 1);
            this.panel2.TabIndex = 31;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(134, 280);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(299, 32);
            this.textBoxEmail.TabIndex = 30;
            this.textBoxEmail.Text = "Type your email";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Location = new System.Drawing.Point(134, 385);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(299, 32);
            this.textBoxPassword.TabIndex = 29;
            this.textBoxPassword.Text = "Type your password";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Email";
            // 
            // loginCheck
            // 
            this.loginCheck.AutoSize = true;
            this.loginCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginCheck.ForeColor = System.Drawing.Color.Red;
            this.loginCheck.Location = new System.Drawing.Point(150, 478);
            this.loginCheck.Name = "loginCheck";
            this.loginCheck.Size = new System.Drawing.Size(46, 18);
            this.loginCheck.TabIndex = 33;
            this.loginCheck.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 596);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "You don\'t have account? Register now";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(481, 695);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(64, 46);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 34;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Log_In.Properties.Resources.password_bun1;
            this.pictureBox2.Location = new System.Drawing.Point(42, 371);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Log_In.Properties.Resources.user_bun1;
            this.pictureBox1.Location = new System.Drawing.Point(42, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Log_In.Properties.Resources.login;
            this.pictureBox3.Location = new System.Drawing.Point(332, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 123);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // forgetPasswordButton
            // 
            this.forgetPasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.forgetPasswordButton.color = System.Drawing.Color.Transparent;
            this.forgetPasswordButton.colorActive = System.Drawing.Color.Transparent;
            this.forgetPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgetPasswordButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetPasswordButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.forgetPasswordButton.Image = ((System.Drawing.Image)(resources.GetObject("forgetPasswordButton.Image")));
            this.forgetPasswordButton.ImagePosition = 11;
            this.forgetPasswordButton.ImageZoom = 50;
            this.forgetPasswordButton.LabelPosition = 22;
            this.forgetPasswordButton.LabelText = "FORGET PASSWORD";
            this.forgetPasswordButton.Location = new System.Drawing.Point(105, 417);
            this.forgetPasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.forgetPasswordButton.Name = "forgetPasswordButton";
            this.forgetPasswordButton.Size = new System.Drawing.Size(192, 31);
            this.forgetPasswordButton.TabIndex = 7;
            this.forgetPasswordButton.Click += new System.EventHandler(this.forgetPasswordButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.ActiveBorderThickness = 1;
            this.registerButton.ActiveCornerRadius = 20;
            this.registerButton.ActiveFillColor = System.Drawing.Color.LightSalmon;
            this.registerButton.ActiveForecolor = System.Drawing.Color.White;
            this.registerButton.ActiveLineColor = System.Drawing.Color.LightSalmon;
            this.registerButton.BackColor = System.Drawing.SystemColors.Control;
            this.registerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registerButton.BackgroundImage")));
            this.registerButton.ButtonText = "Register";
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.Blue;
            this.registerButton.IdleBorderThickness = 1;
            this.registerButton.IdleCornerRadius = 20;
            this.registerButton.IdleFillColor = System.Drawing.Color.White;
            this.registerButton.IdleForecolor = System.Drawing.Color.Coral;
            this.registerButton.IdleLineColor = System.Drawing.Color.Coral;
            this.registerButton.Location = new System.Drawing.Point(137, 609);
            this.registerButton.Margin = new System.Windows.Forms.Padding(5);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(296, 63);
            this.registerButton.TabIndex = 6;
            this.registerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // signinButton
            // 
            this.signinButton.ActiveBorderThickness = 1;
            this.signinButton.ActiveCornerRadius = 20;
            this.signinButton.ActiveFillColor = System.Drawing.Color.LightSalmon;
            this.signinButton.ActiveForecolor = System.Drawing.Color.White;
            this.signinButton.ActiveLineColor = System.Drawing.Color.LightSalmon;
            this.signinButton.BackColor = System.Drawing.SystemColors.Control;
            this.signinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signinButton.BackgroundImage")));
            this.signinButton.ButtonText = "SIGN IN";
            this.signinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signinButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.signinButton.IdleBorderThickness = 1;
            this.signinButton.IdleCornerRadius = 20;
            this.signinButton.IdleFillColor = System.Drawing.Color.Coral;
            this.signinButton.IdleForecolor = System.Drawing.SystemColors.ButtonFace;
            this.signinButton.IdleLineColor = System.Drawing.Color.Coral;
            this.signinButton.Location = new System.Drawing.Point(137, 515);
            this.signinButton.Margin = new System.Windows.Forms.Padding(5);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(296, 63);
            this.signinButton.TabIndex = 5;
            this.signinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(557, 753);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.loginCheck);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.forgetPasswordButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.signinButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 signinButton;
        private Bunifu.Framework.UI.BunifuThinButton2 registerButton;
        private Bunifu.Framework.UI.BunifuTileButton forgetPasswordButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label loginCheck;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label4;
    }
}

