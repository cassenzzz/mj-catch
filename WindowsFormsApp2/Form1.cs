using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        //Random dd = new Random();
        int dd = 0;
        Label[] labels;
        RadioButton[] radios;
        public Form1()
        {
            InitializeComponent();
            labels = new Label[4] { label2, label3, label4, label5 };
            radios = new RadioButton[4] {radioButton1, radioButton2, radioButton3, radioButton4 };
            

            //label1.Text = dd.Next(3, 19).ToString();




        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dd = int.Parse(comboBox1.Text);
            label1.Text = star(dd,labels,radios);
            
        }

        public static String star(int dd, Label[] labels, RadioButton[] radios)
        {
            int n = 0;
            String l = " ";
            for (int i = 0; i < 4; i++)
            {
                labels[i].Text = "";
                if (radios[i].Checked) { n = 18 * (i + 1); l = radios[i].Text; }
            }
            int[] arr = new int[72];
            Array.Clear(arr, 0, arr.Length);
            int a = 0;

             
            
            if(dd % 4 == 1)
            {
                a = (n + 18 * 0 - 1) % 72 - dd;
            }
            else if(dd % 4 == 2)
            {
                a = (n + 18 * 1 - 1) % 72 - dd;
            }
            else if (dd % 4 == 3)
            {
                a = (n + 18 * 2 - 1) % 72 - dd;
            }
            else if (dd % 4 == 0)
            {
                a = (n + 18 * 3 - 1) % 72 - dd;
            }



            int flag = 0;

            for (int i = a+72;i > a-32+72; i-=2)
            {
                //if (j < 0) j = j + 72;
                arr[i%72] = flag+1;
                arr[(i - 1)%72] = flag+1;
                flag = (flag + 1) % 4;
            }

            
            for(int i = 0; i < 18; i++)
            {
                labels[0].Text += arr[i].ToString() + "  ";
            }
            for (int i = 35; i >= 18; i--)
            {
                labels[1].Text += arr[i].ToString()+"\r\n\r\n";
            }
            for (int i = 53; i >= 36; i--)
            {
                labels[2].Text += arr[i].ToString()+"  ";
            }
            for (int i = 54; i < 72; i++)
            {
                labels[3].Text += arr[i].ToString()+"\r\n\r\n";
            }
            l = l + " 莊家" + " 骰子:" + dd.ToString();
            return l ;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
