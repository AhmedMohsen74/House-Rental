
namespace house_managment_system_project_cs
{
    partial class Display_the_pictures_of_the_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display_the_pictures_of_the_home));
            this.DISPLAY_photo = new System.Windows.Forms.PictureBox();
            this.ViewPhotos = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DISPLAY_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // DISPLAY_photo
            // 
            this.DISPLAY_photo.Location = new System.Drawing.Point(296, 54);
            this.DISPLAY_photo.Name = "DISPLAY_photo";
            this.DISPLAY_photo.Size = new System.Drawing.Size(465, 276);
            this.DISPLAY_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DISPLAY_photo.TabIndex = 0;
            this.DISPLAY_photo.TabStop = false;
            // 
            // ViewPhotos
            // 
            this.ViewPhotos.BackColor = System.Drawing.Color.Transparent;
            this.ViewPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPhotos.Location = new System.Drawing.Point(378, 497);
            this.ViewPhotos.Name = "ViewPhotos";
            this.ViewPhotos.Size = new System.Drawing.Size(284, 53);
            this.ViewPhotos.TabIndex = 1;
            this.ViewPhotos.Text = "ViewPhotos";
            this.ViewPhotos.UseVisualStyleBackColor = false;
            this.ViewPhotos.Click += new System.EventHandler(this.ViewPhotos_Click);
            // 
            // backbtn
            // 
            this.backbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(47, 271);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(79, 96);
            this.backbtn.TabIndex = 29;
            this.backbtn.Text = "↩️";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Display_the_pictures_of_the_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1043, 573);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.ViewPhotos);
            this.Controls.Add(this.DISPLAY_photo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Display_the_pictures_of_the_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display_the_pictures_of_the_home";
            ((System.ComponentModel.ISupportInitialize)(this.DISPLAY_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DISPLAY_photo;
        private System.Windows.Forms.Button ViewPhotos;
        private System.Windows.Forms.Button backbtn;
    }
}