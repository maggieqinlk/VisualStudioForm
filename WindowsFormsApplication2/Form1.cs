using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "New Form";
            this.BackColor = Color.Brown;
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 1000; i++)
            {
                Random rNum = new Random();
                int iNum = rNum.Next(0, 1001);
                this.listBox1.Items.Add(iNum);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Owner = this;
            frm2.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Owner = this;
            frm3.Show();
            

        }
    }
}
