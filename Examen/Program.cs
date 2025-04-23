using Examen.Services;
using Examen.DAL.Entities;
using Examen.DAL;

namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuService menu = new MenuService();
            menu.Menu();

        }
    }
}
