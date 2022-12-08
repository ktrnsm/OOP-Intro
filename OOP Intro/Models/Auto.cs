using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Intro.Models
{
    internal class Auto
    {

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }

        public void Drive()
        {
            MessageBox.Show("Let's Goo!!");

        }

        public void Break()
        {
            MessageBox.Show("Please Stop");
        }
    }

    
}
