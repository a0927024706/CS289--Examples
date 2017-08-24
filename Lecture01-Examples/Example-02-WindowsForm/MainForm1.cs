using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_02_WindowsForm
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void starButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = string.Format("神奇寶貝名稱:{0} , 屬性:{1}, 身高:{2},體重:{3}", nameTextBox.Text, typeTextBox.Text, highTextBox.Text, weightTextBox.Text);
            MessageBox.Show("已成功登入"+ nameTextBox.Text);
            //MessageBox.Show("Hello " + nameTextBox.Text);
           
        }

        private void messageLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void MainForm1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void MainForm1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
