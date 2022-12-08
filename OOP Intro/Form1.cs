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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Auto a = new Auto();
            a.Name = "XYZ";
            a.Type = "ABC";
            a.Model = "CXZ";
            a.Color = "blue";

            Auto b = new Auto();
            b.Name = "QWE";

        }
    }
}
