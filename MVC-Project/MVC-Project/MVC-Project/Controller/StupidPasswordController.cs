using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Project.Model;
using MVC_Project.View;

namespace MVC_Project.Controller
{
    public class StupidPasswordController
    {
        private Display display = new Display();

        public StupidPasswordController()
        {
            display = new Display();
        }

        public void Run()
        {
            display.ReadN();
            display.ReadL();
            int n = display.N;
            int l = display.L;

            StupidPassword model = new StupidPassword(n,l);

            List<string> result = model.GeneratePasswords();

            display.PrintResult(result);
        }
    }
}
