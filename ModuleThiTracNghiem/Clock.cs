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
    public partial class Clock : UserControl
    {
        public int _ss;
        public int _mm;
        public delegate void Clock_TimeUpHandle();
        public event Clock_TimeUpHandle Clock_TimeUp;
        public int ss
        {
            get
            {
                return _ss;
            }
            set
            {
                _ss = value;
                lbl_CountDown.Text = value.ToString();
            }
        }
        public int mm {
            get
            {
                return _mm;
            }
            set
            {
                _mm = value;
                lbl_CountDown.Text = value.ToString();
            }
        }
        public Clock()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ss--;
            if (ss < 0)
            {
                ss = 59;
                mm--;
            }
            UpdateText();
            if (ss == 0 && mm == 0)
            {
                timer1.Enabled = false;
                Clock_TimeUp();
            }
            
        }
        
        public void SetTimeCountDown(int seconds)
        {
            
            ss = seconds % 60;
            mm = seconds / 60;
            //MessageBox.Show($"ss ne {ss} mm ne{mm}");
            
            timer1.Enabled = true;
        }
        public void Start()
        {
            timer1.Enabled = true;
        }
        public void Stop()
        {
            timer1.Enabled = false;
            mm = ss = 0;
        }
        void UpdateText()
        {
            lbl_CountDown.Text = $"{mm} : {ss}";
        }
    }
}
