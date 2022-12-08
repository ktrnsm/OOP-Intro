using OOP_Intro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Intro
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Educator educator = new Educator();
            educator.Name = textBox1.Text;
            educator.LastName = textBox2.Text;
            educator.Age = textBox3.Text;

            listBox1.Items.Add(educator.ReflectInfo());


        }
    }
}
