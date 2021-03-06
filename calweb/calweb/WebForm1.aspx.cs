﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using calculatordll2;
using scientificdll;


namespace calweb
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        public static double result_value;
        public static string operation = "";
        public static bool operation_press = false;
        public static string value="";
        public static string button_operaton = "";

        protected void From1()
        {
            this.Button6.Visible = false;
            this.Button26.Visible = false;
            this.Button18.Visible = false;
            this.Button24.Visible = false;
            this.Button25.Visible = false;
            this.Button29.Visible = false;
            this.Button27.Visible = false;
            this.Button28.Visible = false;
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TextBox1.Width = 220;
                this.Button6.Visible = false;
                this.Button26.Visible = false;
                this.Button18.Visible = false;
                this.Button24.Visible = false;
                this.Button25.Visible = false;
                this.Button29.Visible = false;
                this.Button27.Visible = false;
                this.Button28.Visible = false;

            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        protected void Button5_Click(object sender, EventArgs e) // CE
        {
            TextBox1.Text = "0";//clear
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
            result_value = 0;

        }

        protected void button_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "0") || (operation_press == true))
            {
                TextBox1.Text = String.Empty;
            }
            operation_press = false;
            Button b = (Button)sender;
            TextBox1.Text = TextBox1.Text + b.Text;

            /*   if (operation_press == true)
                    TextBox1.Text = "";
                if (TextBox1.Text == "0")
                    TextBox1.Text = String.Empty;

                operation_press = false;
                Button b = (Button)sender;
                TextBox1.Text = TextBox1.Text + b.Text;  */

        }

        protected void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text; //op
            value = TextBox1.Text;  //a
            operation_press = true;


        }


        protected void Button17_Click(object sender, EventArgs e) //equal button
        {
             Class1 ob1 = new Class1();
             Class2 ob2 = new Class2();
             result_value = Convert.ToDouble(value);
                 switch (operation)
                 {

                    

                     case "+":
                             Double add1 = Double.Parse(TextBox1.Text);
                             Double adition = ob1.add(result_value, add1);
                             TextBox1.Text = Convert.ToString(adition);

                             break;
                        

                     
                     case "-":

                             Double sub1 = Double.Parse(TextBox1.Text);
                             Double summation = ob1.sub(result_value, sub1);

                             TextBox1.Text = Convert.ToString(summation);

                             break;
                        
                            
                     case "*":
                         Double mul1 = Double.Parse(TextBox1.Text);
                         Double multi = ob1.multiplication(result_value, mul1);

                         TextBox1.Text = Convert.ToString(multi); 
                             
                          break;
                        
                             
                     case "/":
                        
                                Double div1 = Double.Parse(TextBox1.Text);
                                Double div = ob1.division(result_value, div1);
                                TextBox1.Text = Convert.ToString(div);
                                break;

                     case "√":
                            Double squre = Double.Parse(TextBox1.Text);
                            Double sqr = ob1.sqrt(result_value);
                            TextBox1.Text = Convert.ToString(sqr);
                            break;
                       
                             

                     case "%":
                            //Double c4 = Convert.ToDouble(TextBox1.Text);
                            Double per = ob2.percentage(result_value);
                            TextBox1.Text = Convert.ToString(per);
                            break;
                           
                           
                     case "1/x":
                             Double in1 = ob2.invert(result_value);
                            TextBox1.Text = Convert.ToString(in1);
                            break;
                            
                           
                     case "sin":
                             Double sin1 = ob2.sin_s(result_value);
                               TextBox1.Text = Convert.ToString(sin1);
                               break;

                     

                     case "cos":

                              Double cos1 = ob2.cosine(result_value);

                             TextBox1.Text = Convert.ToString(cos1);

                             break;

                     case "tan":

                                Double tan1 = ob2.tangent(result_value);
                                TextBox1.Text = Convert.ToString(tan1);
                                break;

                     case "ln":

                             Double ln1 = ob2.nlogarithm(result_value);
                             TextBox1.Text = Convert.ToString(ln1);
                             break;

                     case "log":

                             Double log1 = ob2.logarithm(result_value);

                            TextBox1.Text = Convert.ToString(log1);

                            break;
                     case "^":

                            Double pw1 = Double.Parse(TextBox1.Text);
                            Double pw = ob2.power(result_value, pw1);

                            TextBox1.Text = Convert.ToString(pw);

                            break;

                        
                     default: break;
                

                 }
                 operation_press = false;

        }

        protected void Button30_Click(object sender, EventArgs e)
        {
            this.Button6.Visible = false;
            this.Button26.Visible = false;
            this.Button18.Visible = false;
            this.Button24.Visible = false;
            this.Button25.Visible = false;
            this.Button29.Visible = false;
            this.Button27.Visible = false;
            this.Button28.Visible = false;
        }



        protected void Button23_Click(object sender, EventArgs e)
        {
            this.Button6.Visible = true;
            this.Button26.Visible = true;
            this.Button18.Visible = true;
            this.Button24.Visible = true;
            this.Button25.Visible = true;
            this.Button29.Visible = true;
            this.Button27.Visible = true;
            this.Button28.Visible = true;
        }



        }

       
  }
