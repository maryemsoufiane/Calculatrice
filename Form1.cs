using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN1(object sender, EventArgs e)
        {

        }

        private void BTN2(object sender, EventArgs e)
        {

        }

        private void BTN3(object sender, EventArgs e)
        {

        }

        private void BTN4(object sender, EventArgs e)
        {

        }

        private void BTN5(object sender, EventArgs e)
        {

        }

        private void BTN7(object sender, EventArgs e)
        {

        }

        private void BTN8(object sender, EventArgs e)
        {

        }

        private void BTN9(object sender, EventArgs e)
        {
            Button chiffre = (Button)sender;
            Result.Text += chiffre.Text;
        }

        private void BTN10(object sender, EventArgs e)
        {
            Button num1 = (Button)sender;
            Result.Text += num1.Text;
        }

        private void BTN11(object sender, EventArgs e)
        {
            Button num2= (Button)sender;
            Result.Text += num2.Text;
        }

        private void BTN12(object sender, EventArgs e)
        {

        }

        private void BTN13(object sender, EventArgs e)
        {
            Button num3= (Button)sender;
            Result.Text += num3.Text;
        }

        private void BTN14(object sender, EventArgs e)
        {
            Button num4 = (Button)sender;
            Result.Text += num3.Text;
        }

        private void BTN15(object sender, EventArgs e)
        {
            Button num5 = (Button)sender;
            Result.Text += num5.Text;
        }

        private void BTN16(object sender, EventArgs e)
        {

        }

        private void BTN17(object sender, EventArgs e)
        {
            Button num6 = (Button)sender;
            Result.Text += num6.Text;
        }

        private void BTN18(object sender, EventArgs e)
        {
            Button num7 = (Button)sender;
            Result.Text += num7.Text;
        }

        private void BTN19(object sender, EventArgs e)
        {
            Button num8 = (Button)sender;
            Result.Text += num8.Text;
        }

        private void BTN20(object sender, EventArgs e)
        {
            Button num9 = (Button)sender;
            Result.Text += num9.Text;
        }

        private void BTN21(object sender, EventArgs e)
        {

        }

        private void BTN6(object sender, EventArgs e)
        {

        }
    }
}
