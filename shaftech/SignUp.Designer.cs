namespace TinaliAutoLight
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tfPasswordConfirm = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tfPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tfPhone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tfUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tfLastName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tfFirstName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.close_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(361, 494);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 17);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginHyperlinkClicked);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Register";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(360, 448);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(126)))), ((int)(((byte)(1)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(238, 42);
            this.bunifuFlatButton1.TabIndex = 25;
            this.bunifuFlatButton1.Text = "Register";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.registerButtonClicked);
            // 
            // tfPasswordConfirm
            // 
            this.tfPasswordConfirm.BorderColorFocused = System.Drawing.Color.Silver;
            this.tfPasswordConfirm.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tfPasswordConfirm.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.tfPasswordConfirm.BorderThickness = 3;
            this.tfPasswordConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tfPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tfPasswordConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tfPasswordConfirm.isPassword = true;
            this.tfPasswordConfirm.Location = new System.Drawing.Point(360, 392);
            this.tfPasswordConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.tfPasswordConfirm.Name = "tfPasswordConfirm";
            this.tfPasswordConfirm.Size = new System.Drawing.Size(238, 29);
            this.tfPasswordConfirm.TabIndex = 19;
            this.tfPasswordConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tfPassword
            // 
            this.tfPassword.BorderColorFocused = System.Drawing.Color.Silver;
            this.tfPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tfPassword.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.tfPassword.BorderThickness = 3;
            this.tfPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tfPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tfPassword.isPassword = true;
            this.tfPassword.Location = new System.Drawing.Point(360, 336);
            this.tfPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tfPassword.Name = "tfPassword";
            this.tfPassword.Size = new System.Drawing.Size(241, 29);
            this.tfPassword.TabIndex = 20;
            this.tfPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tfPhone
            // 
            this.tfPhone.BorderColorFocused = System.Drawing.Color.Silver;
            this.tfPhone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tfPhone.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.tfPhone.BorderThickness = 3;
            this.tfPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tfPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tfPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tfPhone.isPassword = false;
            this.tfPhone.Location = new System.Drawing.Point(360, 280);
            this.tfPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tfPhone.Name = "tfPhone";
            this.tfPhone.Size = new System.Drawing.Size(241, 29);
            this.tfPhone.TabIndex = 21;
            this.tfPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tfUsername
            // 
            this.tfUsername.BorderColorFocused = System.Drawing.Color.Silver;
            this.tfUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tfUsername.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.tfUsername.BorderThickness = 3;
            this.tfUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tfUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tfUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tfUsername.isPassword = false;
            this.tfUsername.Location = new System.Drawing.Point(360, 224);
            this.tfUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tfUsername.Name = "tfUsername";
            this.tfUsername.Size = new System.Drawing.Size(242, 29);
            this.tfUsername.TabIndex = 22;
            this.tfUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tfLastName
            // 
            this.tfLastName.BorderColorFocused = System.Drawing.Color.Silver;
            this.tfLastName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tfLastName.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.tfLastName.BorderThickness = 3;
            this.tfLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tfLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tfLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tfLastName.isPassword = false;
            this.tfLastName.Location = new System.Drawing.Point(360, 168);
            this.tfLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tfLastName.Name = "tfLastName";
            this.tfLastName.Size = new System.Drawing.Size(242, 29);
            this.tfLastName.TabIndex = 23;
            this.tfLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tfFirstName
            // 
            this.tfFirstName.BorderColorFocused = System.Drawing.Color.Silver;
            this.tfFirstName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tfFirstName.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.tfFirstName.BorderThickness = 3;
            this.tfFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tfFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tfFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tfFirstName.isPassword = false;
            this.tfFirstName.Location = new System.Drawing.Point(360, 112);
            this.tfFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tfFirstName.Name = "tfFirstName";
            this.tfFirstName.Size = new System.Drawing.Size(242, 29);
            this.tfFirstName.TabIndex = 24;
            this.tfFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(360, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Retype Password :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(360, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(360, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phone :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(360, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Username :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(360, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Last Name :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(360, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "First Name :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(66)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 546);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 72);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 44);
            this.label2.TabIndex = 15;
            this.label2.Text = "SHAFTECH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.label9.Location = new System.Drawing.Point(419, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 26);
            this.label9.TabIndex = 28;
            this.label9.Text = "Sign Up";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.bunifuFlatButton1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // close_btn
            // 
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(603, -7);
            this.close_btn.Margin = new System.Windows.Forms.Padding(2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(64, 58);
            this.close_btn.TabIndex = 60;
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.closeButtonClicked);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 546);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.tfPasswordConfirm);
            this.Controls.Add(this.tfPassword);
            this.Controls.Add(this.tfPhone);
            this.Controls.Add(this.tfUsername);
            this.Controls.Add(this.tfLastName);
            this.Controls.Add(this.tfFirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tfPasswordConfirm;
        private Bunifu.Framework.UI.BunifuMetroTextbox tfPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox tfPhone;
        private Bunifu.Framework.UI.BunifuMetroTextbox tfUsername;
        private Bunifu.Framework.UI.BunifuMetroTextbox tfLastName;
        private Bunifu.Framework.UI.BunifuMetroTextbox tfFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button close_btn;
    }
}