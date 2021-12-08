
namespace ModuleSoanDe
{
    partial class frmTaoDeThi
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
            this.lbl_ChonFile = new System.Windows.Forms.Label();
            this.btn_ChonFile = new System.Windows.Forms.Button();
            this.txt_MaDe = new System.Windows.Forms.TextBox();
            this.clbx_CauHoi = new System.Windows.Forms.CheckedListBox();
            this.lbl_SoLuongCauHoi = new System.Windows.Forms.Label();
            this.lbl_SoLuongToiDa = new System.Windows.Forms.Label();
            this.txt_SoLuongCauHoi = new System.Windows.Forms.NumericUpDown();
            this.cbx_LuaChon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_TaoDeThi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuongCauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ChonFile
            // 
            this.lbl_ChonFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ChonFile.AutoSize = true;
            this.lbl_ChonFile.Location = new System.Drawing.Point(121, 185);
            this.lbl_ChonFile.Name = "lbl_ChonFile";
            this.lbl_ChonFile.Size = new System.Drawing.Size(0, 20);
            this.lbl_ChonFile.TabIndex = 21;
            // 
            // btn_ChonFile
            // 
            this.btn_ChonFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ChonFile.Location = new System.Drawing.Point(12, 181);
            this.btn_ChonFile.Name = "btn_ChonFile";
            this.btn_ChonFile.Size = new System.Drawing.Size(92, 29);
            this.btn_ChonFile.TabIndex = 20;
            this.btn_ChonFile.Text = "Chọn file";
            this.btn_ChonFile.UseVisualStyleBackColor = true;
            this.btn_ChonFile.Click += new System.EventHandler(this.btn_ChonFile_Click);
            // 
            // txt_MaDe
            // 
            this.txt_MaDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaDe.Location = new System.Drawing.Point(463, 74);
            this.txt_MaDe.Name = "txt_MaDe";
            this.txt_MaDe.Size = new System.Drawing.Size(73, 27);
            this.txt_MaDe.TabIndex = 19;
            // 
            // clbx_CauHoi
            // 
            this.clbx_CauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbx_CauHoi.CheckOnClick = true;
            this.clbx_CauHoi.FormattingEnabled = true;
            this.clbx_CauHoi.HorizontalScrollbar = true;
            this.clbx_CauHoi.Location = new System.Drawing.Point(12, 216);
            this.clbx_CauHoi.Name = "clbx_CauHoi";
            this.clbx_CauHoi.Size = new System.Drawing.Size(525, 312);
            this.clbx_CauHoi.TabIndex = 18;
            this.clbx_CauHoi.Visible = false;
            this.clbx_CauHoi.SelectedIndexChanged += new System.EventHandler(this.clbx_CauHoi_SelectedIndexChanged);
            // 
            // lbl_SoLuongCauHoi
            // 
            this.lbl_SoLuongCauHoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_SoLuongCauHoi.AutoSize = true;
            this.lbl_SoLuongCauHoi.Location = new System.Drawing.Point(12, 119);
            this.lbl_SoLuongCauHoi.Name = "lbl_SoLuongCauHoi";
            this.lbl_SoLuongCauHoi.Size = new System.Drawing.Size(121, 20);
            this.lbl_SoLuongCauHoi.TabIndex = 12;
            this.lbl_SoLuongCauHoi.Text = "Số lượng câu hỏi";
            // 
            // lbl_SoLuongToiDa
            // 
            this.lbl_SoLuongToiDa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_SoLuongToiDa.AutoSize = true;
            this.lbl_SoLuongToiDa.Location = new System.Drawing.Point(213, 119);
            this.lbl_SoLuongToiDa.Name = "lbl_SoLuongToiDa";
            this.lbl_SoLuongToiDa.Size = new System.Drawing.Size(112, 20);
            this.lbl_SoLuongToiDa.TabIndex = 17;
            this.lbl_SoLuongToiDa.Text = "Số lượng tối đa";
            // 
            // txt_SoLuongCauHoi
            // 
            this.txt_SoLuongCauHoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_SoLuongCauHoi.Location = new System.Drawing.Point(139, 117);
            this.txt_SoLuongCauHoi.Name = "txt_SoLuongCauHoi";
            this.txt_SoLuongCauHoi.Size = new System.Drawing.Size(68, 27);
            this.txt_SoLuongCauHoi.TabIndex = 15;
            // 
            // cbx_LuaChon
            // 
            this.cbx_LuaChon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_LuaChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_LuaChon.FormattingEnabled = true;
            this.cbx_LuaChon.Location = new System.Drawing.Point(87, 74);
            this.cbx_LuaChon.Name = "cbx_LuaChon";
            this.cbx_LuaChon.Size = new System.Drawing.Size(120, 28);
            this.cbx_LuaChon.TabIndex = 16;
            this.cbx_LuaChon.SelectedIndexChanged += new System.EventHandler(this.cbx_LuaChon_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã đề";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lựa chọn";
            // 
            // btn_TaoDeThi
            // 
            this.btn_TaoDeThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TaoDeThi.Location = new System.Drawing.Point(12, 534);
            this.btn_TaoDeThi.Name = "btn_TaoDeThi";
            this.btn_TaoDeThi.Size = new System.Drawing.Size(525, 64);
            this.btn_TaoDeThi.TabIndex = 11;
            this.btn_TaoDeThi.Text = "Tạo đề thi";
            this.btn_TaoDeThi.UseVisualStyleBackColor = true;
            this.btn_TaoDeThi.Click += new System.EventHandler(this.btn_TaoDeThi_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(182, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tạo đề thi";
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Location = new System.Drawing.Point(10, 12);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(94, 29);
            this.btn_QuayLai.TabIndex = 45;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // frmTaoDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 604);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.lbl_ChonFile);
            this.Controls.Add(this.btn_ChonFile);
            this.Controls.Add(this.txt_MaDe);
            this.Controls.Add(this.clbx_CauHoi);
            this.Controls.Add(this.lbl_SoLuongCauHoi);
            this.Controls.Add(this.lbl_SoLuongToiDa);
            this.Controls.Add(this.txt_SoLuongCauHoi);
            this.Controls.Add(this.cbx_LuaChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_TaoDeThi);
            this.Controls.Add(this.label1);
            this.Name = "frmTaoDeThi";
            this.Text = "frmTaoDeThi";
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoLuongCauHoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ChonFile;
        private System.Windows.Forms.Button btn_ChonFile;
        private System.Windows.Forms.TextBox txt_MaDe;
        private System.Windows.Forms.CheckedListBox clbx_CauHoi;
        private System.Windows.Forms.Label lbl_SoLuongCauHoi;
        private System.Windows.Forms.Label lbl_SoLuongToiDa;
        private System.Windows.Forms.NumericUpDown txt_SoLuongCauHoi;
        private System.Windows.Forms.ComboBox cbx_LuaChon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_TaoDeThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_QuayLai;
    }
}