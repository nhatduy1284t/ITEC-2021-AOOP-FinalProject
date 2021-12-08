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
using System.Xml.Linq;

namespace ModuleSoanDe
{
    public partial class frmSoanCauHoi : Form
    {
        List<Label> lstLabelDapAn = new List<Label>();
        List<TextBox> lstTxtDapAn = new List<TextBox>();
        string fileName = "DanhSachCauHoi.xml";
        public frmSoanCauHoi()
        {
            InitializeComponent();
            Form_Load();
        }
        void Form_Load()
        {
            ////textbox
            lstTxtDapAn.Add(txt_DapAn1);
            lstTxtDapAn.Add(txt_DapAn2);
            lstTxtDapAn.Add(txt_DapAn3);
            lstTxtDapAn.Add(txt_DapAn4);

            CapNhatDanhSachDapAnDung();
            //field
            cbx_QuestionField.Items.Add("Phần mềm");
            cbx_QuestionField.Items.Add("Phần cứng");
            cbx_QuestionField.Items.Add("Mạng");
            cbx_QuestionField.Items.Add("Bảo mật");
            cbx_QuestionField.SelectedIndex = 0;

        }
        public void SetSizeToParent()
        {
            //this.MaximumSize = new Size(Parent.MaximumSize.Width, Parent.MaximumSize.Height);
            //this.Size = new Size(Parent.Size.Width, Parent.Size.Height);    
        }

        private void btn_TaoCauHoi_Click(object sender, EventArgs e)
        {
            if (!CheckValidQuestion())
                return;
            string questionField = cbx_QuestionField.SelectedItem.ToString();
            int indexTrueAnswer = cbx_DapAnDung.SelectedIndex;

            if (!File.Exists(fileName))
            {
                using (XmlWriter xml = XmlWriter.Create(fileName, new XmlWriterSettings() { Indent = true }))
                {
                    xml.WriteStartElement("questions");
                    xml.WriteStartElement("question");
                    xml.WriteAttributeString("field", questionField);
                    xml.WriteAttributeString("answerCount", lstTxtDapAn.Count.ToString());

                    xml.WriteStartElement("content");
                    xml.WriteValue(txt_NoiDungCauHoi.Text);
                    xml.WriteEndElement();

                    for (int i = 0; i < lstTxtDapAn.Count; i++)
                    {
                        xml.WriteStartElement("answer");
                        xml.WriteValue(lstTxtDapAn[i].Text);
                        xml.WriteEndElement();
                    }
                    xml.WriteStartElement("trueanswer");
                    xml.WriteValue(lstTxtDapAn[indexTrueAnswer].Text);
                    xml.WriteEndElement();

                    xml.WriteEndElement();
                    xml.WriteEndElement();
                }
            }
            else
            {
                XDocument doc = XDocument.Load(fileName);
                XElement question = new XElement("question",
                    new XAttribute("field", questionField),
                    new XAttribute("answerCount", lstTxtDapAn.Count.ToString()));
                question.Add(new XElement("content", txt_NoiDungCauHoi.Text));
                for (int i = 0; i < lstTxtDapAn.Count; i++)
                {
                    question.Add(new XElement("answer", lstTxtDapAn[i].Text));
                }
                question.Add(new XElement("trueanswer", lstTxtDapAn[indexTrueAnswer].Text));
                doc.Root.Add(question);
                doc.Save(fileName, SaveOptions.None);
            }
            ClearForm();
        }
        private bool CheckValidQuestion()
        {
            if (txt_NoiDungCauHoi.Text == "")
            {
                MessageBox.Show("Bạn chưa điền nội dung câu hỏi");
                return false;
            }

            if (txt_DapAn1.Text == "" || txt_DapAn2.Text == "" || txt_DapAn3.Text == "" || txt_DapAn4.Text == "")
            {
                MessageBox.Show("Bạn điền thiếu đáp án");
            }
            return true;
        }
        private void CapNhatDanhSachDapAnDung()
        {
            for (int i = 0; i < lstTxtDapAn.Count; i++)
            {
                cbx_DapAnDung.Items.Add($"Đáp án {i + 1}");
            }
            cbx_DapAnDung.SelectedIndex = 0;
        }
        private void ClearForm()
        {
            //Clear form ngoại trừ nút Quay lại
            txt_NoiDungCauHoi.Text = "";
            foreach (var dapAn in lstTxtDapAn)
            {
                dapAn.Text = "";
            }
            cbx_DapAnDung.SelectedIndex = -1;
            cbx_QuestionField.SelectedIndex = -1;
        }
        private void ThemDapAn()
        {
            //Label
            Label lblDapAn = new Label();
            lblDapAn.Text = $"Đáp án {lstLabelDapAn.Count + 1}";
            lblDapAn.Location = new Point(30, 170);
            lstLabelDapAn.Add(lblDapAn);

            //TextBox
            TextBox txtDapAn = new TextBox();
            txtDapAn.Location = new Point(lblDapAn.Location.X, lblDapAn.Location.Y + 30);

            //Button thêm
            btn_ThemDapAn.Location = new Point(btn_ThemDapAn.Location.X, txtDapAn.Location.Y + 10);
            Controls.Add(lblDapAn);
            Controls.Add(txtDapAn);
        }

        private void btn_ChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Chon tap tin .xml|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;
                lbl_FileName.Text = Path.GetFileName(fileName);
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

