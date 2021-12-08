
namespace ModuleThiTracNghiem
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_De = new System.Windows.Forms.Label();
            this.btn_BatDau = new System.Windows.Forms.Button();
            this.btn_ChonDe = new System.Windows.Forms.Button();
            this.txt_MaNhanVien = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_De
            // 
            this.lbl_De.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_De.AutoSize = true;
            this.lbl_De.Location = new System.Drawing.Point(232, 184);
            this.lbl_De.Name = "lbl_De";
            this.lbl_De.Size = new System.Drawing.Size(51, 20);
            this.lbl_De.TabIndex = 12;
            this.lbl_De.Text = "mã đề";
            this.lbl_De.Visible = false;
            // 
            // btn_BatDau
            // 
            this.btn_BatDau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BatDau.Location = new System.Drawing.Point(14, 502);
            this.btn_BatDau.Name = "btn_BatDau";
            this.btn_BatDau.Size = new System.Drawing.Size(451, 41);
            this.btn_BatDau.TabIndex = 11;
            this.btn_BatDau.TabStop = false;
            this.btn_BatDau.Text = "Bắt đầu thi";
            this.btn_BatDau.UseVisualStyleBackColor = true;
            this.btn_BatDau.Click += new System.EventHandler(this.btn_BatDau_Click);
            // 
            // btn_ChonDe
            // 
            this.btn_ChonDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ChonDe.Location = new System.Drawing.Point(371, 175);
            this.btn_ChonDe.Name = "btn_ChonDe";
            this.btn_ChonDe.Size = new System.Drawing.Size(94, 29);
            this.btn_ChonDe.TabIndex = 10;
            this.btn_ChonDe.TabStop = false;
            this.btn_ChonDe.Text = "Chọn đề";
            this.btn_ChonDe.UseVisualStyleBackColor = true;
            this.btn_ChonDe.Click += new System.EventHandler(this.btn_ChonDe_Click);
            // 
            // txt_MaNhanVien
            // 
            this.txt_MaNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaNhanVien.Location = new System.Drawing.Point(130, 128);
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.Size = new System.Drawing.Size(130, 27);
            this.txt_MaNhanVien.TabIndex = 1;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_HoTen.Location = new System.Drawing.Point(130, 80);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(335, 27);
            this.txt_HoTen.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Điền thông tin cá nhân";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 100);
            this.label5.TabIndex = 14;
            this.label5.Text = "(*)Lưu ý\r\n- Điền thông tin và chọn mã đề trước khi bắt đầu\r\n- Mỗi câu hỏi có thời" +
    " gian là 15 giây.\r\n- Hết thời gian làm bài sẽ tự động nộp bài.\r\n\r\n";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 553);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_De);
            this.Controls.Add(this.btn_BatDau);
            this.Controls.Add(this.btn_ChonDe);
            this.Controls.Add(this.txt_MaNhanVien);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Ứng dụng thi trắc nghiệm";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_De;
        private System.Windows.Forms.Button btn_BatDau;
        private System.Windows.Forms.Button btn_ChonDe;
        private System.Windows.Forms.TextBox txt_MaNhanVien;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

