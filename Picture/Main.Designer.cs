namespace Picture
{
    partial class Main
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
            this.btLoadPicture = new System.Windows.Forms.Button();
            this.pBxPicture = new System.Windows.Forms.PictureBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.lbChangeView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btLoadPicture
            // 
            this.btLoadPicture.Location = new System.Drawing.Point(12, 12);
            this.btLoadPicture.Name = "btLoadPicture";
            this.btLoadPicture.Size = new System.Drawing.Size(127, 40);
            this.btLoadPicture.TabIndex = 0;
            this.btLoadPicture.Text = "Wczytaj";
            this.btLoadPicture.UseVisualStyleBackColor = true;
            this.btLoadPicture.Click += new System.EventHandler(this.btLoadPicture_Click);
            // 
            // pBxPicture
            // 
            this.pBxPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBxPicture.Location = new System.Drawing.Point(12, 68);
            this.pBxPicture.Name = "pBxPicture";
            this.pBxPicture.Size = new System.Drawing.Size(776, 370);
            this.pBxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBxPicture.TabIndex = 1;
            this.pBxPicture.TabStop = false;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(145, 12);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(127, 40);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Usuń";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // cmbView
            // 
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Location = new System.Drawing.Point(496, 28);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new System.Drawing.Size(292, 24);
            this.cmbView.TabIndex = 3;
            this.cmbView.SelectedValueChanged += new System.EventHandler(this.cmbView_SelectedValueChanged);
            // 
            // lbChangeView
            // 
            this.lbChangeView.AutoSize = true;
            this.lbChangeView.Location = new System.Drawing.Point(354, 31);
            this.lbChangeView.Name = "lbChangeView";
            this.lbChangeView.Size = new System.Drawing.Size(136, 16);
            this.lbChangeView.TabIndex = 4;
            this.lbChangeView.Text = "Sposób wyświetlania:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbChangeView);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.pBxPicture);
            this.Controls.Add(this.btLoadPicture);
            this.Name = "Main";
            this.Text = "Obrazek";
            ((System.ComponentModel.ISupportInitialize)(this.pBxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLoadPicture;
        private System.Windows.Forms.PictureBox pBxPicture;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Label lbChangeView;
    }
}

