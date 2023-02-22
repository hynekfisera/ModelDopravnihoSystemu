namespace ModelDopravnihoSystemu
{
    partial class Stanice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stanice));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelStaniceId = new System.Windows.Forms.Label();
            this.labelStaniceVyzvednuti = new System.Windows.Forms.Label();
            this.labelStaniceOdvezeni = new System.Windows.Forms.Label();
            this.btnInformace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelStaniceId
            // 
            this.labelStaniceId.AutoSize = true;
            this.labelStaniceId.Location = new System.Drawing.Point(3, 4);
            this.labelStaniceId.Name = "labelStaniceId";
            this.labelStaniceId.Size = new System.Drawing.Size(35, 13);
            this.labelStaniceId.TabIndex = 1;
            this.labelStaniceId.Text = "label1";
            // 
            // labelStaniceVyzvednuti
            // 
            this.labelStaniceVyzvednuti.AutoSize = true;
            this.labelStaniceVyzvednuti.Location = new System.Drawing.Point(3, 19);
            this.labelStaniceVyzvednuti.Name = "labelStaniceVyzvednuti";
            this.labelStaniceVyzvednuti.Size = new System.Drawing.Size(35, 13);
            this.labelStaniceVyzvednuti.TabIndex = 2;
            this.labelStaniceVyzvednuti.Text = "label2";
            // 
            // labelStaniceOdvezeni
            // 
            this.labelStaniceOdvezeni.AutoSize = true;
            this.labelStaniceOdvezeni.Location = new System.Drawing.Point(3, 34);
            this.labelStaniceOdvezeni.Name = "labelStaniceOdvezeni";
            this.labelStaniceOdvezeni.Size = new System.Drawing.Size(35, 13);
            this.labelStaniceOdvezeni.TabIndex = 3;
            this.labelStaniceOdvezeni.Text = "label3";
            // 
            // btnInformace
            // 
            this.btnInformace.Location = new System.Drawing.Point(3, 46);
            this.btnInformace.Name = "btnInformace";
            this.btnInformace.Size = new System.Drawing.Size(63, 23);
            this.btnInformace.TabIndex = 4;
            this.btnInformace.Text = "Informace";
            this.btnInformace.UseVisualStyleBackColor = true;
            this.btnInformace.Click += new System.EventHandler(this.btnInformace_Click);
            // 
            // Stanice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInformace);
            this.Controls.Add(this.labelStaniceOdvezeni);
            this.Controls.Add(this.labelStaniceVyzvednuti);
            this.Controls.Add(this.labelStaniceId);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Stanice";
            this.Size = new System.Drawing.Size(98, 73);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label labelStaniceId;
        public System.Windows.Forms.Label labelStaniceVyzvednuti;
        public System.Windows.Forms.Label labelStaniceOdvezeni;
        private System.Windows.Forms.Button btnInformace;
    }
}
