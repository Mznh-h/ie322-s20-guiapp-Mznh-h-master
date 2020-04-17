namespace Mazen_1845967_IE322
{
    partial class Random_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Random_form));
            this.BtnRandomNum = new System.Windows.Forms.Button();
            this.btnGenerateRandom = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRandomNum
            // 
            this.BtnRandomNum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRandomNum.BackgroundImage")));
            this.BtnRandomNum.Location = new System.Drawing.Point(198, 126);
            this.BtnRandomNum.Name = "BtnRandomNum";
            this.BtnRandomNum.Size = new System.Drawing.Size(150, 28);
            this.BtnRandomNum.TabIndex = 13;
            this.BtnRandomNum.Text = "Random Number";
            this.BtnRandomNum.UseVisualStyleBackColor = true;
            this.BtnRandomNum.Click += new System.EventHandler(this.BtnRandomNum_Click);
            // 
            // btnGenerateRandom
            // 
            this.btnGenerateRandom.Location = new System.Drawing.Point(7, 23);
            this.btnGenerateRandom.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateRandom.Name = "btnGenerateRandom";
            this.btnGenerateRandom.Size = new System.Drawing.Size(341, 68);
            this.btnGenerateRandom.TabIndex = 11;
            this.btnGenerateRandom.Text = "Generate Random Color";
            this.btnGenerateRandom.UseVisualStyleBackColor = true;
            this.btnGenerateRandom.Click += new System.EventHandler(this.btnGenerateRandom_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Location = new System.Drawing.Point(7, 126);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 28);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "r-g-b";
            // 
            // Random_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 166);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRandomNum);
            this.Controls.Add(this.btnGenerateRandom);
            this.Controls.Add(this.btnBack);
            this.Name = "Random_form";
            this.Text = "Random_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRandomNum;
        private System.Windows.Forms.Button btnGenerateRandom;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}