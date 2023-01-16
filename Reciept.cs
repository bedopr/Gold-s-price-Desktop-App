using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RECIEPT
{
    
    
    public partial class Form1 : Form
    {
        public string name;
        public string phone;
        public string date;
        public decimal gold;
        public decimal k18val;
        public decimal k21val;
        

        

        
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

       

     

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            date = DateTime.Now.ToString("dd/MM/yyyy");
            label6.Text = date;






            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            listBox1.Items.Add(comboBox1.Text + "       " + weight.Text+"جرام " + "       " + price.Text);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            gold = decimal.Parse(goldprice.Text);

            k21val = gold;
            k18val = gold * 18 / 21;

            k18.Text = k18val.ToString("0");
            k21.Text = k21val.ToString();
        }

        

        
    }
}
