using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace Teamproject1
{
    public partial class graghform : Form // 자식폼 

    {
        public graghform()
        {
            InitializeComponent();
        }
     

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void graghform_Load(object sender, EventArgs e)
        {

        }

        string Text = "#습해요 #더워요 #비약간옴 #여름날씨 #약간선선";
        private void button1_Click(object sender, EventArgs e)
        {
            weathertagbox.Text = Text;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void graphformbutton_Click(object sender, EventArgs e)
        {
            this.Hide();

            mainform mainform1 = new mainform();
            mainform1.Show();

        }
        string text1 = "여행룩?";
        string text2 = "데이트룩?";
        string text3 = "하객룩?";
        private void design1_Click(object sender, EventArgs e)
        {
           
        }

        private void journey_TextChanged(object sender, EventArgs e)
        {
            journey.Text = text1;
        }

        private void date_TextChanged(object sender, EventArgs e)
        {
            date.Text = text2;
        }

        private void wedding_TextChanged(object sender, EventArgs e)
        {
            wedding.Text = text3;
        }
    }
}
