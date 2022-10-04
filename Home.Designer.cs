
namespace house_managment_system_project_cs
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.welcome = new System.Windows.Forms.Label();
            this.RentX = new System.Windows.Forms.Label();
            this.Ownerbtn = new System.Windows.Forms.Button();
            this.Customerbtn = new System.Windows.Forms.Button();
            this.Or = new System.Windows.Forms.Label();
            this.youare = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcome
            // 
            resources.ApplyResources(this.welcome, "welcome");
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.ForeColor = System.Drawing.Color.Transparent;
            this.welcome.Name = "welcome";
            this.welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // RentX
            // 
            resources.ApplyResources(this.RentX, "RentX");
            this.RentX.BackColor = System.Drawing.Color.Transparent;
            this.RentX.ForeColor = System.Drawing.Color.Transparent;
            this.RentX.Name = "RentX";
            // 
            // Ownerbtn
            // 
            resources.ApplyResources(this.Ownerbtn, "Ownerbtn");
            this.Ownerbtn.BackColor = System.Drawing.Color.Transparent;
            this.Ownerbtn.Name = "Ownerbtn";
            this.Ownerbtn.UseVisualStyleBackColor = false;
            this.Ownerbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Customerbtn
            // 
            resources.ApplyResources(this.Customerbtn, "Customerbtn");
            this.Customerbtn.BackColor = System.Drawing.Color.Transparent;
            this.Customerbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Customerbtn.FlatAppearance.BorderSize = 8;
            this.Customerbtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Customerbtn.Name = "Customerbtn";
            this.Customerbtn.UseVisualStyleBackColor = false;
            this.Customerbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Or
            // 
            resources.ApplyResources(this.Or, "Or");
            this.Or.BackColor = System.Drawing.Color.Transparent;
            this.Or.ForeColor = System.Drawing.Color.Transparent;
            this.Or.Name = "Or";
            // 
            // youare
            // 
            resources.ApplyResources(this.youare, "youare");
            this.youare.BackColor = System.Drawing.Color.Transparent;
            this.youare.ForeColor = System.Drawing.Color.Transparent;
            this.youare.Name = "youare";
            // 
            // Logo
            // 
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.ForeColor = System.Drawing.Color.Transparent;
            this.Logo.Image = global::house_managment_system_project_cs.Properties.Resources.Contact_Support1;
            this.Logo.Name = "Logo";
            this.Logo.Click += new System.EventHandler(this.label6_Click);
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::house_managment_system_project_cs.Properties.Resources._222;
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.youare);
            this.Controls.Add(this.Or);
            this.Controls.Add(this.Customerbtn);
            this.Controls.Add(this.Ownerbtn);
            this.Controls.Add(this.RentX);
            this.Controls.Add(this.welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Name = "Home";
            this.MaximumSizeChanged += new System.EventHandler(this.Home_MaximumSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label RentX;
        private System.Windows.Forms.Button Ownerbtn;
        private System.Windows.Forms.Button Customerbtn;
        private System.Windows.Forms.Label Or;
        private System.Windows.Forms.Label youare;
        private System.Windows.Forms.Label Logo;
    }
}

