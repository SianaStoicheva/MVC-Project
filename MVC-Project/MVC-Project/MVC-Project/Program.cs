
using MVC_Project.Controller;

namespace MVC_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StupidPasswordController controller = new StupidPasswordController();
            controller.Run();
        }
    }
}