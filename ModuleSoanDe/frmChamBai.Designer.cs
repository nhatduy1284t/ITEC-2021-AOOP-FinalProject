
namespace ModuleSoanDe
{
    partial class frmChamBai
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
            this.btn_ChamBai = new System.Windows.Forms.Button();
            this.lbx_Test = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChonFileDapAn = new System.Windows.Forms.Button();
            this.btn_DocFileBaiLam = new System.Windows.Forms.Button();
            this.lbl_ChonFileDapAn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ChamBai
            // 
            this.btn_ChamBai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChamBai.Location = new System.Drawing.Point(12, 447);
            this.btn_ChamBai.Name = "btn_ChamBai";
            this.btn_ChamBai.Size = new System.Drawing.Size(492, 71);
            this.btn_ChamBai.TabIndex = 9;
            this.btn_ChamBai.Text = "Thực hiện chấm bài";
            this.btn_ChamBai.UseVisualStyleBackColor = true;
            this.btn_ChamBai.Click += new System.EventHandler(this.btn_ChamBai_Click);
            // 
            // lbx_Test
            // 
            this.lbx_Test.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbx_Test.FormattingEnabled = true;
            this.lbx_Test.ItemHeight = 20;
            this.lbx_Test.Location = new System.Drawing.Point(12, 156);
            this.lbx_Test.Name = "lbx_Test";
            this.lbx_Test.Size = new System.Drawing.Size(492, 284);
            this.lbx_Test.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(153, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chấm bài";
            // 
            // btn_ChonFileDapAn
            // 
            this.btn_ChonFileDapAn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ChonFileDapAn.Location = new System.Drawing.Point(12, 66);
            this.btn_ChonFileDapAn.Name = "btn_ChonFileDapAn";
            this.btn_ChonFileDapAn.Size = new System.Drawing.Size(135, 29);
            this.btn_ChonFileDapAn.TabIndex = 15;
            this.btn_ChonFileDapAn.Text = "Chọn file đáp án";
            this.btn_ChonFileDapAn.UseVisualStyleBackColor = true;
            this.btn_ChonFileDapAn.Click += new System.EventHandler(this.btn_ChonFileDapAn_Click);
            // 
            // btn_DocFileBaiLam
            // 
            this.btn_DocFileBaiLam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_DocFileBaiLam.Location = new System.Drawing.Point(12, 108);
            this.btn_DocFileBaiLam.Name = "btn_DocFileBaiLam";
            this.btn_DocFileBaiLam.Size = new System.Drawing.Size(135, 32);
            this.btn_DocFileBaiLam.TabIndex = 12;
            this.btn_DocFileBaiLam.Text = "Chọn file bài làm";
            this.btn_DocFileBaiLam.UseVisualStyleBackColor = true;
            this.btn_DocFileBaiLam.Click += new System.EventHandler(this.btn_DocFileBaiLam_Click);
            // 
            // lbl_ChonFileDapAn
            // 
            this.lbl_ChonFileDapAn.AutoSize = true;
            this.lbl_ChonFileDapAn.Location = new System.Drawing.Point(154, 70);
            this.lbl_ChonFileDapAn.Name = "lbl_ChonFileDapAn";
            this.lbl_ChonFileDapAn.Size = new System.Drawing.Size(41, 20);
            this.lbl_ChonFileDapAn.TabIndex = 16;
            this.lbl_ChonFileDapAn.Text = "        ";
            // 
            // frmChamBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 530);
            this.Controls.Add(this.lbl_ChonFileDapAn);
            this.Controls.Add(this.btn_ChonFileDapAn);
            this.Controls.Add(this.btn_DocFileBaiLam);
            this.Controls.Add(this.btn_ChamBai);
            this.Controls.Add(this.lbx_Test);
            this.Controls.Add(this.label1);
            this.Name = "frmChamBai";
            this.Text = "frmChamBai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ChamBai;
        private System.Windows.Forms.ListBox lbx_Test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChonFileDapAn;
        private System.Windows.Forms.Button btn_DocFileBaiLam;
        private System.Windows.Forms.Label lbl_ChonFileDapAn;
    }
}