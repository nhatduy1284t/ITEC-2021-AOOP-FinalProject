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
            //textbox
            lstTxtDapAn.Add(txt_DapAn1);
            lstTxtDapAn.Add(txt_DapAn2);
            lstTxtDapAn.Add(txt_DapAn3);
            lstTxtDapAn.Add(txt_DapAn4);

            //lbl
            lstLabelDapAn.Add(lbl_DapAn1);
            lstLabelDapAn.Add(lbl_DapAn2);
            lstLabelDapAn.Add(lbl_DapAn3);
            lstLabelDapAn.Add(lbl_DapAn4);

            UpdateComboBoxTrueAnswer();
            //field
            cbx_QuestionField.Items.Add("Phần mềm");
            cbx_QuestionField.Items.Add("Phần cứng");
            cbx_QuestionField.Items.Add("Mạng");
            cbx_QuestionField.Items.Add("Bảo mật");
            cbx_QuestionField.SelectedIndex = 0;

        }
     
        private bool CheckValidFileQuestionBank(string filePath)
        {
            if (Path.GetExtension(filePath) != ".xml")
            {
                MessageBox.Show("File không đúng định dạng (phải là .xml)");
                return false;
            }
            using (XmlReader xml = XmlReader.Create(filePath))
            {
                if (xml.ReadToFollowing("questions"))
                    if (xml.MoveToAttribute("type"))
                        if (xml.Value == "bank")
                            return true;
                MessageBox.Show("File không hợp lệ");
                return false;
            }
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
                    xml.WriteAttributeString("type", "bank");
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
            MessageBox.Show("Thêm thành công !");
            ClearForm();
            
        }
        private bool CheckValidQuestion()
        {
            if (txt_NoiDungCauHoi.Text == "")
            {
                MessageBox.Show("Bạn chưa điền nội dung câu hỏi");
                return false;
            }

            for (int i = 0; i < lstTxtDapAn.Count; i++)
            {
                if(lstTxtDapAn[i].Text=="")
                {
                    MessageBox.Show($"Bạn điền thiếu đáp án {i+1}");
                    return false;
                }         
            }

            return true;
        }
        private void UpdateComboBoxTrueAnswer()
        {
            cbx_DapAnDung.Items.Clear();
            for (int i = 0; i < lstTxtDapAn.Count; i++)
            {
                cbx_DapAnDung.Items.Add($"Đáp án {i + 1}");
            }
            cbx_DapAnDung.SelectedIndex = 0;
        }
        private void ClearForm()
        {
            txt_NoiDungCauHoi.Text = "";
            foreach (var dapAn in lstTxtDapAn)
            {
                dapAn.Text = "";
            }
        }
       
        private void btn_ChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Chon tap tin .xml|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (!CheckValidFileQuestionBank(dlg.FileName))
                    return;
                fileName = dlg.FileName;
                lbl_FileName.Text = Path.GetFileName(fileName);
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThemDapAn_Click(object sender, EventArgs e)
        {
            if(lstLabelDapAn.Count==6)
            {
                MessageBox.Show($"Bạn chỉ được tạo tối đa 6 đáp án");
                return;
            }
    
            TextBox lastTxtDapAn= lstTxtDapAn[lstTxtDapAn.Count - 1];

            Label lblDapAn = new Label();
            lblDapAn.Text = $"Đáp án {lstLabelDapAn.Count + 1}";
            lblDapAn.Location = new Point(lastTxtDapAn.Location.X, lastTxtDapAn.Location.Y + 30);
            lstLabelDapAn.Add(lblDapAn);
           
            TextBox txtDapAn = new TextBox();
            txtDapAn.Size = lastTxtDapAn.Size;
            txtDapAn.Location = new Point(lblDapAn.Location.X, lblDapAn.Location.Y + 25);
            lstTxtDapAn.Add(txtDapAn);

            btn_BotDapAn.Location = new Point(btn_BotDapAn.Location.X, btn_BotDapAn.Location.Y + 30 + 25);
            btn_ThemDapAn.Location = new Point(btn_ThemDapAn.Location.X, btn_ThemDapAn.Location.Y + 30 + 25);

            
            Controls.Add(lblDapAn);
            Controls.Add(txtDapAn);

            UpdateComboBoxTrueAnswer();

        }

        private void btn_BotDapAn_Click(object sender, EventArgs e)
        {
            if (lstLabelDapAn.Count == 2)
            {
                MessageBox.Show($"Câu hỏi trắc nghiệm phải có tối thiểu 2 đáp án");
                return;
            }
            int lastIndex = lstLabelDapAn.Count-1;
            

            btn_BotDapAn.Location = new Point(btn_BotDapAn.Location.X, btn_BotDapAn.Location.Y - 30 - 25);
            btn_ThemDapAn.Location = new Point(btn_ThemDapAn.Location.X, btn_ThemDapAn.Location.Y - 30 - 25);
            Controls.Remove(lstLabelDapAn[lastIndex]);
            Controls.Remove(lstTxtDapAn[lastIndex]);
            lstLabelDapAn.RemoveAt(lastIndex);
            lstTxtDapAn.RemoveAt(lastIndex);

            UpdateComboBoxTrueAnswer();       
        }
    }
}

