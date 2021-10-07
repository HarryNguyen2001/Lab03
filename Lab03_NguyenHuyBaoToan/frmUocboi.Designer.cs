
namespace Lab03_NguyenHuyBaoToan
{
    partial class frmUocboi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBSCNN = new System.Windows.Forms.RadioButton();
            this.btnUSCLN = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtb);
            this.groupBox1.Controls.Add(this.txta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(64, 110);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(339, 26);
            this.txtb.TabIndex = 1;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(64, 59);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(339, 26);
            this.txta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBSCNN);
            this.groupBox2.Controls.Add(this.btnUSCLN);
            this.groupBox2.Location = new System.Drawing.Point(468, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn tìm";
            // 
            // btnBSCNN
            // 
            this.btnBSCNN.AutoSize = true;
            this.btnBSCNN.Location = new System.Drawing.Point(6, 110);
            this.btnBSCNN.Name = "btnBSCNN";
            this.btnBSCNN.Size = new System.Drawing.Size(89, 24);
            this.btnBSCNN.TabIndex = 0;
            this.btnBSCNN.TabStop = true;
            this.btnBSCNN.Text = "BSCNN";
            this.btnBSCNN.UseVisualStyleBackColor = true;
            // 
            // btnUSCLN
            // 
            this.btnUSCLN.AutoSize = true;
            this.btnUSCLN.Location = new System.Drawing.Point(7, 58);
            this.btnUSCLN.Name = "btnUSCLN";
            this.btnUSCLN.Size = new System.Drawing.Size(88, 24);
            this.btnUSCLN.TabIndex = 0;
            this.btnUSCLN.TabStop = true;
            this.btnUSCLN.Text = "USCLN";
            this.btnUSCLN.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnBoQua);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Controls.Add(this.txtKq);
            this.groupBox3.Location = new System.Drawing.Point(44, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(572, 176);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(402, 117);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 36);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(231, 117);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(95, 36);
            this.btnBoQua.TabIndex = 2;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(64, 117);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(95, 36);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(64, 40);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(339, 26);
            this.txtKq.TabIndex = 1;
            // 
            // frmUocboi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 396);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUocboi";
            this.Text = "frmUocboi";
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
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btnBSCNN;
        private System.Windows.Forms.RadioButton btnUSCLN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtKq;
    }
}