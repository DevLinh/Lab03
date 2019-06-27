using System;

namespace LAb03
{
    partial class Bai1
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMutiply = new System.Windows.Forms.Button();
            this.btnDevide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(12, 231);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(198, 75);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(208, 32);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "0.00";
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtA_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "SIMPLE CALCULATOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Result:";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(198, 114);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(208, 32);
            this.txtB.TabIndex = 1;
            this.txtB.Text = "0.00";
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_KeyPress);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Info;
            this.txtResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(198, 152);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(208, 32);
            this.txtResult.TabIndex = 1;
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(96, 231);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(75, 23);
            this.btnSubstract.TabIndex = 0;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.BtnSubstract_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(348, 231);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(432, 231);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnMutiply
            // 
            this.btnMutiply.Location = new System.Drawing.Point(180, 231);
            this.btnMutiply.Name = "btnMutiply";
            this.btnMutiply.Size = new System.Drawing.Size(75, 23);
            this.btnMutiply.TabIndex = 0;
            this.btnMutiply.Text = "X";
            this.btnMutiply.UseVisualStyleBackColor = true;
            this.btnMutiply.Click += new System.EventHandler(this.BtnMuntiply_Click);
            // 
            // btnDevide
            // 
            this.btnDevide.Location = new System.Drawing.Point(264, 231);
            this.btnDevide.Name = "btnDevide";
            this.btnDevide.Size = new System.Drawing.Size(75, 23);
            this.btnDevide.TabIndex = 0;
            this.btnDevide.Text = "/";
            this.btnDevide.UseVisualStyleBackColor = true;
            this.btnDevide.Click += new System.EventHandler(this.BtnDevide_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 290);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnDevide);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMutiply);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnPlus);
            this.Name = "Bai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Bai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMutiply;
        private System.Windows.Forms.Button btnDevide;
    }
}

