using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro.Models
{
    internal class Educator

    {

        public string Name { get; set; }
        public string LastName { set; get; }
        public string Age { get; set; }
        
        public string ReflectInfo()
        {
            return $"{Name}{LastName}{Age}";
        }

    }
}
