using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ModuleThiTracNghiem
{
    public partial class frmMain : Form
    {
        string xmlFilePath;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_ChonDe_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Chon tap tin .xml|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                xmlFilePath = dlg.FileName;
                lbl_De.Text = Path.GetFileName(xmlFilePath);
                lbl_De.Visible = true;
            }
        }
        private void DisplayPage(string page)
        {
            ClearPage();

            switch (page)
            {
                case Page.LAM_BAI:
                    {                 
                        this.Visible=false;
                        frmLamBai f = new frmLamBai(xmlFilePath);
                        f.name = txt_HoTen.Text;
                        f.id = txt_MaNhanVien.Text;
                        f.ShowDialog();
                        this.Close();
                    }
                    break;
            }
        }

        private void ClearPage()
        {

            for (int i = Controls.Count - 1; i >= 0; i--)
            {
              Controls.Remove(Controls[i]);
            }
        }
        private bool CheckFillInfo()
        {
            if (txt_HoTen.Text == "" || txt_MaNhanVien.Text == "")
            {
                MessageBox.Show("Hãy điền đầy thủ thông tin trước khi bắt đầu làm bài!");
                return false;
            }
            return true;
        }
        private bool CheckSelectedFile()
        {
            if(xmlFilePath==null)
            {
                MessageBox.Show("Chưa chọn file đề thi!");
                return false;
            }
            return true;
        }
        private bool CheckValidFile(string filePath)
        {
            if (xmlFilePath == null)
            {
                MessageBox.Show("Chưa chọn file đề thi!");
                return false;
            }
            
            if (Path.GetExtension(filePath)!=".xml")
            {
                MessageBox.Show("File không hợp lệ");
                return false;
            }
            using (XmlReader xml = XmlReader.Create(filePath))
            {
                if (xml.ReadToFollowing("questions"))
                    if(xml.MoveToAttribute("type"))
                        if (xml.Value == "questions")
                            return true;    
                MessageBox.Show("File không đúng định dạng");
                return false;
            }
            
        }
        private void btn_BatDau_Click(object sender, EventArgs e)
        {
            
            if (CheckFillInfo() && CheckValidFile(xmlFilePath))
                DisplayPage(Page.LAM_BAI);         
        }

       
    }
}
