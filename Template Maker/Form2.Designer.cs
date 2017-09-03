namespace Template_Maker
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tbPreview = new System.Windows.Forms.TextBox();
            this.lblReturnFocus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPreview
            // 
            this.tbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPreview.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreview.Location = new System.Drawing.Point(29, 25);
            this.tbPreview.Multiline = true;
            this.tbPreview.Name = "tbPreview";
            this.tbPreview.Size = new System.Drawing.Size(438, 418);
            this.tbPreview.TabIndex = 0;
            this.tbPreview.TabStop = false;
            this.tbPreview.Click += new System.EventHandler(this.tbPreview_Click);
            // 
            // lblReturnFocus
            // 
            this.lblReturnFocus.AutoSize = true;
            this.lblReturnFocus.Location = new System.Drawing.Point(181, 184);
            this.lblReturnFocus.Name = "lblReturnFocus";
            this.lblReturnFocus.Size = new System.Drawing.Size(97, 13);
            this.lblReturnFocus.TabIndex = 1;
            this.lblReturnFocus.Text = "Return Focus Here";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 470);
            this.Controls.Add(this.tbPreview);
            this.Controls.Add(this.lblReturnFocus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(515, 509);
            this.Name = "Form2";
            this.Text = "Template Maker - Preview";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbPreview;
        private System.Windows.Forms.Label lblReturnFocus;
    }
}