
namespace house_managment_system_project_cs
{
    partial class Login_form_Owner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form_Owner));
            this.txtname = new System.Windows.Forms.TextBox();
            this.ShowPasschek = new System.Windows.Forms.CheckBox();
            this.RentXlb = new System.Windows.Forms.Label();
            this.logolb = new System.Windows.Forms.Label();
            this.usernamelb = new System.Windows.Forms.Label();
            this.passlb = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.createbtn = new System.Windows.Forms.Button();
            this.signbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.singinpnl = new System.Windows.Forms.Panel();
            this.labelforgetpassowrd = new System.Windows.Forms.Label();
            this.forgotpass = new System.Windows.Forms.Button();
            this.signinlb = new System.Windows.Forms.Label();
            this.singinpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtname.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(53, 184);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(277, 36);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ShowPasschek
            // 
            this.ShowPasschek.AutoSize = true;
            this.ShowPasschek.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ShowPasschek.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25455F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPasschek.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ShowPasschek.Location = new System.Drawing.Point(304, 275);
            this.ShowPasschek.Name = "ShowPasschek";
            this.ShowPasschek.Size = new System.Drawing.Size(15, 14);
            this.ShowPasschek.TabIndex = 22;
            this.ShowPasschek.UseVisualStyleBackColor = false;
            this.ShowPasschek.CheckedChanged += new System.EventHandler(this.ShowHide_CheckedChanged);
            // 
            // RentXlb
            // 
            this.RentXlb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RentXlb.BackColor = System.Drawing.Color.Transparent;
            this.RentXlb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentXlb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RentXlb.Location = new System.Drawing.Point(10, 60);
            this.RentXlb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RentXlb.Name = "RentXlb";
            this.RentXlb.Size = new System.Drawing.Size(50, 24);
            this.RentXlb.TabIndex = 20;
            this.RentXlb.Text = "RentX";
            // 
            // logolb
            // 
            this.logolb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logolb.BackColor = System.Drawing.Color.Transparent;
            this.logolb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logolb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logolb.Image = global::house_managment_system_project_cs.Properties.Resources.Contact_Support1;
            this.logolb.Location = new System.Drawing.Point(10, 17);
            this.logolb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logolb.Name = "logolb";
            this.logolb.Size = new System.Drawing.Size(40, 43);
            this.logolb.TabIndex = 19;
            // 
            // usernamelb
            // 
            this.usernamelb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernamelb.AutoSize = true;
            this.usernamelb.BackColor = System.Drawing.Color.Transparent;
            this.usernamelb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelb.Location = new System.Drawing.Point(55, 154);
            this.usernamelb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernamelb.Name = "usernamelb";
            this.usernamelb.Size = new System.Drawing.Size(103, 27);
            this.usernamelb.TabIndex = 17;
            this.usernamelb.Text = "UserName";
            // 
            // passlb
            // 
            this.passlb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passlb.AutoSize = true;
            this.passlb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlb.Location = new System.Drawing.Point(55, 235);
            this.passlb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passlb.Name = "passlb";
            this.passlb.Size = new System.Drawing.Size(96, 27);
            this.passlb.TabIndex = 16;
            this.passlb.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpassword.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtpassword.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(53, 262);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(277, 32);
            this.txtpassword.TabIndex = 0;
            // 
            // createbtn
            // 
            this.createbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createbtn.BackColor = System.Drawing.Color.Transparent;
            this.createbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.createbtn.FlatAppearance.BorderSize = 2;
            this.createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createbtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createbtn.Location = new System.Drawing.Point(129, 432);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(110, 37);
            this.createbtn.TabIndex = 15;
            this.createbtn.Text = "Create Account";
            this.createbtn.UseVisualStyleBackColor = false;
            this.createbtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // signbtn
            // 
            this.signbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signbtn.BackColor = System.Drawing.Color.Transparent;
            this.signbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.signbtn.FlatAppearance.BorderSize = 2;
            this.signbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signbtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signbtn.Location = new System.Drawing.Point(98, 380);
            this.signbtn.Name = "signbtn";
            this.signbtn.Size = new System.Drawing.Size(170, 37);
            this.signbtn.TabIndex = 13;
            this.signbtn.Text = "Sign in";
            this.signbtn.UseVisualStyleBackColor = false;
            this.signbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // backbtn
            // 
            this.backbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(27, 267);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(79, 96);
            this.backbtn.TabIndex = 22;
            this.backbtn.Text = "↩️";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // singinpnl
            // 
            this.singinpnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.singinpnl.BackColor = System.Drawing.SystemColors.Control;
            this.singinpnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.singinpnl.Controls.Add(this.labelforgetpassowrd);
            this.singinpnl.Controls.Add(this.forgotpass);
            this.singinpnl.Controls.Add(this.signinlb);
            this.singinpnl.Controls.Add(this.ShowPasschek);
            this.singinpnl.Controls.Add(this.createbtn);
            this.singinpnl.Controls.Add(this.txtpassword);
            this.singinpnl.Controls.Add(this.passlb);
            this.singinpnl.Controls.Add(this.signbtn);
            this.singinpnl.Controls.Add(this.txtname);
            this.singinpnl.Controls.Add(this.usernamelb);
            this.singinpnl.Location = new System.Drawing.Point(333, 45);
            this.singinpnl.Name = "singinpnl";
            this.singinpnl.Size = new System.Drawing.Size(366, 506);
            this.singinpnl.TabIndex = 24;
            // 
            // labelforgetpassowrd
            // 
            this.labelforgetpassowrd.AutoSize = true;
            this.labelforgetpassowrd.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.78182F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelforgetpassowrd.Location = new System.Drawing.Point(49, 335);
            this.labelforgetpassowrd.Name = "labelforgetpassowrd";
            this.labelforgetpassowrd.Size = new System.Drawing.Size(174, 22);
            this.labelforgetpassowrd.TabIndex = 41;
            this.labelforgetpassowrd.Text = "If you forgot password";
            // 
            // forgotpass
            // 
            this.forgotpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forgotpass.BackColor = System.Drawing.Color.Transparent;
            this.forgotpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forgotpass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.forgotpass.FlatAppearance.BorderSize = 0;
            this.forgotpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotpass.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpass.ForeColor = System.Drawing.Color.Blue;
            this.forgotpass.Location = new System.Drawing.Point(229, 331);
            this.forgotpass.Name = "forgotpass";
            this.forgotpass.Size = new System.Drawing.Size(116, 26);
            this.forgotpass.TabIndex = 39;
            this.forgotpass.Text = "Forgot Password ?";
            this.forgotpass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.forgotpass.UseVisualStyleBackColor = false;
            this.forgotpass.Click += new System.EventHandler(this.forgotpass_Click);
            // 
            // signinlb
            // 
            this.signinlb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signinlb.AutoSize = true;
            this.signinlb.BackColor = System.Drawing.Color.Transparent;
            this.signinlb.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinlb.Location = new System.Drawing.Point(73, 63);
            this.signinlb.Name = "signinlb";
            this.signinlb.Size = new System.Drawing.Size(217, 44);
            this.signinlb.TabIndex = 32;
            this.signinlb.Text = " Sign in RentX";
            // 
            // Login_form_Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::house_managment_system_project_cs.Properties.Resources._222;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 590);
            this.Controls.Add(this.singinpnl);
            this.Controls.Add(this.RentXlb);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.logolb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_form_Owner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_form_Owner_FormClosing);
            this.Load += new System.EventHandler(this.Login_form_Load);
            this.singinpnl.ResumeLayout(false);
            this.singinpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button signbtn;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label usernamelb;
        private System.Windows.Forms.Label passlb;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label RentXlb;
        private System.Windows.Forms.Label logolb;
        private System.Windows.Forms.CheckBox ShowPasschek;
        private System.Windows.Forms.Panel singinpnl;
        private System.Windows.Forms.Label signinlb;
        private System.Windows.Forms.Button forgotpass;
        private System.Windows.Forms.Label labelforgetpassowrd;
    }
}