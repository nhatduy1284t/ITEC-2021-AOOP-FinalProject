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
using ModuleSoanDe.Class;
namespace ModuleSoanDe
{
    public partial class frmTaoDeThi : Form
    {
        List<Question> lstCauHoi = new List<Question>();
        List<int> lstViTriCauHoiTuChon = new List<int>();
        List<int> lstViTriCauHoiRandom = new List<int>();
        string historyFilePath="History.xml";
        string xmlQuestionFilePath;
 
        public frmTaoDeThi()
        {
            InitializeComponent();
            Form_Load();
        }
        private void Form_Load()
        { 
            //cbx Lua chon
            cbx_LuaChon.Items.Add("Ngẫu nhiên");
            cbx_LuaChon.Items.Add("Tự chọn");
            cbx_LuaChon.SelectedIndex = 0;

            SetMaximumValueNumberBox(lstCauHoi.Count);
        }
        private void LoadQuestionFromFileToList(string filePath)
        {    
            try
            {
                lstCauHoi.Clear();
                using (XmlReader xml = XmlReader.Create(filePath))
                {
                    xml.ReadToFollowing("questions");
                    while (xml.ReadToFollowing("question"))
                    {
                        Question q = new Question();
                        xml.MoveToAttribute("field");
                        q.Field = xml.Value;
                        xml.MoveToAttribute("answerCount");
                        int answerCount = int.Parse(xml.Value);
                        xml.ReadToFollowing("content");
                        q.Content = xml.ReadElementContentAsString();
                        for (int i = 0; i < answerCount; i++)
                        {
                            xml.ReadToFollowing("answer");
                            q.Answers.Add(xml.ReadElementContentAsString());
                        }
                        xml.ReadToFollowing("trueanswer");
                        q.TrueAnswer = xml.ReadElementContentAsString();
                        lstCauHoi.Add(q);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Không đúng định dạng file");
                return;
            }
            

        }
        private void DisplayViewOptionNgauNhien()
        {
            lbl_SoLuongCauHoi.Visible = true;
            txt_SoLuongCauHoi.Visible = true;
            lbl_SoLuongToiDa.Visible = true;
            clbx_CauHoi.Visible = false;
        }
        private void DisplayViewOptionTuChon()
        {
            lbl_SoLuongCauHoi.Visible = false;
            txt_SoLuongCauHoi.Visible = false;
            lbl_SoLuongToiDa.Visible = false;
            clbx_CauHoi.Visible = true;
        }
        private void FillCheckedListBoxCauHoi()
        {

            clbx_CauHoi.Items.Clear();
            //lstCauHoi có trước rồi mới xài hàm này
            foreach (var q in lstCauHoi)
            {
                clbx_CauHoi.Items.Add(q.Content);
            }
        }

        private void cbx_LuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_LuaChon.SelectedItem.ToString() == "Ngẫu nhiên")
            {
                DisplayViewOptionNgauNhien();
            }
            else if (cbx_LuaChon.SelectedItem.ToString() == "Tự chọn")
            {
                DisplayViewOptionTuChon();

            }
        }

