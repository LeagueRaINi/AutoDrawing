namespace AutoDrawer
{
    partial class MainForm
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
            this.ImportImageButton = new System.Windows.Forms.Button();
            this.SmallPreview = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SpeedTextbox = new System.Windows.Forms.TextBox();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.StartDrawingFunctionButton = new System.Windows.Forms.Button();
            this.ResetImageButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PreviewImageButton = new System.Windows.Forms.Button();
            this.BlackAndWhiteThresholdTextbox = new System.Windows.Forms.TextBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.ImageWidthTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ImageHeightTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SmallPreview)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportImageButton
            // 
            this.ImportImageButton.Location = new System.Drawing.Point(154, 4);
            this.ImportImageButton.Name = "ImportImageButton";
            this.ImportImageButton.Size = new System.Drawing.Size(109, 25);
            this.ImportImageButton.TabIndex = 0;
            this.ImportImageButton.Text = "Import Image";
            this.ImportImageButton.UseVisualStyleBackColor = true;
            this.ImportImageButton.Click += new System.EventHandler(this.ImportImageButton_Click);
            // 
            // SmallPreview
            // 
            this.SmallPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SmallPreview.Location = new System.Drawing.Point(269, 4);
            this.SmallPreview.Name = "SmallPreview";
            this.SmallPreview.Size = new System.Drawing.Size(234, 143);
            this.SmallPreview.TabIndex = 1;
            this.SmallPreview.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SpeedTextbox);
            this.panel1.Controls.Add(this.SpeedLabel);
            this.panel1.Controls.Add(this.StartDrawingFunctionButton);
            this.panel1.Controls.Add(this.ResetImageButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PreviewImageButton);
            this.panel1.Controls.Add(this.SmallPreview);
            this.panel1.Controls.Add(this.BlackAndWhiteThresholdTextbox);
            this.panel1.Controls.Add(this.SaveChangesButton);
            this.panel1.Controls.Add(this.ImageWidthTextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ImageHeightTextbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ImportImageButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 153);
            this.panel1.TabIndex = 2;
            // 
            // SpeedTextbox
            // 
            this.SpeedTextbox.Location = new System.Drawing.Point(82, 85);
            this.SpeedTextbox.Name = "SpeedTextbox";
            this.SpeedTextbox.Size = new System.Drawing.Size(66, 20);
            this.SpeedTextbox.TabIndex = 12;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(3, 88);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(44, 13);
            this.SpeedLabel.TabIndex = 11;
            this.SpeedLabel.Text = "Speed: ";
            // 
            // StartDrawingFunctionButton
            // 
            this.StartDrawingFunctionButton.Location = new System.Drawing.Point(6, 113);
            this.StartDrawingFunctionButton.Name = "StartDrawingFunctionButton";
            this.StartDrawingFunctionButton.Size = new System.Drawing.Size(257, 34);
            this.StartDrawingFunctionButton.TabIndex = 10;
            this.StartDrawingFunctionButton.Text = "Start Drawing Function";
            this.StartDrawingFunctionButton.UseVisualStyleBackColor = true;
            this.StartDrawingFunctionButton.Click += new System.EventHandler(this.StartDrawingFunctionButton_Click);
            // 
            // ResetImageButton
            // 
            this.ResetImageButton.Location = new System.Drawing.Point(154, 30);
            this.ResetImageButton.Name = "ResetImageButton";
            this.ResetImageButton.Size = new System.Drawing.Size(109, 25);
            this.ResetImageButton.TabIndex = 9;
            this.ResetImageButton.Text = "Reset Image";
            this.ResetImageButton.UseVisualStyleBackColor = true;
            this.ResetImageButton.Click += new System.EventHandler(this.ResetImageButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Brightness";
            // 
            // PreviewImageButton
            // 
            this.PreviewImageButton.Location = new System.Drawing.Point(154, 82);
            this.PreviewImageButton.Name = "PreviewImageButton";
            this.PreviewImageButton.Size = new System.Drawing.Size(109, 25);
            this.PreviewImageButton.TabIndex = 1;
            this.PreviewImageButton.Text = "Preview Full Image";
            this.PreviewImageButton.UseVisualStyleBackColor = true;
            this.PreviewImageButton.Click += new System.EventHandler(this.PreviewImageButton_Click);
            // 
            // BlackAndWhiteThresholdTextbox
            // 
            this.BlackAndWhiteThresholdTextbox.Location = new System.Drawing.Point(82, 59);
            this.BlackAndWhiteThresholdTextbox.Name = "BlackAndWhiteThresholdTextbox";
            this.BlackAndWhiteThresholdTextbox.Size = new System.Drawing.Size(66, 20);
            this.BlackAndWhiteThresholdTextbox.TabIndex = 7;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(154, 56);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(109, 25);
            this.SaveChangesButton.TabIndex = 6;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // ImageWidthTextbox
            // 
            this.ImageWidthTextbox.Location = new System.Drawing.Point(82, 7);
            this.ImageWidthTextbox.Name = "ImageWidthTextbox";
            this.ImageWidthTextbox.Size = new System.Drawing.Size(66, 20);
            this.ImageWidthTextbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Image Width: ";
            // 
            // ImageHeightTextbox
            // 
            this.ImageHeightTextbox.Location = new System.Drawing.Point(82, 33);
            this.ImageHeightTextbox.Name = "ImageHeightTextbox";
            this.ImageHeightTextbox.Size = new System.Drawing.Size(66, 20);
            this.ImageHeightTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image Height:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(533, 180);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Auto Drawer v1";
            ((System.ComponentModel.ISupportInitialize)(this.SmallPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ImportImageButton;
        private System.Windows.Forms.PictureBox SmallPreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PreviewImageButton;
        private System.Windows.Forms.TextBox ImageWidthTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ImageHeightTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.TextBox BlackAndWhiteThresholdTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StartDrawingFunctionButton;
        private System.Windows.Forms.Button ResetImageButton;
        private System.Windows.Forms.TextBox SpeedTextbox;
        private System.Windows.Forms.Label SpeedLabel;
    }
}

