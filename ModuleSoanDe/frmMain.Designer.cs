
namespace ModuleSoanDe
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
            this.btn_ChamBai = new System.Windows.Forms.Button();
            this.btn_TaoBaiThi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SoanCauHoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ChamBai
            // 
            this.btn_ChamBai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ChamBai.Location = new System.Drawing.Point(12, 258);
            this.btn_ChamBai.Name = "btn_ChamBai";
            this.btn_ChamBai.Size = new System.Drawing.Size(506, 69);
            this.btn_ChamBai.TabIndex = 0;
            this.btn_ChamBai.TabStop = false;
            this.btn_ChamBai.Text = "Chấm bài";
            this.btn_ChamBai.UseVisualStyleBackColor = true;
            this.btn_ChamBai.Click += new System.EventHandler(this.btn_ChamBai_Click);
            // 
            // btn_TaoBaiThi
            // 
            this.btn_TaoBaiThi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_TaoBaiThi.Location = new System.Drawing.Point(12, 183);
            this.btn_TaoBaiThi.Name = "btn_TaoBaiThi";
            this.btn_TaoBaiThi.Size = new System.Drawing.Size(506, 69);
            this.btn_TaoBaiThi.TabIndex = 0;
            this.btn_TaoBaiThi.TabStop = false;
            this.btn_TaoBaiThi.Text = "Tạo bài thi";
            this.btn_TaoBaiThi.UseVisualStyleBackColor = true;
            this.btn_TaoBaiThi.Click += new System.EventHandler(this.btn_TaoBaiThi_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Công cụ soạn đề thi";
            // 
            // btn_SoanCauHoi
            // 
            this.btn_SoanCauHoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SoanCauHoi.Location = new System.Drawing.Point(12, 108);
            this.btn_SoanCauHoi.Name = "btn_SoanCauHoi";
            this.btn_SoanCauHoi.Size = new System.Drawing.Size(506, 69);
            this.btn_SoanCauHoi.TabIndex = 0;
            this.btn_SoanCauHoi.TabStop = false;
            this.btn_SoanCauHoi.Text = "Soạn câu hỏi";
            this.btn_SoanCauHoi.UseVisualStyleBackColor = true;
            this.btn_SoanCauHoi.Click += new System.EventHandler(this.btn_SoanCauHoi_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(185, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_SoanCauHoi_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(533, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_SoanCauHoi);
            this.Controls.Add(this.btn_ChamBai);
            this.Controls.Add(this.btn_TaoBaiThi);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module soạn đề";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_ChamBai;
        private System.Windows.Forms.Button btn_TaoBaiThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SoanCauHoi;
        private System.Windows.Forms.Button button1;
    }
}

