using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MVC_Project.View
{
    public class Display
    {
        private int n;
        private int l;
        public int N
        {
            get
            { 
                return n; 
            } 
            set 
            { 
                n = value; 
            }
        }

        public int L
        {
            get
            { 
                return l; 
            }
            set 
            { 
                l = value; 
            }
        }
        public void ReadN()
        {
            Console.Write("Enter n: ");
            N = int.Parse(Console.ReadLine());
        }

        public void ReadL()
        {
            Console.Write("Enter l: ");
            L = int.Parse(Console.ReadLine());
        }

        public void PrintResult(List<string> passwords)
        {
            Console.WriteLine(string.Join(" ", passwords));
        }
    }
}
