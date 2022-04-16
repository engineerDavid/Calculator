using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcualtor
{
    public partial class Form1 : Form
    {
        //Class level buttons varibles wihc means they are visbale to all fuctions
        //New array of 22 buttons
        Button[] buttons = new Button[18];
        List<String> numbers = new List<String>();
        int OperationCount = 0;
        String expression;
        string expressed = "0";
        string total = "0";
        
        public Form1()
        {
            InitializeComponent();
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;
            buttons[9] = button10;
            buttons[10] = button11;
            buttons[11] = button12;
            buttons[12] = button13;
            buttons[13] = button14;
            buttons[14] = button15;
            buttons[15] = button20;
            buttons[16] = button21;
            buttons[17] = button22;

            //add a common click event to each button

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Click += handlebButtonClick;
                buttons[i].Tag = i;
            }
            
        }

        

        private void handlebButtonClick(object sender, EventArgs e)
        {
            //cast means to convert from object to sender type
            //cast from sender to button
            Button clickedButton = (Button)sender;
            var operations = new[] { "*", "+", "-", "/", "C", "CE", "=" };
            String Sum = "0";

            if (button25.Text == "0" & !operations.Any(clickedButton.Text.Contains))
            {
                button25.Text = clickedButton.Text;
            }

            else if (operations.Any(clickedButton.Text.Contains))
            {
                if (OperationCount == 0)
                {
                    expression = button25.Text + clickedButton.Text;
                    OperationCount = 1;


                }

                else if (clickedButton.Text == "C") {
                    expression = "";
                    button25.Text = "0";
                }
                else if (clickedButton.Text == "CE")
                {
                    
                    button25.Text = "0";
                }
                else if (clickedButton.Text == "=")
                {
                    Calculate(button25.Text, "0");
                    expression = "";
                    
                    
                }
                else
                {

                    Calculate(button25.Text, clickedButton.Text);

                }


            }

            else
            {
                if (OperationCount == 1)
                {
                    button25.Text = null;
                    
                    OperationCount = 2;
                }
                if(expressed == "1"){
                    button25.Text = clickedButton.Text;
                    expressed = "0";


                }
                else
                {
                    button25.Text = button25.Text + clickedButton.Text;
                }
              

            }



        }

        public void Calculate(String Text, String ClickedButtonText)
        {
            expression = expression + Text;
            Console.WriteLine(expression);
            DataTable dt = new DataTable();
            var value = dt.Compute(expression, "");
            Console.WriteLine(value);
            total = value.ToString();
            //OperationCount = 0;
            expressed = "1";
            button25.Text = total;
            expression = button25.Text + ClickedButtonText;
        }
       
        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