        private void clbx_CauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = clbx_CauHoi.SelectedIndex;
            if(lstViTriCauHoiTuChon.Contains(index))
            {
                lstViTriCauHoiTuChon.Remove(index);
            }
            else
            {
                lstViTriCauHoiTuChon.Add(index);
            }
        }
        private bool CheckValidFileHistory(string filePath)
        {
            if (Path.GetExtension(filePath) != ".xml")
            {
                MessageBox.Show("File không hợp lệ");
                return false;
            }

            using (XmlReader xml = XmlReader.Create(filePath))
            {
                if (xml.ReadToFollowing("history"))
                    return true;
                MessageBox.Show("File không đúng định dạng");
                return false;
            }
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
        private List<int> CreateRandomDistinctIndexList(int maxValue, int amount)
        {
            //create List containing random distinct value in [0 ;maxValue) with [amount] length
            //[0 ;8] - 9
            int n = 0;
            Random r = new Random();
            List<int> lstIndex = new List<int>();
            while (n < amount)
            {
                int number = r.Next(0, maxValue);
                if (!lstIndex.Contains(number))
                {
                    lstIndex.Add(number);
                    n++;
                }
            }

            return lstIndex;
        }
        private bool WriteFileHistory()
        {          
            int soLuongCauHoi = int.Parse(txt_SoLuongCauHoi.Value.ToString());
            if (File.Exists(historyFilePath))
            {
                XDocument doc = XDocument.Load(historyFilePath);

                //Check tồn tại mã đề trong history không
                using (XmlReader xmlReader = XmlReader.Create(historyFilePath))
                    while (xmlReader.ReadToFollowing("questions"))
                    {
                        xmlReader.MoveToAttribute("code");
                        if (xmlReader.Value == txt_MaDe.Text)
                        {
                            DialogResult dialogResult = MessageBox.Show($"Đã tồn tại mã đề {txt_MaDe.Text}\nẤn Yes để xoá đề cũ và tiếp tục", "", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                foreach (var item in doc.Descendants("questions"))
                                {
                                    if (item.Attribute("code").Value == txt_MaDe.Text)
                                    {
                                        item.Remove();
                                        break;
                                    }
                                }
                            }
                            else if (dialogResult == DialogResult.No)
                                return false;
                        }
                    }
                //Chèn vào xml file
                XElement questions = new XElement("questions",
                    new XAttribute("date", DateTime.Now.ToString("dd/MM/yyyy")),
                    new XAttribute("code", txt_MaDe.Text)
                    );
                XAttribute attributeSoLuongCauHoi =new XAttribute("questionCount",0);
                
                
                if (cbx_LuaChon.SelectedItem.ToString() == "Ngẫu nhiên")
                {
                    attributeSoLuongCauHoi.Value = soLuongCauHoi.ToString();
                    List<int> lstIndexRandom = CreateRandomDistinctIndexList(lstCauHoi.Count, soLuongCauHoi);
                    lstViTriCauHoiRandom = lstIndexRandom;

                    foreach (var randomIndex in lstViTriCauHoiRandom)
                    {
                        questions.Add(new XElement("question",
                            new XElement("content", lstCauHoi[randomIndex].Content),
                            new XElement("trueanswer", lstCauHoi[randomIndex].TrueAnswer)));
                    }
                }
                else
                {
                    attributeSoLuongCauHoi.Value = lstViTriCauHoiTuChon.Count.ToString();
                    foreach (var index in lstViTriCauHoiTuChon)
                    {
                        questions.Add(new XElement("question",
                            new XElement("content", lstCauHoi[index].Content),
                            new XElement("trueanswer", lstCauHoi[index].TrueAnswer)));
                    }
                }

                questions.Add(attributeSoLuongCauHoi);
                doc.Root.Add(questions);
                doc.Save(historyFilePath, SaveOptions.None);
            }
            else
                using (XmlWriter xml = XmlWriter.Create(historyFilePath, new XmlWriterSettings() { Indent = true }))
                {
                    xml.WriteStartElement("history");
                    xml.WriteStartElement("questions");
                    xml.WriteAttributeString("date", DateTime.Now.ToString("dd/MM/yyyy"));
                    xml.WriteAttributeString("code", txt_MaDe.Text);
                    xml.WriteAttributeString("questionCount", soLuongCauHoi.ToString());

                    if (cbx_LuaChon.SelectedItem.ToString() == "Ngẫu nhiên")
                    {
                        List<int> lstIndexRandom = CreateRandomDistinctIndexList(lstCauHoi.Count, soLuongCauHoi);
                        lstViTriCauHoiRandom = lstIndexRandom;
                        foreach (int randomIndex in lstViTriCauHoiRandom)
                        {
                            xml.WriteStartElement("question");
                            xml.WriteStartElement("content");
                            xml.WriteValue(lstCauHoi[randomIndex].Content);
                            xml.WriteEndElement();
                            xml.WriteStartElement("trueanswer");
                            xml.WriteValue(lstCauHoi[randomIndex].TrueAnswer);
                            xml.WriteEndElement();
                            xml.WriteEndElement();
                        }
                    }
                    else
                    {
                        foreach (int index in lstViTriCauHoiTuChon)
                        {
                            xml.WriteStartElement("question");
                            xml.WriteStartElement("content");
                            xml.WriteValue(lstCauHoi[index].Content);
                            xml.WriteEndElement();
                            xml.WriteStartElement("trueanswer");
                            xml.WriteValue(lstCauHoi[index].TrueAnswer);
                            xml.WriteEndElement();
                            xml.WriteEndElement();
                        }
                    }
                    xml.WriteEndElement();
                    xml.WriteEndElement();
                }
            return true;
        }
        private void WriteFileTest()
        {
            string maDe = txt_MaDe.Text;
            if (!Directory.Exists("questions"))
                Directory.CreateDirectory("questions");
            string fileName = $"questions/dethi-{maDe}.xml";
            string luaChon = cbx_LuaChon.SelectedItem.ToString();
            using (XmlWriter xml = XmlWriter.Create(fileName, new XmlWriterSettings() { Indent = true }))
            {
                xml.WriteStartElement("questions");
                xml.WriteAttributeString("date", DateTime.Now.ToString("dd/MM/yyyy"));
                xml.WriteAttributeString("code", maDe);
                xml.WriteAttributeString("type", "questions");
                if (luaChon == "Ngẫu nhiên")
                {
                    for (int i = 0; i < lstViTriCauHoiRandom.Count; i++)
                    {
                        int indexChon = lstViTriCauHoiRandom[i];
                        xml.WriteStartElement("question");
                        xml.WriteAttributeString("field", lstCauHoi[indexChon].Field);
                        xml.WriteAttributeString("answerCount", lstCauHoi[indexChon].Answers.Count.ToString());
                        xml.WriteStartElement("content");
                        xml.WriteValue(lstCauHoi[indexChon].Content);
                        xml.WriteEndElement();
                        foreach (var answer in lstCauHoi[indexChon].Answers)
                        {
                            xml.WriteStartElement("answer");
                            xml.WriteValue(answer);
                            xml.WriteEndElement();
                        }
                        xml.WriteEndElement();//end for element "question"
                    }
                }
                else
                {
                    for (int i = 0; i < lstViTriCauHoiTuChon.Count; i++)
                    {
                        int indexChon = lstViTriCauHoiTuChon[i];
                        xml.WriteStartElement("question");
                        xml.WriteAttributeString("field", lstCauHoi[indexChon].Field);
                        xml.WriteAttributeString("answerCount", lstCauHoi[indexChon].Answers.Count.ToString());
                        xml.WriteStartElement("content");
                        xml.WriteValue(lstCauHoi[indexChon].Content);
                        xml.WriteEndElement();
                        foreach (var answer in lstCauHoi[indexChon].Answers)
                        {
                            xml.WriteStartElement("answer");
                            xml.WriteValue(answer);
                            xml.WriteEndElement();
                        }
                        xml.WriteEndElement();//end for element "question"
                    }
                }
                xml.WriteEndElement();//end for element "questions"   
            }
        }

        private void SetMaximumValueNumberBox(int value)
        {
            txt_SoLuongCauHoi.Maximum = value;
            lbl_SoLuongToiDa.Text = $"Tối đa {value}";
        }
        private bool CheckValidForm()
        {
            if(xmlQuestionFilePath==null)
            {
                MessageBox.Show("Chưa chọn file ngân hàng câu hỏi");
                return false;
            }
            if (txt_MaDe.Text == "")
            {
                MessageBox.Show("Vui lòng điền mã đề");
                return false;
            }
            if ((lstViTriCauHoiTuChon.Count <= 0 && cbx_LuaChon.SelectedItem.ToString() == "Tự chọn") || (txt_SoLuongCauHoi.Value == 0 && cbx_LuaChon.SelectedItem.ToString() == "Ngẫu nhiên"))
            {
                MessageBox.Show("Số lượng tối thiểu là 1 câu");
                return false;
            }

            return true;
        }
        private void btn_TaoDeThi_Click(object sender, EventArgs e)
        {
            if (!CheckValidForm())
                return;

            if (WriteFileHistory())
            {
                WriteFileTest();
                MessageBox.Show("Tạo đề thi thành công !");
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
                xmlQuestionFilePath = dlg.FileName;
                lbl_ChonFile.Text = Path.GetFileName(xmlQuestionFilePath);
                LoadQuestionFromFileToList(xmlQuestionFilePath);
                FillCheckedListBoxCauHoi();
                SetMaximumValueNumberBox(lstCauHoi.Count);
            }
        }
        private void btn_ChonFileLichSu_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Chon tap tin .xml|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (!CheckValidFileHistory(dlg.FileName))
                    return;
                historyFilePath = dlg.FileName;
                lbl_FileLichSu.Text = Path.GetFileName(historyFilePath);
                
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
