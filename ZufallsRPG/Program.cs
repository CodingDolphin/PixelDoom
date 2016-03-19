using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PixelDoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu StartMenu = new Menu();
            StartMenu.initStartMenu(StartMenu);
        }
    }
}
