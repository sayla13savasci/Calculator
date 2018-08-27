using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculatordll2;
using scientificdll;

namespace calculator2
{
    public partial class Form1 : Form
    {
        double a, b;
        double result_value = 0;
        string operation = "";
        bool operation_press= false;

        public Form1()
        {
            InitializeComponent();

            s_sin.Visible = false;
            s_cos.Visible = false;
            s_tan.Visible = false;
            s_log.Visible = false;
            s_percentage.Visible = false;
            s_power.Visible = false;
            s_invert.Visible = false;
            s_ln.Visible = false;
            textBox1.Size = new System.Drawing.Size(250, 31);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        } 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e) //numeric buttons 0 to 9
        {
            if  ((textBox1.Text == "0")||(operation_press==true))
            {
                textBox1.Clear();
            }

            operation_press = false;

            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {


        }

        private void Operator_Click(object sender, EventArgs e) //operator buttons
        {
            Button b = (Button)sender;
            operation = b.Text;
            result_value = Double.Parse(textBox1.Text);
            operation_press = true;

        }

        private void button15_Click(object sender, EventArgs e) // equal button
        {
            Class1 ob1 = new Class1();//normal calculator 
            Class2 ob2 = new Class2();//scientific calculator 

            switch (operation)
            {

                case "+":
                    Double add1 = Double.Parse(textBox1.Text);
                    Double adition = ob1.add(result_value,add1);
                    textBox1.Text = Convert.ToString(adition);
                   
                    break;

                case "-":

                    Double sub1 = Double.Parse(textBox1.Text);
                    Double summation = ob1.sub(result_value, sub1);

                    textBox1.Text = Convert.ToString(summation);

                    break;

                case "*":

                    Double mul1 = Double.Parse(textBox1.Text);
                    Double multi = ob1.multiplication(result_value, mul1);

                    textBox1.Text = Convert.ToString(multi);
                    break;


                case "/":
                    Double div1 = Double.Parse(textBox1.Text);
                    Double div = ob1.division(result_value, div1);
                    textBox1.Text = Convert.ToString(div);
                    break;

                case "√":
                    Double squre = Double.Parse(textBox1.Text);
                    Double sqr = ob1.sqrt(result_value);
                    textBox1.Text = Convert.ToString(sqr);
                    break;

                case "%":

                    //Double c4 = Convert.ToDouble(TextBox1.Text);
                    Double per = ob2.percentage(result_value);
                    textBox1.Text = Convert.ToString(per);
                    break;

                case "^":

                    Double pw1 = Double.Parse(textBox1.Text);
                    Double pw = ob2.power(result_value, pw1);

                    textBox1.Text = Convert.ToString(pw);

                    break;

                case "1/x":
                    Double in1 = ob2.invert(result_value);
                    textBox1.Text = Convert.ToString(in1);
                    break;

                case "sin":
                    
                    Double sin1 = ob2.sin_s(result_value);

                    textBox1.Text = Convert.ToString(sin1);

                    break;

                case "cos":

                    Double cos1 = ob2.cosine(result_value);

                    textBox1.Text = Convert.ToString(cos1);

                    break;

                case "tan":

                    Double tan1 = ob2.tangent(result_value);

                    textBox1.Text = Convert.ToString(tan1);

                    break;

                case "ln":

                    Double ln1 = ob2.nlogarithm(result_value);

                    textBox1.Text = Convert.ToString(ln1);

                    break;

                case "log":

                    Double log1 = ob2.logarithm(result_value);

                    textBox1.Text = Convert.ToString(log1);

                    break;

                default:
                    break;

            }
            operation_press = false;

 
        }

        private void button5_Click(object sender, EventArgs e)  //CE or clear button
        {
            textBox1.Text ="0";
        }

       

       private void button10_Click(object sender, EventArgs e)  ///c button
        {
            textBox1.Clear();
           result_value = 0;
        }

       private void Form1_Click(object sender, EventArgs e)
       {

       }

       private void textBox1_Click(object sender, EventArgs e)
       {

       }

       private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
       {
           if (comboBox1.SelectedIndex == 0)
           {
               textBox1.Size = new System.Drawing.Size(260, 31);
               
               
               s_sin.Visible = false;
               s_cos.Visible = false;
               s_tan.Visible = false;
               s_log.Visible = false;
               s_percentage.Visible = false;
               s_power.Visible = false;
               s_invert.Visible = false;
               s_ln.Visible = false;
           }

           if (comboBox1.SelectedIndex == 1)
           {
               textBox1.Size = new System.Drawing.Size(350, 31);
               s_sin.Visible = true;
               s_cos.Visible = true;
               s_tan.Visible = true;
               s_log.Visible = true;
               s_percentage.Visible = true;
               s_power.Visible = true;
               s_invert.Visible = true;
               s_ln.Visible = true;
           }


       }

    
      

     
        
    }
}
