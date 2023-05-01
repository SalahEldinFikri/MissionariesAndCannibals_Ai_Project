namespace WindowsFormsApplication31
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
            this.picbase1 = new System.Windows.Forms.PictureBox();
            this.piccarrot = new System.Windows.Forms.PictureBox();
            this.picgoat = new System.Windows.Forms.PictureBox();
            this.picwolf = new System.Windows.Forms.PictureBox();
            this.picbase2 = new System.Windows.Forms.PictureBox();
            this.picship = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccarrot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picwolf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbase2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picship)).BeginInit();
            this.SuspendLayout();
            // 
            // picbase1
            // 
            this.picbase1.Location = new System.Drawing.Point(1003, 508);
            this.picbase1.Margin = new System.Windows.Forms.Padding(4);
            this.picbase1.Name = "picbase1";
            this.picbase1.Size = new System.Drawing.Size(324, 62);
            this.picbase1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbase1.TabIndex = 0;
            this.picbase1.TabStop = false;
            // 
            // piccarrot
            // 
            this.piccarrot.BackColor = System.Drawing.Color.Transparent;
            this.piccarrot.Location = new System.Drawing.Point(1117, 384);
            this.piccarrot.Margin = new System.Windows.Forms.Padding(4);
            this.piccarrot.Name = "piccarrot";
            this.piccarrot.Size = new System.Drawing.Size(93, 123);
            this.piccarrot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccarrot.TabIndex = 0;
            this.piccarrot.TabStop = false;
            this.piccarrot.Click += new System.EventHandler(this.piccarrot_Click);
            // 
            // picgoat
            // 
            this.picgoat.BackColor = System.Drawing.Color.Transparent;
            this.picgoat.Location = new System.Drawing.Point(1219, 384);
            this.picgoat.Margin = new System.Windows.Forms.Padding(4);
            this.picgoat.Name = "picgoat";
            this.picgoat.Size = new System.Drawing.Size(93, 123);
            this.picgoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picgoat.TabIndex = 0;
            this.picgoat.TabStop = false;
            this.picgoat.Click += new System.EventHandler(this.picgoat_Click);
            // 
            // picwolf
            // 
            this.picwolf.BackColor = System.Drawing.Color.Transparent;
            this.picwolf.Location = new System.Drawing.Point(1016, 384);
            this.picwolf.Margin = new System.Windows.Forms.Padding(4);
            this.picwolf.Name = "picwolf";
            this.picwolf.Size = new System.Drawing.Size(93, 123);
            this.picwolf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picwolf.TabIndex = 0;
            this.picwolf.TabStop = false;
            this.picwolf.Click += new System.EventHandler(this.picwolf_Click);
            // 
            // picbase2
            // 
            this.picbase2.Location = new System.Drawing.Point(0, 512);
            this.picbase2.Margin = new System.Windows.Forms.Padding(4);
            this.picbase2.Name = "picbase2";
            this.picbase2.Size = new System.Drawing.Size(352, 62);
            this.picbase2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbase2.TabIndex = 0;
            this.picbase2.TabStop = false;
            // 
            // picship
            // 
            this.picship.BackColor = System.Drawing.Color.Transparent;
            this.picship.Location = new System.Drawing.Point(729, 508);
            this.picship.Margin = new System.Windows.Forms.Padding(4);
            this.picship.Name = "picship";
            this.picship.Size = new System.Drawing.Size(265, 62);
            this.picship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picship.TabIndex = 0;
            this.picship.TabStop = false;
            this.picship.Click += new System.EventHandler(this.picship_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = ".............";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1328, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picship);
            this.Controls.Add(this.picbase2);
            this.Controls.Add(this.picwolf);
            this.Controls.Add(this.piccarrot);
            this.Controls.Add(this.picbase1);
            this.Controls.Add(this.picgoat);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccarrot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picwolf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbase2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbase1;
        private System.Windows.Forms.PictureBox piccarrot;
        private System.Windows.Forms.PictureBox picgoat;
        private System.Windows.Forms.PictureBox picwolf;
        private System.Windows.Forms.PictureBox picbase2;
        private System.Windows.Forms.PictureBox picship;
        private System.Windows.Forms.Label label1;
    }
}

