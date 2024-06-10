namespace Csharp_bangcuuchuong
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
            this.txtso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnxem = new System.Windows.Forms.Button();
            this.lbsketqua = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(201, 139);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(272, 20);
            this.txtso.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng cửu chương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bạn muốn hiển thị bảng cửu chương mấy";
            // 
            // btnxem
            // 
            this.btnxem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.Location = new System.Drawing.Point(513, 131);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(89, 35);
            this.btnxem.TabIndex = 3;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // lbsketqua
            // 
            this.lbsketqua.FormattingEnabled = true;
            this.lbsketqua.Location = new System.Drawing.Point(201, 182);
            this.lbsketqua.Name = "lbsketqua";
            this.lbsketqua.Size = new System.Drawing.Size(272, 147);
            this.lbsketqua.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbsketqua);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.ListBox lbsketqua;
    }
}

