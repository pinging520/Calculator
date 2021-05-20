using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機
{
    public partial class Form1 : Form
    {
        bool rule = true; //判斷階段
        bool rule2 = true; //等於後二接測試
        int method =0; //判斷運算符號

        string a;
       
        int[] nu = new int[] {0,0};

        public Form1()
        {
            

            InitializeComponent();
            
            textBox1.Text = "0";


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void math_equal_Click(object sender, EventArgs e)
        {
            if(rule == false && rule2 ==true)
            {
                nu[1] = nu[0];
               
            }
            if (rule == true && rule2 == true)
            { 
                nu[1] = Convert.ToInt32(textBox1.Text);
            }
            rule2 = false;

            switch (method)
            {
                case 1:

                    nu[0] = nu[0] + nu[1];
                    textBox1.Text = Convert.ToString(nu[0]);
                    break;
                case 2:

                    nu[0] = nu[0] - nu[1];
                    textBox1.Text = Convert.ToString(nu[0]);
                    break;
                case 3:

                    nu[0] = nu[0] * nu[1];
                    textBox1.Text = Convert.ToString(nu[0]);
                    break;
                case 4:

                    nu[0] = nu[0] / nu[1];
                    textBox1.Text = Convert.ToString(nu[0]);
                    break;

            }
            rule = false;
            
        }

        

        private void math_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        //----------------------------------------------------------------------------
        private void math_plus_Click(object sender, EventArgs e)
        {
            if(rule == true || rule2 == false)
            {
                
                    nu[0] = Convert.ToInt32(textBox1.Text);
                    rule2 = true;
                
            }
            method = 1;
            rule = false;
            if(rule == false)
            {
                Button b = (Button)sender;
                a = nu[0] + b.Text;
                textBox1.Text = a;
            }
        }

        private void math_less_Click(object sender, EventArgs e)
        {
            if (rule == true || rule2 == false)
            {
                nu[0] = Convert.ToInt32(textBox1.Text);
                rule2 = true;
            }
            method = 2;
            rule = false;
            if (rule == false)
            {
                Button b = (Button)sender;
                a = nu[0] + b.Text;
                textBox1.Text = a;
            }
        }

        private void math_multiply_Click(object sender, EventArgs e)
        {
            if (rule == true || rule2 == false)
            {
                nu[0] = Convert.ToInt32(textBox1.Text);
                rule2 = true;
            }
            method = 3;
            rule = false;
            if (rule == false)
            {
                Button b = (Button)sender;
                a = nu[0] + b.Text;
                textBox1.Text = a;
            }
        }

        private void math_except_Click(object sender, EventArgs e)
        {
            if (rule == true || rule2 == false)
            {
                nu[0] = Convert.ToInt32(textBox1.Text);
                rule2 = true;
            }
            method = 4;
            rule = false;
            if (rule == false)
            {
                Button b = (Button)sender;
                a = nu[0] + b.Text;
                textBox1.Text = a;
            }
        }

        //-----------------------------------------------------------

        private void number_1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0"|| rule == false) {  textBox1.Clear(); }
            if (rule2 == false) { method = 0; rule2 = true; }
            

            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
            rule = true;
        }

        private void number_2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" || rule == false) { textBox1.Clear(); }
            if (rule2 == false) { method = 0; rule2 = true; }
            Button number = (Button)sender;
            textBox1.Text = textBox1.Text + number.Text;
            rule = true;
        }
        private void number_3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || rule == false) { textBox1.Clear(); }
            if (rule2 == false) { method = 0; rule2 = true; }
            Button number = (Button)sender;
            textBox1.Text = textBox1.Text + number.Text;
            rule = true;
        }
        private void number_4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || rule == false) { textBox1.Clear(); }
            if (rule2 == false) { method = 0; rule2 = true; }
            Button number = (Button)sender;
            textBox1.Text = textBox1.Text + number.Text;
            rule = true;
        }
        private void number_5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || rule == false) { textBox1.Clear(); }
            if (rule2 == false) { method = 0; rule2 = true; }
            Button number = (Button)sender;
            textBox1.Text = textBox1.Text + number.Text;
            rule = true;
        }
        private void number_6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || rule == false) { textBox1.Clear(); }
            if (rule2 == false) { method = 0; rule2 = true; }
            Button number = (Button)sender;
            textBox1.Text = textBox1.Text + number.Text;
            rule = true;
        }
        private void number_7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || rule == false) { textBox1.Clear(); }
            if (rule2 == false) { method = 0; rule2 = true; }
            Button number = (Button)sender;
            textBox1.Text = textBox1.Text + number.Text;
            rule = true;
        }
        private void number_8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || rule == false) { textBox1.Clear(); }
            if (rule2 == false) { method = 0; rule2 = true; }
            Button number = (Button)sender;
            textBox1.Text = textBox1.Text + number.Text;
            rule = true;
        }
        private void number_9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || rule == false) { textBox1.Clear(); }
            if (rule2 == false) { method = 0; rule2 = true; }
            Button number = (Button)sender;
            textBox1.Text = textBox1.Text + number.Text;
            rule = true;
        }

        private void number_0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || rule == false) { textBox1.Clear(); }
            if (rule2 == false) { method = 0; rule2 = true; }
            Button number = (Button)sender;
            textBox1.Text = textBox1.Text + number.Text;
            rule = true;
        }

        private void math_back_Click(object sender, EventArgs e)
        {
           textBox1.Text = Calculation.Back(textBox1.Text);

        }

        

        
    }
}
