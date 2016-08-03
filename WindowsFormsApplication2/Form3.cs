using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)this.Owner;
            
            using (StreamWriter sw = new StreamWriter(@"D:\output.txt"))
            {
                sw.WriteLine("This is a short message:");
                sw.WriteLine(textBox1.Text);
            }
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //You mentioned if the "cancel" is pressed, nothing will happen. Then I commented this line, which means it will stay on the form2.
            //If you mean "cancel" means not passing textbox's contents to listbox, but only exiting the form2. Please uncomment this.Close();
        }
    }
}
