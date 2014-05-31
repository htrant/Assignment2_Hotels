using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Hotels
{
    public class Generator
    {
        private static int number = 13081990;
        private int id;

        public Generator()
        {
            number = number + new Random().Next(1, 999999999);
            id = number + new Random().Next(1, 999999);
        }

        public int getId()
        {
            return id++;
        }
    }
}
