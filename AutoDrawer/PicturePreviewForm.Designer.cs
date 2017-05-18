namespace AutoDrawer
{
    partial class PicturePreviewForm
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
            this.Imagebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Imagebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Imagebox
            // 
            this.Imagebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagebox.Location = new System.Drawing.Point(0, 0);
            this.Imagebox.Name = "Imagebox";
            this.Imagebox.Size = new System.Drawing.Size(234, 170);
            this.Imagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Imagebox.TabIndex = 0;
            this.Imagebox.TabStop = false;
            // 
            // PicturePreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 170);
            this.Controls.Add(this.Imagebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PicturePreviewForm";
            this.Text = "Picture Preview";
            this.Load += new System.EventHandler(this.PicturePreviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imagebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Imagebox;
    }
}