namespace LAb03
{
    partial class Bai2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rbtnU = new System.Windows.Forms.RadioButton();
            this.rbtnB = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(35, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.txtResult);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(35, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 99);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox3.Controls.Add(this.rbtnB);
            this.groupBox3.Controls.Add(this.rbtnU);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(409, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn tìm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "B:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(76, 57);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(260, 22);
            this.txtB.TabIndex = 2;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_KeyPress);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(76, 29);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(260, 22);
            this.txtA.TabIndex = 2;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtA_KeyPress);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtResult.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(107, 36);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(299, 33);
            this.txtResult.TabIndex = 2;
            // 
            // rbtnU
            // 
            this.rbtnU.AutoSize = true;
            this.rbtnU.Checked = true;
            this.rbtnU.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnU.Location = new System.Drawing.Point(40, 29);
            this.rbtnU.Name = "rbtnU";
            this.rbtnU.Size = new System.Drawing.Size(77, 24);
            this.rbtnU.TabIndex = 0;
            this.rbtnU.TabStop = true;
            this.rbtnU.Text = "USCLN";
            this.rbtnU.UseVisualStyleBackColor = true;
            // 
            // rbtnB
            // 
            this.rbtnB.AutoSize = true;
            this.rbtnB.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnB.Location = new System.Drawing.Point(40, 55);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(79, 24);
            this.rbtnB.TabIndex = 0;
            this.rbtnB.Text = "BSCNN";
            this.rbtnB.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFind.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(79, 296);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(89, 33);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(237, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 33);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Bỏ qua";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(395, 296);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnB;
        private System.Windows.Forms.RadioButton rbtnU;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}