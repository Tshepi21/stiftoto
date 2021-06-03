namespace Tshepiso_Mohatlane__Project_1
{
    partial class END
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(END));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblname = new System.Windows.Forms.Label();
            this.pblost = new System.Windows.Forms.PictureBox();
            this.pbwin = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.brnpalyagin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbwin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.pblost);
            this.panel1.Controls.Add(this.pbwin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblscore);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 253);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblname.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Red;
            this.lblname.Location = new System.Drawing.Point(119, 26);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(171, 26);
            this.lblname.TabIndex = 6;
            this.lblname.Text = "YOUR SCORE";
            // 
            // pblost
            // 
            this.pblost.Image = ((System.Drawing.Image)(resources.GetObject("pblost.Image")));
            this.pblost.Location = new System.Drawing.Point(209, 91);
            this.pblost.Name = "pblost";
            this.pblost.Size = new System.Drawing.Size(154, 159);
            this.pblost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblost.TabIndex = 5;
            this.pblost.TabStop = false;
            // 
            // pbwin
            // 
            this.pbwin.Image = ((System.Drawing.Image)(resources.GetObject("pbwin.Image")));
            this.pbwin.Location = new System.Drawing.Point(0, 94);
            this.pbwin.Name = "pbwin";
            this.pbwin.Size = new System.Drawing.Size(152, 143);
            this.pbwin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbwin.TabIndex = 4;
            this.pbwin.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(147, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(119, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "YOUR SCORE";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.Color.Gold;
            this.lblscore.Location = new System.Drawing.Point(147, 52);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(109, 39);
            this.lblscore.TabIndex = 1;
            this.lblscore.Text = "label3";
            this.lblscore.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(131, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "THE END ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnexit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnexit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnexit.Location = new System.Drawing.Point(56, 310);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(119, 64);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button3_Click);
            // 
            // brnpalyagin
            // 
            this.brnpalyagin.BackColor = System.Drawing.Color.Red;
            this.brnpalyagin.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Bold);
            this.brnpalyagin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.brnpalyagin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.brnpalyagin.Location = new System.Drawing.Point(200, 310);
            this.brnpalyagin.Name = "brnpalyagin";
            this.brnpalyagin.Size = new System.Drawing.Size(119, 64);
            this.brnpalyagin.TabIndex = 10;
            this.brnpalyagin.Text = "PLAY AGAIN";
            this.brnpalyagin.UseVisualStyleBackColor = false;
            this.brnpalyagin.Click += new System.EventHandler(this.brnpalyagin_Click);
            // 
            // END
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 387);
            this.Controls.Add(this.brnpalyagin);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "END";
            this.Text = "END";
            this.Load += new System.EventHandler(this.END_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbwin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button brnpalyagin;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.PictureBox pblost;
        private System.Windows.Forms.PictureBox pbwin;
    }
}