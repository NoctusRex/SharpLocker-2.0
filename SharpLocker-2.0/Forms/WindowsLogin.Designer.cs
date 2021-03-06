﻿namespace Windows10LokkIn
{
    partial class WindowsLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsLogin));
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.CapsLockLabel = new System.Windows.Forms.Label();
            this.ConnectionButton = new System.Windows.Forms.Button();
            this.EaseOfAccessButton = new System.Windows.Forms.Button();
            this.PowerButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ShowPasswordButton = new System.Windows.Forms.Button();
            this.WrongPasswordLabel = new System.Windows.Forms.Label();
            this.WrongPasswordButton = new System.Windows.Forms.Button();
            this.LanguageButton = new Windows10LokkIn.Controls.PaddinglessButton();
            this.PasswordTextBox = new Windows10LokkIn.Controls.NoBaloonTipTextbox();
            this.UserIconPictureBox = new Windows10LokkIn.Controls.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 33F);
            this.UserNameLabel.ForeColor = System.Drawing.Color.White;
            this.UserNameLabel.Location = new System.Drawing.Point(195, 265);
            this.UserNameLabel.MinimumSize = new System.Drawing.Size(403, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(403, 60);
            this.UserNameLabel.TabIndex = 5;
            this.UserNameLabel.Text = "UserName";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CapsLockLabel
            // 
            this.CapsLockLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CapsLockLabel.AutoSize = true;
            this.CapsLockLabel.BackColor = System.Drawing.Color.Transparent;
            this.CapsLockLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapsLockLabel.ForeColor = System.Drawing.Color.White;
            this.CapsLockLabel.Location = new System.Drawing.Point(250, 380);
            this.CapsLockLabel.MinimumSize = new System.Drawing.Size(300, 0);
            this.CapsLockLabel.Name = "CapsLockLabel";
            this.CapsLockLabel.Size = new System.Drawing.Size(300, 20);
            this.CapsLockLabel.TabIndex = 9;
            this.CapsLockLabel.Text = "Caps Lock is on";
            this.CapsLockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionButton.AutoSize = true;
            this.ConnectionButton.BackColor = System.Drawing.Color.Transparent;
            this.ConnectionButton.BackgroundImage = global::Windows10LokkIn.Properties.Resources.ethernet;
            this.ConnectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConnectionButton.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.ConnectionButton.FlatAppearance.BorderSize = 0;
            this.ConnectionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectionButton.Location = new System.Drawing.Point(630, 380);
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(40, 40);
            this.ConnectionButton.TabIndex = 16;
            this.ConnectionButton.TabStop = false;
            this.ConnectionButton.UseVisualStyleBackColor = false;
            // 
            // EaseOfAccessButton
            // 
            this.EaseOfAccessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EaseOfAccessButton.AutoSize = true;
            this.EaseOfAccessButton.BackColor = System.Drawing.Color.Transparent;
            this.EaseOfAccessButton.BackgroundImage = global::Windows10LokkIn.Properties.Resources.easeOfAccess;
            this.EaseOfAccessButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EaseOfAccessButton.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.EaseOfAccessButton.FlatAppearance.BorderSize = 0;
            this.EaseOfAccessButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.EaseOfAccessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EaseOfAccessButton.Location = new System.Drawing.Point(680, 380);
            this.EaseOfAccessButton.Name = "EaseOfAccessButton";
            this.EaseOfAccessButton.Size = new System.Drawing.Size(40, 40);
            this.EaseOfAccessButton.TabIndex = 15;
            this.EaseOfAccessButton.TabStop = false;
            this.EaseOfAccessButton.UseVisualStyleBackColor = false;
            // 
            // PowerButton
            // 
            this.PowerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PowerButton.AutoSize = true;
            this.PowerButton.BackColor = System.Drawing.Color.Transparent;
            this.PowerButton.BackgroundImage = global::Windows10LokkIn.Properties.Resources.power;
            this.PowerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PowerButton.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.PowerButton.FlatAppearance.BorderSize = 0;
            this.PowerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.PowerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerButton.Location = new System.Drawing.Point(730, 380);
            this.PowerButton.Name = "PowerButton";
            this.PowerButton.Size = new System.Drawing.Size(40, 40);
            this.PowerButton.TabIndex = 14;
            this.PowerButton.TabStop = false;
            this.PowerButton.UseVisualStyleBackColor = false;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.AutoSize = true;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BackgroundImage = global::Windows10LokkIn.Properties.Resources.login;
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Location = new System.Drawing.Point(505, 342);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(29, 29);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.TabStop = false;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            this.LoginButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // ShowPasswordButton
            // 
            this.ShowPasswordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowPasswordButton.AutoSize = true;
            this.ShowPasswordButton.BackColor = System.Drawing.SystemColors.Window;
            this.ShowPasswordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowPasswordButton.BackgroundImage")));
            this.ShowPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowPasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ShowPasswordButton.FlatAppearance.BorderSize = 0;
            this.ShowPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPasswordButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ShowPasswordButton.Location = new System.Drawing.Point(476, 343);
            this.ShowPasswordButton.Margin = new System.Windows.Forms.Padding(0);
            this.ShowPasswordButton.Name = "ShowPasswordButton";
            this.ShowPasswordButton.Size = new System.Drawing.Size(29, 27);
            this.ShowPasswordButton.TabIndex = 17;
            this.ShowPasswordButton.TabStop = false;
            this.ShowPasswordButton.UseVisualStyleBackColor = false;
            this.ShowPasswordButton.Click += new System.EventHandler(this.ShowPasswordButton_Click);
            // 
            // WrongPasswordLabel
            // 
            this.WrongPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WrongPasswordLabel.AutoSize = true;
            this.WrongPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.WrongPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.WrongPasswordLabel.Location = new System.Drawing.Point(-61, 337);
            this.WrongPasswordLabel.Name = "WrongPasswordLabel";
            this.WrongPasswordLabel.Size = new System.Drawing.Size(962, 40);
            this.WrongPasswordLabel.TabIndex = 18;
            this.WrongPasswordLabel.Text = resources.GetString("WrongPasswordLabel.Text");
            // 
            // WrongPasswordButton
            // 
            this.WrongPasswordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WrongPasswordButton.AutoSize = true;
            this.WrongPasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.WrongPasswordButton.BackgroundImage = global::Windows10LokkIn.Properties.Resources.defaultButtonBackground;
            this.WrongPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WrongPasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.WrongPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WrongPasswordButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongPasswordButton.ForeColor = System.Drawing.Color.White;
            this.WrongPasswordButton.Location = new System.Drawing.Point(347, 385);
            this.WrongPasswordButton.Name = "WrongPasswordButton";
            this.WrongPasswordButton.Size = new System.Drawing.Size(110, 32);
            this.WrongPasswordButton.TabIndex = 19;
            this.WrongPasswordButton.TabStop = false;
            this.WrongPasswordButton.Text = "OK";
            this.WrongPasswordButton.UseVisualStyleBackColor = false;
            this.WrongPasswordButton.Click += new System.EventHandler(this.WrongPasswordButton_Click);
            // 
            // LanguageButton
            // 
            this.LanguageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguageButton.BackColor = System.Drawing.Color.Transparent;
            this.LanguageButton.FlatAppearance.BorderSize = 0;
            this.LanguageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LanguageButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageButton.ForeColor = System.Drawing.Color.White;
            this.LanguageButton.Location = new System.Drawing.Point(580, 380);
            this.LanguageButton.MaximumSize = new System.Drawing.Size(40, 40);
            this.LanguageButton.Name = "LanguageButton";
            this.LanguageButton.Size = new System.Drawing.Size(40, 40);
            this.LanguageButton.TabIndex = 21;
            this.LanguageButton.Text = "ENG";
            this.LanguageButton.UseVisualStyleBackColor = false;
            this.LanguageButton.Click += new System.EventHandler(this.LanguageButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe Condensed", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordTextBox.Location = new System.Drawing.Point(254, 343);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.ShortcutsEnabled = false;
            this.PasswordTextBox.Size = new System.Drawing.Size(222, 27);
            this.PasswordTextBox.TabIndex = 0;
            this.PasswordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // UserIconPictureBox
            // 
            this.UserIconPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserIconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.UserIconPictureBox.Location = new System.Drawing.Point(300, 52);
            this.UserIconPictureBox.Name = "UserIconPictureBox";
            this.UserIconPictureBox.Size = new System.Drawing.Size(199, 199);
            this.UserIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserIconPictureBox.TabIndex = 13;
            this.UserIconPictureBox.TabStop = false;
            // 
            // WindowsLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LanguageButton);
            this.Controls.Add(this.WrongPasswordButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.ShowPasswordButton);
            this.Controls.Add(this.ConnectionButton);
            this.Controls.Add(this.EaseOfAccessButton);
            this.Controls.Add(this.PowerButton);
            this.Controls.Add(this.UserIconPictureBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.CapsLockLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.WrongPasswordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowsLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Login";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowsLogin_FormClosing);
            this.Load += new System.EventHandler(this.WindowsLogin_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WindowsLogin_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.UserIconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label CapsLockLabel;
        private System.Windows.Forms.Button LoginButton;
        private Controls.RoundPictureBox UserIconPictureBox;
        private System.Windows.Forms.Button ConnectionButton;
        private System.Windows.Forms.Button EaseOfAccessButton;
        private System.Windows.Forms.Button PowerButton;
        private System.Windows.Forms.Button ShowPasswordButton;
        private Controls.NoBaloonTipTextbox PasswordTextBox;
        private System.Windows.Forms.Label WrongPasswordLabel;
        private System.Windows.Forms.Button WrongPasswordButton;
        private Controls.PaddinglessButton LanguageButton;
    }
}

