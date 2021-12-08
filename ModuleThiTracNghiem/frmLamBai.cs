using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ModuleThiTracNghiem
{
    public partial class frmLamBai : Form
    {
        public string name;
        public string id;
        string date;
        string maDe = "";
        List<QuestionControl> questionControlList = new List<QuestionControl>();
        List<string> listSelectedAnswers = new List<string>();
        List<int> lstIndexNotice = new List<int>();
        int timePerQues = 15;
        int indexCurrentQuestion = 0;

        public frmLamBai(string xmlFilePath)
        {
            this.Dock = DockStyle.Fill;
            this.Anchor = AnchorStyles.Top;
            InitializeComponent();

            //Cài đặt sự kiện time up
            clock.Clock_TimeUp += new Clock.Clock_TimeUpHandle(ClockTimeUp);

            //Load danh sách control câu hỏi từ xml file câu hỏi
            using (var xml = XmlReader.Create(xmlFilePath))
            {
                xml.ReadToFollowing("questions");
                xml.MoveToAttribute("code");
                maDe = xml.Value;
                xml.MoveToAttribute("date");
                date = xml.Value;
                while (xml.ReadToFollowing("question"))
                {
                    QuestionControl qc = new QuestionControl();
                    xml.MoveToAttribute("answerCount");

                    int amountOfAnswers = int.Parse(xml.Value);
                    xml.ReadToFollowing("content");
                    qc.Content = xml.ReadElementContentAsString();

                    for (int i = 0; i < amountOfAnswers; i++)
                    {
                        xml.ReadToFollowing("answer");
                        RadioButton rdAnswer = new RadioButton();
                        Label lblAnswer = new Label();
                        rdAnswer.Text = xml.ReadElementContentAsString();                   
                        lblAnswer.Text = rdAnswer.Text;
                        qc.lblAnswers.Add(lblAnswer);
                        qc.rdAnswers.Add(rdAnswer);
                    }
                    //Khi có label trong lbAnswers thì mới set được location
                    qc.SetLocationLblAnswers();
                    questionControlList.Add(qc);

                }
                clock.SetTimeCountDown(questionControlList.Count * timePerQues);
            }
            DisplayQuestion(0);
        }
        private void ClockTimeUp()
        {
            MessageBox.Show("Bạn đã hết thời gian làm bài!");
            listSelectedAnswers = GetListSelectedAnswers();
            List<int> listIndexOfUnselectedAnswers = new List<int>();
            if (listIndexOfUnselectedAnswers.Count > 0)
            {
                for (int i = 0; i < listIndexOfUnselectedAnswers.Count; i++)
                {
                    int index = listIndexOfUnselectedAnswers[i];
                    listSelectedAnswers.Insert(index, "");
                }
            }
            WriteFileTest();
        }
        private void DisplayQuestion(int number)
        {
            this.Controls.Remove(questionControlList[indexCurrentQuestion]);
            this.Controls.Add(questionControlList[number]);
            questionControlList[number].SetSizeToParentSize();
            indexCurrentQuestion = number;
            this.lbl_Page.Text = $"{indexCurrentQuestion + 1}/{questionControlList.Count}";

        }

        private void btn_MoveRight_Click(object sender, EventArgs e)
        {
            if (indexCurrentQuestion < questionControlList.Count - 1)
            {
                DisplayQuestion(indexCurrentQuestion + 1);
            }
        }

        private void btn_MoveLeft_Click(object sender, EventArgs e)
        {
            if (indexCurrentQuestion > 0)
            {
                DisplayQuestion(indexCurrentQuestion - 1);
            }

        }
        private List<string> GetListSelectedAnswers()
        {
            List<string> listAnswers = new List<string>();

            foreach (var qc in questionControlList)
            {
                if (qc.IsDone())
                {
                    string selectedAnswer = qc.GetSelectedAnswer();
                    listAnswers.Add(selectedAnswer);
                }
                else
                {
                    listAnswers.Add("");
                }
            }
            return listAnswers;
        }

        private void WriteFileTest()
        {
            using (XmlWriter xml = XmlWriter.Create($"bainop-{id}.xml", new XmlWriterSettings() { Indent = true }))
            {
                xml.WriteStartElement("test");
                xml.WriteAttributeString("code", maDe);
                xml.WriteAttributeString("date", date);
                xml.WriteStartElement("employeeinfo");
                xml.WriteStartElement("name");
                xml.WriteValue(name);
                xml.WriteEndElement();
                xml.WriteStartElement("id");
                xml.WriteValue(id);
                xml.WriteEndElement();
                xml.WriteEndElement();

                foreach (var answer in listSelectedAnswers)
                {
                    xml.WriteStartElement("answer");
                    xml.WriteValue(answer);
                    xml.WriteEndElement();
                }
                xml.WriteEndElement();
            }
            Controls.Clear();
            MessageBox.Show("Hoan thanh!");
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            listSelectedAnswers = GetListSelectedAnswers();
            List<int> listIndexOfUnselectedAnswers = new List<int>();
            for (int i = 0; i < listSelectedAnswers.Count; i++)
            {
                if (listSelectedAnswers[i] == "")
                    listIndexOfUnselectedAnswers.Add(i);
            }
            if (listIndexOfUnselectedAnswers.Count > 0)
            {
                string alert = "";
                foreach (var i in listIndexOfUnselectedAnswers)
                {
                    alert += (i + 1).ToString() + ", ";
                }
                alert = alert.Remove(alert.Length - 2, 2);
                DialogResult dialogResult = MessageBox.Show($"Chưa hoàn thành câu số {alert}", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    WriteFileTest();
                    return;
                }
                else
                    return;
            }
            WriteFileTest();
        }
        private void FillListIndexNotice()
        {

            lstIndexNotice.Clear();
            for (int i = 0; i < questionControlList.Count; i++)
            {
                if (questionControlList[i].cbNotice.Checked)
                    lstIndexNotice.Add(i + 1);
            }
        }

        private void btn_XemCauDanhDau_Click(object sender, EventArgs e)
        {
            FillListIndexNotice();
            string alert = "";
            for (int i = 0; i < lstIndexNotice.Count; i++)
            {
                alert += lstIndexNotice[i] + ", ";
            }
            if (alert != "")
            {
                MessageBox.Show($"Những câu hỏi đã đánh dấu: {alert.Remove(alert.Length - 2, 2)}");
            }
            else
            {
                MessageBox.Show("Bạn không đánh dấu câu hỏi nào");
            }
        }
    }

}
