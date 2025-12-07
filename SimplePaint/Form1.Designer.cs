using System;
using System.Windows.Forms; // ПРАВИЛЬНО

namespace SimplePaint
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.btnColor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMenu.Controls.Add(this.btnEllipse);
            this.panelMenu.Controls.Add(this.btnRect);
            this.panelMenu.Controls.Add(this.btnLine);
            this.panelMenu.Controls.Add(this.btnEraser);
            this.panelMenu.Controls.Add(this.btnPen);
            this.panelMenu.Controls.Add(this.btnSave);
            this.panelMenu.Controls.Add(this.btnClear);
            this.panelMenu.Controls.Add(this.trackBarSize);
            this.panelMenu.Controls.Add(this.btnColor);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(950, 80);
            this.panelMenu.TabIndex = 0;
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(470, 12);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(60, 50);
            this.btnEllipse.TabIndex = 8;
            this.btnEllipse.Text = "Круг";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(379, 12);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(90, 50);
            this.btnRect.TabIndex = 7;
            this.btnRect.Text = "Квадрат";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(314, 12);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(64, 50);
            this.btnLine.TabIndex = 6;
            this.btnLine.Text = "Линия";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Location = new System.Drawing.Point(227, 12);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(86, 50);
            this.btnEraser.TabIndex = 5;
            this.btnEraser.Text = "Ластик";
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnPen
            // 
            this.btnPen.Location = new System.Drawing.Point(136, 12);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(90, 50);
            this.btnPen.TabIndex = 4;
            this.btnPen.Text = "Карандаш";
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(860, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 50);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохр.";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(776, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 50);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // trackBarSize
            // 
            this.trackBarSize.Location = new System.Drawing.Point(538, 36);
            this.trackBarSize.Maximum = 30;
            this.trackBarSize.Minimum = 1;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(150, 56);
            this.trackBarSize.TabIndex = 1;
            this.trackBarSize.Value = 5;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBarSize_Scroll);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(12, 12);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(100, 50);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Цвет";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(950, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Super Paint C#";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnPen;
    }
}