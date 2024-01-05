namespace Base64toPNG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbBase = new TextBox();
            pbResult = new PictureBox();
            bConvert = new Button();
            bSave = new Button();
            sfdImage = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbResult).BeginInit();
            SuspendLayout();
            // 
            // tbBase
            // 
            tbBase.Location = new Point(12, 12);
            tbBase.Multiline = true;
            tbBase.Name = "tbBase";
            tbBase.Size = new Size(442, 257);
            tbBase.TabIndex = 0;
            // 
            // pbResult
            // 
            pbResult.Location = new Point(12, 305);
            pbResult.Name = "pbResult";
            pbResult.Size = new Size(442, 133);
            pbResult.SizeMode = PictureBoxSizeMode.Zoom;
            pbResult.TabIndex = 1;
            pbResult.TabStop = false;
            // 
            // bConvert
            // 
            bConvert.Location = new Point(12, 275);
            bConvert.Name = "bConvert";
            bConvert.Size = new Size(219, 24);
            bConvert.TabIndex = 2;
            bConvert.Text = "Convert";
            bConvert.UseVisualStyleBackColor = true;
            bConvert.Click += bConvert_Click;
            // 
            // bSave
            // 
            bSave.Enabled = false;
            bSave.Location = new Point(237, 275);
            bSave.Name = "bSave";
            bSave.Size = new Size(219, 24);
            bSave.TabIndex = 3;
            bSave.Text = "Save";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // sfdImage
            // 
            sfdImage.DefaultExt = "PNG|*.png";
            sfdImage.Filter = "PNG|*.png";
            sfdImage.OverwritePrompt = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 450);
            Controls.Add(bSave);
            Controls.Add(bConvert);
            Controls.Add(pbResult);
            Controls.Add(tbBase);
            MaximizeBox = false;
            MaximumSize = new Size(482, 489);
            MinimumSize = new Size(482, 489);
            Name = "Form1";
            ShowIcon = false;
            Text = "Base64 to Image";
            ((System.ComponentModel.ISupportInitialize)pbResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbBase;
        private PictureBox pbResult;
        private Button bConvert;
        private Button bSave;
        private SaveFileDialog sfdImage;
    }
}
