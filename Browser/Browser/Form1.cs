using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            webBrowser1.Navigate("https://www.google.com/");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button4_Click_1(object sender, EventArgs e) {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e) {
            webBrowser1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e) {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e) {
            webBrowser1.GoForward();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)ConsoleKey.Enter) {
                webBrowser1.Navigate(textBox1.Text);
            }
        }
    }
}
