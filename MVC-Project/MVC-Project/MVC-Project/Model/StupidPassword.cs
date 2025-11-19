using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Model
{
    public class StupidPassword
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

        public StupidPassword(int n, int l)
        {
            N = n;
            L = l;
        }
        public StupidPassword() : this(0, 0)
        {
        }
        public List<string> GeneratePasswords()
        {
            List<string> result = new List<string>();

            for (int a = 1; a <= N; a++)
            {
                for (int b = 1; b <= N; b++)
                {
                    for (char c = 'a'; c < 'a' + L; c++)
                    {
                        for (char d = 'a'; d < 'a' + L; d++)
                        {
                            for (int e = 1; e <= N; e++)
                            {
                                if (e > a && e > b)
                                {
                                    result.Add($"{a}{b}{c}{d}{e}");
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
