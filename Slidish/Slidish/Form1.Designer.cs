namespace Slidish
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
            this.label1 = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.PictureBox();
            this.g = new System.Windows.Forms.PictureBox();
            this.y = new System.Windows.Forms.PictureBox();
            this.b = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quartz MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // r
            // 
            this.r.BackColor = System.Drawing.Color.Red;
            this.r.Location = new System.Drawing.Point(44, 418);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(108, 150);
            this.r.TabIndex = 1;
            this.r.TabStop = false;
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.Color.Lime;
            this.g.Location = new System.Drawing.Point(158, 418);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(108, 150);
            this.g.TabIndex = 2;
            this.g.TabStop = false;
            // 
            // y
            // 
            this.y.BackColor = System.Drawing.Color.Yellow;
            this.y.Location = new System.Drawing.Point(272, 418);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(108, 150);
            this.y.TabIndex = 3;
            this.y.TabStop = false;
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.Color.Teal;
            this.b.Location = new System.Drawing.Point(386, 418);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(108, 150);
            this.b.TabIndex = 4;
            this.b.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(538, 568);
            this.Controls.Add(this.b);
            this.Controls.Add(this.y);
            this.Controls.Add(this.g);
            this.Controls.Add(this.r);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Slidish";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox r;
        private System.Windows.Forms.PictureBox g;
        private System.Windows.Forms.PictureBox y;
        private System.Windows.Forms.PictureBox b;
        private System.Windows.Forms.Timer timer1;
    }
}

