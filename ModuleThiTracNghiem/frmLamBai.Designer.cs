
namespace ModuleThiTracNghiem
{
    partial class frmLamBai
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
            this.clock = new ModuleThiTracNghiem.Clock();
            this.btn_XemCauDanhDau = new System.Windows.Forms.Button();
            this.btn_MoveRight = new System.Windows.Forms.Button();
            this.btn_MoveLeft = new System.Windows.Forms.Button();
            this.lbl_Page = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clock.Location = new System.Drawing.Point(166, 472);
            this.clock.mm = 0;
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(155, 61);
            this.clock.ss = 0;
            this.clock.TabIndex = 22;
            // 
            // btn_XemCauDanhDau
            // 
            this.btn_XemCauDanhDau.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_XemCauDanhDau.Location = new System.Drawing.Point(172, 539);
            this.btn_XemCauDanhDau.Name = "btn_XemCauDanhDau";
            this.btn_XemCauDanhDau.Size = new System.Drawing.Size(201, 39);
            this.btn_XemCauDanhDau.TabIndex = 21;
            this.btn_XemCauDanhDau.Text = "Xem câu hỏi đã đánh dấu";
            this.btn_XemCauDanhDau.UseVisualStyleBackColor = true;
            this.btn_XemCauDanhDau.Click += new System.EventHandler(this.btn_XemCauDanhDau_Click);
            // 
            // btn_MoveRight
            // 
            this.btn_MoveRight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_MoveRight.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MoveRight.Location = new System.Drawing.Point(112, 540);
            this.btn_MoveRight.Name = "btn_MoveRight";
            this.btn_MoveRight.Size = new System.Drawing.Size(48, 39);
            this.btn_MoveRight.TabIndex = 19;
            this.btn_MoveRight.Text = "→";
            this.btn_MoveRight.UseVisualStyleBackColor = true;
            this.btn_MoveRight.Click += new System.EventHandler(this.btn_MoveRight_Click);
            // 
            // btn_MoveLeft
            // 
            this.btn_MoveLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_MoveLeft.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MoveLeft.Location = new System.Drawing.Point(65, 540);
            this.btn_MoveLeft.Name = "btn_MoveLeft";
            this.btn_MoveLeft.Size = new System.Drawing.Size(46, 39);
            this.btn_MoveLeft.TabIndex = 20;
            this.btn_MoveLeft.Text = "←";
            this.btn_MoveLeft.UseVisualStyleBackColor = true;
            this.btn_MoveLeft.Click += new System.EventHandler(this.btn_MoveLeft_Click);
            // 
            // lbl_Page
            // 
            this.lbl_Page.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Page.AutoSize = true;
            this.lbl_Page.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Page.Location = new System.Drawing.Point(9, 543);
            this.lbl_Page.Name = "lbl_Page";
            this.lbl_Page.Size = new System.Drawing.Size(68, 28);
            this.lbl_Page.TabIndex = 18;
            this.lbl_Page.Text = " pnum";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Submit.Location = new System.Drawing.Point(379, 539);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(129, 39);
            this.btn_Submit.TabIndex = 17;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // frmLamBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 590);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.btn_XemCauDanhDau);
            this.Controls.Add(this.btn_MoveRight);
            this.Controls.Add(this.btn_MoveLeft);
            this.Controls.Add(this.lbl_Page);
            this.Controls.Add(this.btn_Submit);
            this.Name = "frmLamBai";
            this.Text = "frmLamBai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clock clock;
        private System.Windows.Forms.Button btn_XemCauDanhDau;
        private System.Windows.Forms.Button btn_MoveRight;
        private System.Windows.Forms.Button btn_MoveLeft;
        private System.Windows.Forms.Label lbl_Page;
        private System.Windows.Forms.Button btn_Submit;
    }
}