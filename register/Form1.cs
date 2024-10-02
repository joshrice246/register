using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace register
{
    public partial class Form1 : Form
    {
        double redactedbox1;

        double redactedbox2;

        double redactedbox3;


        double subtotal;

        double taxx;

        double totalmoney;

        double tendered;

        double changee;






        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void b_Click(object sender, EventArgs e)
        {
            try
            {


                redactedbox1 = Convert.ToDouble(input1.Text);
                redactedbox2 = Convert.ToDouble(input2.Text);
                redactedbox3 = Convert.ToDouble(input3.Text);

                subtotal = (redactedbox1 * 5.48) + (redactedbox2 * 6.90) + (redactedbox3 * 20.50);
                taxx = subtotal * 0.13;
                totalmoney = subtotal + taxx;


                subtotallabel.Text = $"{subtotal.ToString("C")}";
                taxlabel.Text = $"{taxx.ToString("C")}";
                totallabel.Text = $"{totalmoney.ToString("C")}";


            }
            catch
            {


                subtotallabel.Text = $"error";
                taxlabel.Text = $"error";
                totallabel.Text = $"error";

            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToDouble(input9.Text);

                changee = tendered - totalmoney;

                changelabel.Text = $"{changee.ToString("C")}";
            }
            catch
            {
                changelabel.Text = $"error";
               
            }




        }

        private void recipt_Click(object sender, EventArgs e)
        {
           
        }

        private void printt_Click(object sender, EventArgs e)
        {
            recipt.Text += $"\nthank you for shopping";
            Refresh();
            Thread.Sleep(400);
            recipt.Text += $"\n------------------------";
            Refresh();
            Thread.Sleep(400);
            recipt.Text += $"\nsubtotal:  {subtotal}";
            Refresh();
            Thread.Sleep(400);
            recipt.Text += $"\nTax:      {taxx}";
            Refresh();
            Thread.Sleep(400);
            recipt.Text += $"\nTotal Amount: {totalmoney}";
            Refresh();
            recipt.Text += $"\n------------------------";
            Refresh();
            Thread.Sleep(400);
            Thread.Sleep(400);
            recipt.Text += $"\nTendered: {tendered}";
            Refresh();
            Thread.Sleep(400);
            recipt.Text += $"\nChange: {changee}";
            Refresh();
            Thread.Sleep(400);
            recipt.Text += $"\n------------------------";
            Refresh();
            Thread.Sleep(400);
            recipt.Text += $"\nhave a good day";
            Refresh();
            Thread.Sleep(400);
            Refresh();
            Thread.Sleep(400);
            recipt.Text += $"\nloyal customer.";
            Refresh();
            Thread.Sleep(400);
            recipt.Text += $"\n------------------------";

        }
    }
    }
