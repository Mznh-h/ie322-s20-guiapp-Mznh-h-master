namespace Mazen_1845967_IE322
{
    partial class Picture_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Picture_form));
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.picTry = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadImage.BackgroundImage")));
            this.btnLoadImage.Location = new System.Drawing.Point(13, 13);
            this.btnLoadImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(710, 55);
            this.btnLoadImage.TabIndex = 9;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Location = new System.Drawing.Point(13, 519);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picTry
            // 
            this.picTry.Location = new System.Drawing.Point(13, 76);
            this.picTry.Margin = new System.Windows.Forms.Padding(4);
            this.picTry.Name = "picTry";
            this.picTry.Size = new System.Drawing.Size(710, 435);
            this.picTry.TabIndex = 7;
            this.picTry.TabStop = false;
            // 
            // Picture_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 550);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picTry);
            this.Name = "Picture_form";
            this.Text = "Picture_form";
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picTry;
    }
}