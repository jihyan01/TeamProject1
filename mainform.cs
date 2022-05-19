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

namespace Teamproject1
{
    public partial class mainform : Form
    {    

        
        public mainform()
        {
            InitializeComponent();
        }

        private void gobutton_Click(object sender, EventArgs e)
        {
            this.Hide();

            graghform graphform = new graghform();
            graphform.Show();
            
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            this.Hide();

            loginform loginform1 = new loginform();
            loginform1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            profileform profileform1 = new profileform();
            profileform1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            showfashionform showfashionform1 = new showfashionform();
            showfashionform1.Show();
        }
    }
}
