using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuleThiTracNghiem
{
    public partial class QuestionControl : UserControl
    {
        public string Content
        {
            get
            {
                return lbl_content.Text;
            }
            set
            {
                lbl_content.MaximumSize = new Size(this.Size.Width, this.Height);
                lbl_content.Text = value;
            }
        }
        public List<RadioButton> rdAnswers = new List<RadioButton>();
        public List<Label> lblAnswers = new List<Label>();
        public CheckBox cbNotice = new CheckBox();
        public QuestionControl()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top;
            
        }

 
        public void SetSizeToParentSize()
        {
            this.Size = new Size(Parent.Size.Width, this.Parent.Height * 70 / 100);
        }
        private void SetLocationRdAnswers()
        {
            //Hàm để set location radiobutton (phải có location của lblAnswers)
            for (int i = 0; i < rdAnswers.Count; i++)
            {                     
                Controls.Add(rdAnswers[i]);
                rdAnswers[i].Location = new Point(lbl_content.Location.X, lblAnswers[i].Location.Y-2);
                rdAnswers[i].AutoSize = false;
                rdAnswers[i].MaximumSize= new Size(16,this.Height+400);
             
      
            }
            SetLocationCheckBoxNotice();
        }
        public void SetLocationLblAnswers()
        {
            int locationYBelowContent = lbl_content.Location.Y + lbl_content.Height;
            for (int i = 0; i < lblAnswers.Count; i++)
            {               
                Controls.Add(lblAnswers[i]);
                lblAnswers[i].Location = new Point(lbl_content.Location.X+16, locationYBelowContent + 40 * (i + 1));
                lblAnswers[i].AutoSize = true;
                lblAnswers[i].MaximumSize = new Size(this.Width, 0);
                lblAnswers[i].Click += new EventHandler(lblAnswer_Click);
                locationYBelowContent += lblAnswers[i].Height;
            }
            SetLocationRdAnswers();
            SetLocationCheckBoxNotice();
        }
        private void SetLocationCheckBoxNotice()
        {
            int lowestLocationY = lblAnswers[lblAnswers.Count - 1].Location.Y;
            cbNotice.Location = new Point(lbl_content.Location.X, lowestLocationY + 60);
            cbNotice.AutoSize = true;
            cbNotice.Text = "Đánh dấu lưu ý";
            Controls.Add(cbNotice);
        }
        public bool IsDone()
        {
            foreach (var ans in rdAnswers)
            {
                if (ans.Checked)
                    return true;
            }
            return false;
        }
        public string GetSelectedAnswer()
        {
            foreach (var ans in rdAnswers)
            {
                if(ans.Checked)
                    return ans.Text;
            }
            return "";
        }
        private void lblAnswer_Click(object sender, EventArgs e)
        {
            //Label clicked -> Radiobutton clicked
            Label lblClick = (Label)sender;
            for (int i = 0; i < lblAnswers.Count; i++)
            {
                if(lblClick.Text==lblAnswers[i].Text)
                {
                    rdAnswers[i].Checked = !rdAnswers[i].Checked;
                }
            }
        }
    }
}
