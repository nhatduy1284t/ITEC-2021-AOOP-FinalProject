using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ModuleSoanDe
{
    
    public partial class frmMain : Form
    {
        public frmMain()
        {     
            InitializeComponent();
        }

        private void DisplayPage(string page)
        {
            switch (page)
            {
                case Page.SOAN_CAU_HOI:
                    {

                        DisplayForm(new frmSoanCauHoi());
                    }    
                    break;
                case Page.TAO_DE_THI:
                    {
                        DisplayForm(new frmTaoDeThi());
                    }
                    break;
                case Page.CHAM_BAI:
                    {
                        DisplayForm(new frmChamBai());
                    }
                    break;           
            }
        }
        private void DisplayForm(Form f)
        {
            this.Visible = false;
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
            this.Visible = true;
        }
      
        private void btn_ChamBai_Click(object sender, EventArgs e)
        {
            DisplayPage(Page.CHAM_BAI);
        }

        private void btn_SoanCauHoi_Click(object sender, EventArgs e)
        {
            DisplayPage(Page.SOAN_CAU_HOI);
        }
        private void btn_TaoBaiThi_Click(object sender, EventArgs e)
        {
            DisplayPage(Page.TAO_DE_THI);
        }
    }
}
