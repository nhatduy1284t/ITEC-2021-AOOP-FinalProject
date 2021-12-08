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
using ModuleSoanDe.Class;
namespace ModuleSoanDe
{
    public partial class frmChamBai : Form
    {
        public frmChamBai()
        {
            InitializeComponent();
            Page_Load();
        }

        string historyFilePath;
        List<Questions> lstQuestions = new List<Questions>();//Đáp án đề thi
        List<Test> lstTest = new List<Test>();//Bài làm

       

        private void Page_Load()
        {
            this.Dock = DockStyle.Fill;
        }
        private void LoadListQuestions()
        {
            using (XmlReader xml = XmlReader.Create(historyFilePath))
            {
                xml.ReadToFollowing("history");
                while (xml.ReadToFollowing("questions"))
                {
                    Questions qs = new Questions();
                    xml.MoveToAttribute("date");
                    qs.Date = xml.Value;
                    xml.MoveToAttribute("code");
                    qs.Code = xml.Value;
                    xml.MoveToAttribute("questionCount");
                    qs.QuestionCount = int.Parse(xml.Value);
                    for (int i = 0; i < qs.QuestionCount; i++)
                    {

                        xml.ReadToFollowing("question");
                        Question q = new Question();
                        xml.ReadToFollowing("content");
                        q.Content = xml.ReadElementContentAsString();
                        xml.ReadToFollowing("trueanswer");
                        q.TrueAnswer = xml.ReadElementContentAsString();
                        qs.lstQuestion.Add(q);
                    }
                    lstQuestions.Add(qs);
                }
            }

        }

        private void LoadListTest(string xmlFilePath)
        {
            //Load file bài làm và đưa vào list test
            using (XmlReader xml = XmlReader.Create(xmlFilePath))
            {
                Test t = new Test();
                xml.ReadToFollowing("test");
                xml.MoveToAttribute("code");
                t.Code = xml.Value;
                xml.MoveToAttribute("date");
                t.Date = xml.Value;
                xml.ReadToFollowing("employeeinfo");
                xml.ReadToFollowing("name");
                t.Name = xml.ReadElementContentAsString();
                xml.ReadToFollowing("id");
                t.Id = xml.ReadElementContentAsString();
                while (xml.ReadToFollowing("answer"))
                {
                    string answer = xml.ReadElementContentAsString();
                    t.lstAnswer.Add(answer);
                }
                lstTest.Add(t);

            }
        }
        private void MarkTest()
        {
            foreach (var qs in lstQuestions)//đáp án
            {
                foreach (var t in lstTest)//bài thi
                {
                    if (qs.Date == t.Date && qs.Code == t.Code)
                    {
                        for (int i = 0; i < t.lstAnswer.Count; i++)
                        {
                            //So Sánh câu trả lời đúng của đề với câu trả lời của bài thi
                            if (qs.lstQuestion[i].TrueAnswer == t.lstAnswer[i])
                                t.NumberOfTrueAnswer++;
                        }
                        t.Score = (t.NumberOfTrueAnswer * 10) / t.lstAnswer.Count;
                    }
                }
            }
        }
        private void btn_DocFileBaiLam_Click(object sender, EventArgs e)
        {
            //Mở hộp thoại select file
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "Chon tap tin .xml|*.xml";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in dlg.FileNames)
                {
                    LoadListTest(file);
                    lbx_Test.Items.Add(Path.GetFileName(file));
                }
            }
        }


        private void btn_ChamBai_Click(object sender, EventArgs e)
        {
            if (historyFilePath == null)
            {
                MessageBox.Show("Hãy chọn file đáp án");
                return;
            }
            if (lstTest.Count == 0)
            {
                MessageBox.Show("Hãy chọn ít nhất 1 bài để chấm !");
                return;
            }

            MarkTest();
            lstTest.Sort(new DateDescendingComparer());
            lstTest.Sort(new ScoreDescendingComparer());
            using (var sw = new StreamWriter("result.txt"))
            {
                string date = "";
                foreach (var t in lstTest)
                {
                    if (t.Date != date)
                    {
                        date = t.Date;
                        sw.WriteLine($"{date}");
                    }
                    sw.WriteLine($"{t.Code} - {t.Id} - {t.Name} - {t.Score}");
                }
            }
        }

        private void btn_ChonFileDapAn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Filter = "Chon tap tin .xml|*.xml";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                historyFilePath = dlg.FileName;
                lbl_FileDapAn.Text = Path.GetFileName(historyFilePath);
                LoadListQuestions();//Load đáp án đề thi
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
