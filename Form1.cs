using System;
using System.Windows.Forms;

namespace zad1
{
    public partial class Form1 : Form
    {
        int flag1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 11 && textBox2.Text.Length < 3 && textBox3.Text.Length < 3 && textBox4.Text.Length == 4)
            {

                if (checkBox1.Checked || checkBox2.Checked)
                {
                    if (checkBox1.Checked && int.Parse(textBox1.Text.Substring(9, 1)) % 2 == 0)
                    {
                        int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };
                        int sum = 0;
                        for (int i = 0; i < 11; i++)
                        {
                            sum += int.Parse(textBox1.Text.Substring(i, 1)) * weights[i];

                        }
                        button1.Text = sum.ToString();
                        if (sum % 10 == 0)
                        {
                            int year2 = int.Parse(textBox1.Text.Substring(2, 2));
                            int year = -100;
                            if (year2 < 93 && year2 > 80)
                            {
                                year = 18;
                            }
                            if (year2 < 13 && year2 > 0)
                            {
                                year = 19;

                            }
                            if (year2 < 33 && year2 > 20)
                            {
                                year = 20;
                            }
                            if (year2 < 53 && year2 > 40)
                            {
                                year = 21;
                            }
                            if (year2 < 73 && year2 > 60)
                            {
                                year = 22;
                            }
                            if (textBox1.Text.Substring(0, 2) == textBox4.Text.Substring(2, 2))
                            {
                                if (int.Parse(textBox4.Text.Substring(0, 2)) == year)
                                {
                                    if (int.Parse(textBox2.Text) > 0 && DateTime.DaysInMonth(int.Parse(textBox4.Text), int.Parse(textBox3.Text)) <= int.Parse(textBox2.Text))
                                    {

                                        flag1 = 1;
                                    }
                                }
                            }


                        }

                    }
                    else
                    {
                        if (checkBox2.Checked && int.Parse(textBox1.Text.Substring(9, 1)) % 2 == 1)
                        {
                            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };
                            int sum = 0;
                            for (int i = 0; i < 11; i++)
                            {
                                sum += int.Parse(textBox1.Text.Substring(i, 1)) * weights[i];

                            }
                            if (sum % 10 == 0)
                            {
                                int year2 = int.Parse(textBox1.Text.Substring(2, 2));
                                int year = -100;
                                if (year2 < 93 && year2 > 80)
                                {
                                    year = 18;
                                }
                                if (year2 < 13 && year2 > 0)
                                {
                                    year = 19;

                                }
                                if (year2 < 33 && year2 > 20)
                                {
                                    year = 20;
                                }
                                if (year2 < 53 && year2 > 40)
                                {
                                    year = 21;
                                }
                                if (year2 < 73 && year2 > 60)
                                {
                                    year = 22;
                                }
                                if (textBox1.Text.Substring(0, 2) == textBox4.Text.Substring(2, 2))
                                {
                                    if (int.Parse(textBox4.Text.Substring(0, 2)) == year)
                                    {
                                        
                                        if (int.Parse(textBox2.Text) > 0 && DateTime.DaysInMonth(int.Parse(textBox4.Text), int.Parse(textBox3.Text)) >= int.Parse(textBox2.Text))
                                        {

                                            flag1 = 1;
                                        }
                                    }
                                }
                            }
                        }
                        







                    }
                }
                

                if (flag1 == 1)
                {
                    label2.Text = "to jest pesel";
                    flag1 = 0;
                }
                else
                {
                    label2.Text = "To nie jest pesel";
                }
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
                if (checkBox2.Checked == true)
                {
                    checkBox1.Checked = false;
                }
            
        }
    }
}