using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {
          


            Commande c = new Commande();
            String cmd = Console.ReadLine();
            c.Exec(cmd);
       

            }

 
        
    }
}
