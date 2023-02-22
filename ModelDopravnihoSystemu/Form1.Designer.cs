namespace ModelDopravnihoSystemu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnInit = new System.Windows.Forms.Button();
            this.auto8 = new ModelDopravnihoSystemu.Auto();
            this.auto7 = new ModelDopravnihoSystemu.Auto();
            this.auto6 = new ModelDopravnihoSystemu.Auto();
            this.auto5 = new ModelDopravnihoSystemu.Auto();
            this.auto4 = new ModelDopravnihoSystemu.Auto();
            this.auto3 = new ModelDopravnihoSystemu.Auto();
            this.auto2 = new ModelDopravnihoSystemu.Auto();
            this.auto1 = new ModelDopravnihoSystemu.Auto();
            this.stanice8 = new ModelDopravnihoSystemu.Stanice();
            this.stanice7 = new ModelDopravnihoSystemu.Stanice();
            this.stanice6 = new ModelDopravnihoSystemu.Stanice();
            this.stanice5 = new ModelDopravnihoSystemu.Stanice();
            this.stanice4 = new ModelDopravnihoSystemu.Stanice();
            this.stanice3 = new ModelDopravnihoSystemu.Stanice();
            this.stanice2 = new ModelDopravnihoSystemu.Stanice();
            this.stanice1 = new ModelDopravnihoSystemu.Stanice();
            this.centralniDispecink1 = new ModelDopravnihoSystemu.CentralniDispecink();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(23, 23);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 23);
            this.btnInit.TabIndex = 1;
            this.btnInit.Text = "Zapnout";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // auto8
            // 
            this.auto8.CentralniDispecink = null;
            this.auto8.Location = new System.Drawing.Point(232, 284);
            this.auto8.Name = "auto8";
            this.auto8.Size = new System.Drawing.Size(29, 31);
            this.auto8.Start = new System.Drawing.Point(0, 0);
            this.auto8.TabIndex = 18;
            // 
            // auto7
            // 
            this.auto7.CentralniDispecink = null;
            this.auto7.Location = new System.Drawing.Point(382, 247);
            this.auto7.Name = "auto7";
            this.auto7.Size = new System.Drawing.Size(29, 31);
            this.auto7.Start = new System.Drawing.Point(0, 0);
            this.auto7.TabIndex = 17;
            // 
            // auto6
            // 
            this.auto6.CentralniDispecink = null;
            this.auto6.Location = new System.Drawing.Point(583, 321);
            this.auto6.Name = "auto6";
            this.auto6.Size = new System.Drawing.Size(29, 31);
            this.auto6.Start = new System.Drawing.Point(0, 0);
            this.auto6.TabIndex = 16;
            // 
            // auto5
            // 
            this.auto5.CentralniDispecink = null;
            this.auto5.Location = new System.Drawing.Point(511, 202);
            this.auto5.Name = "auto5";
            this.auto5.Size = new System.Drawing.Size(29, 31);
            this.auto5.Start = new System.Drawing.Point(0, 0);
            this.auto5.TabIndex = 15;
            // 
            // auto4
            // 
            this.auto4.CentralniDispecink = null;
            this.auto4.Location = new System.Drawing.Point(384, 137);
            this.auto4.Name = "auto4";
            this.auto4.Size = new System.Drawing.Size(29, 31);
            this.auto4.Start = new System.Drawing.Point(0, 0);
            this.auto4.TabIndex = 14;
            // 
            // auto3
            // 
            this.auto3.CentralniDispecink = null;
            this.auto3.Location = new System.Drawing.Point(382, 81);
            this.auto3.Name = "auto3";
            this.auto3.Size = new System.Drawing.Size(29, 31);
            this.auto3.Start = new System.Drawing.Point(0, 0);
            this.auto3.TabIndex = 13;
            // 
            // auto2
            // 
            this.auto2.CentralniDispecink = null;
            this.auto2.Location = new System.Drawing.Point(233, 101);
            this.auto2.Name = "auto2";
            this.auto2.Size = new System.Drawing.Size(29, 31);
            this.auto2.Start = new System.Drawing.Point(0, 0);
            this.auto2.TabIndex = 12;
            // 
            // auto1
            // 
            this.auto1.CentralniDispecink = null;
            this.auto1.Location = new System.Drawing.Point(118, 214);
            this.auto1.Name = "auto1";
            this.auto1.Size = new System.Drawing.Size(29, 31);
            this.auto1.Start = new System.Drawing.Point(0, 0);
            this.auto1.TabIndex = 11;
            // 
            // stanice8
            // 
            this.stanice8.Id = 0;
            this.stanice8.Location = new System.Drawing.Point(231, 321);
            this.stanice8.Name = "stanice8";
            this.stanice8.Size = new System.Drawing.Size(85, 73);
            this.stanice8.TabIndex = 10;
            this.stanice8.VyzvednutiCount = 0;
            // 
            // stanice7
            // 
            this.stanice7.Id = 0;
            this.stanice7.Location = new System.Drawing.Point(384, 284);
            this.stanice7.Name = "stanice7";
            this.stanice7.Size = new System.Drawing.Size(89, 73);
            this.stanice7.TabIndex = 9;
            this.stanice7.VyzvednutiCount = 0;
            // 
            // stanice6
            // 
            this.stanice6.Id = 0;
            this.stanice6.Location = new System.Drawing.Point(616, 280);
            this.stanice6.Name = "stanice6";
            this.stanice6.Size = new System.Drawing.Size(87, 73);
            this.stanice6.TabIndex = 8;
            this.stanice6.VyzvednutiCount = 0;
            // 
            // stanice5
            // 
            this.stanice5.Id = 0;
            this.stanice5.Location = new System.Drawing.Point(546, 172);
            this.stanice5.Name = "stanice5";
            this.stanice5.Size = new System.Drawing.Size(90, 73);
            this.stanice5.TabIndex = 7;
            this.stanice5.VyzvednutiCount = 0;
            // 
            // stanice4
            // 
            this.stanice4.Id = 0;
            this.stanice4.Location = new System.Drawing.Point(419, 81);
            this.stanice4.Name = "stanice4";
            this.stanice4.Size = new System.Drawing.Size(83, 73);
            this.stanice4.TabIndex = 6;
            this.stanice4.VyzvednutiCount = 0;
            // 
            // stanice3
            // 
            this.stanice3.Id = 0;
            this.stanice3.Location = new System.Drawing.Point(308, 34);
            this.stanice3.Name = "stanice3";
            this.stanice3.Size = new System.Drawing.Size(88, 73);
            this.stanice3.TabIndex = 5;
            this.stanice3.VyzvednutiCount = 0;
            // 
            // stanice2
            // 
            this.stanice2.Id = 0;
            this.stanice2.Location = new System.Drawing.Point(158, 60);
            this.stanice2.Name = "stanice2";
            this.stanice2.Size = new System.Drawing.Size(84, 73);
            this.stanice2.TabIndex = 4;
            this.stanice2.VyzvednutiCount = 0;
            // 
            // stanice1
            // 
            this.stanice1.Id = 0;
            this.stanice1.Location = new System.Drawing.Point(44, 151);
            this.stanice1.Name = "stanice1";
            this.stanice1.Size = new System.Drawing.Size(88, 73);
            this.stanice1.TabIndex = 3;
            this.stanice1.VyzvednutiCount = 0;
            // 
            // centralniDispecink1
            // 
            this.centralniDispecink1.Location = new System.Drawing.Point(257, 151);
            this.centralniDispecink1.Name = "centralniDispecink1";
            this.centralniDispecink1.Size = new System.Drawing.Size(59, 63);
            this.centralniDispecink1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.auto8);
            this.Controls.Add(this.auto7);
            this.Controls.Add(this.auto6);
            this.Controls.Add(this.auto5);
            this.Controls.Add(this.auto4);
            this.Controls.Add(this.auto3);
            this.Controls.Add(this.auto2);
            this.Controls.Add(this.auto1);
            this.Controls.Add(this.stanice8);
            this.Controls.Add(this.stanice7);
            this.Controls.Add(this.stanice6);
            this.Controls.Add(this.stanice5);
            this.Controls.Add(this.stanice4);
            this.Controls.Add(this.stanice3);
            this.Controls.Add(this.stanice2);
            this.Controls.Add(this.stanice1);
            this.Controls.Add(this.centralniDispecink1);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnInit;
        private Stanice stanice1;
        private Stanice stanice2;
        private Stanice stanice3;
        private Stanice stanice4;
        private Stanice stanice5;
        private Stanice stanice6;
        private Stanice stanice7;
        private Stanice stanice8;
        private Auto auto1;
        private Auto auto2;
        private Auto auto3;
        private Auto auto4;
        private Auto auto5;
        private Auto auto6;
        private Auto auto7;
        private Auto auto8;
        public CentralniDispecink centralniDispecink1;
    }
}

