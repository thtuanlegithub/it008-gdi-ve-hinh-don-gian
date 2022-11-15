namespace IT008_GDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCircle = new System.Windows.Forms.Button();
            this.btLine = new System.Windows.Forms.Button();
            this.btSquare = new System.Windows.Forms.Button();
            this.btTriangle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonColorDialog = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btCircle);
            this.panel1.Controls.Add(this.btLine);
            this.panel1.Controls.Add(this.btSquare);
            this.panel1.Controls.Add(this.btTriangle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonColorDialog);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 553);
            this.panel1.TabIndex = 0;
            // 
            // btCircle
            // 
            this.btCircle.FlatAppearance.BorderSize = 0;
            this.btCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCircle.Image = ((System.Drawing.Image)(resources.GetObject("btCircle.Image")));
            this.btCircle.Location = new System.Drawing.Point(52, 438);
            this.btCircle.Name = "btCircle";
            this.btCircle.Size = new System.Drawing.Size(74, 68);
            this.btCircle.TabIndex = 4;
            this.btCircle.UseVisualStyleBackColor = true;
            this.btCircle.Click += new System.EventHandler(this.btCircle_Click);
            // 
            // btLine
            // 
            this.btLine.FlatAppearance.BorderSize = 0;
            this.btLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLine.Image = ((System.Drawing.Image)(resources.GetObject("btLine.Image")));
            this.btLine.Location = new System.Drawing.Point(156, 465);
            this.btLine.Name = "btLine";
            this.btLine.Size = new System.Drawing.Size(85, 27);
            this.btLine.TabIndex = 3;
            this.btLine.UseVisualStyleBackColor = true;
            this.btLine.Click += new System.EventHandler(this.btLine_Click);
            // 
            // btSquare
            // 
            this.btSquare.FlatAppearance.BorderSize = 0;
            this.btSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSquare.Image = ((System.Drawing.Image)(resources.GetObject("btSquare.Image")));
            this.btSquare.Location = new System.Drawing.Point(156, 351);
            this.btSquare.Name = "btSquare";
            this.btSquare.Size = new System.Drawing.Size(75, 70);
            this.btSquare.TabIndex = 3;
            this.btSquare.UseVisualStyleBackColor = true;
            this.btSquare.Click += new System.EventHandler(this.btSquare_Click);
            // 
            // btTriangle
            // 
            this.btTriangle.FlatAppearance.BorderSize = 0;
            this.btTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTriangle.Image = ((System.Drawing.Image)(resources.GetObject("btTriangle.Image")));
            this.btTriangle.Location = new System.Drawing.Point(52, 351);
            this.btTriangle.Name = "btTriangle";
            this.btTriangle.Size = new System.Drawing.Size(86, 70);
            this.btTriangle.TabIndex = 3;
            this.btTriangle.UseVisualStyleBackColor = true;
            this.btTriangle.Click += new System.EventHandler(this.btTriangle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn hình cần vẽ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn màu:";
            // 
            // buttonColorDialog
            // 
            this.buttonColorDialog.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonColorDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorDialog.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColorDialog.Location = new System.Drawing.Point(173, 221);
            this.buttonColorDialog.Name = "buttonColorDialog";
            this.buttonColorDialog.Size = new System.Drawing.Size(40, 40);
            this.buttonColorDialog.TabIndex = 0;
            this.buttonColorDialog.UseVisualStyleBackColor = false;
            this.buttonColorDialog.Click += new System.EventHandler(this.buttonColorDialog_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Location = new System.Drawing.Point(266, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 553);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1002, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng vẽ hình đơn giản";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonColorDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCircle;
        private System.Windows.Forms.Button btTriangle;
        private System.Windows.Forms.Button btLine;
        private System.Windows.Forms.Button btSquare;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

