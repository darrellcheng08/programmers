using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinufuPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_SlideMe_Click(object sender, EventArgs e)
        {
            if(sidemenu.Width == 40)
            {

                sidemenu.Visible = false;
                sidemenu.Width = 195;
                PanelAnimator.ShowSync(sidemenu);
                
            }
            else
            {
                sidemenu.Visible = false;
                sidemenu.Width = 40;
                PanelAnimator.ShowSync(sidemenu);
            }
        }
    }
}
