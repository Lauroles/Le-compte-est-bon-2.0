namespace Le_compte_est_bon_2._0
{
    partial class end
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
            this.endPhrase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // endPhrase
            // 
            this.endPhrase.AutoSize = true;
            this.endPhrase.Location = new System.Drawing.Point(125, 108);
            this.endPhrase.Name = "endPhrase";
            this.endPhrase.Size = new System.Drawing.Size(30, 17);
            this.endPhrase.TabIndex = 17;
            this.endPhrase.Text = "null";
            // 
            // end
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 246);
            this.Controls.Add(this.endPhrase);
            this.Name = "end";
            this.Text = "end";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label endPhrase;
    }
}