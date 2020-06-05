using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    class Commande : Icommande
    {
        private String cmd;
  
        public void Exec(string cmd)
        {
            String _Cmd = cmd.Substring(1,1);
            

            if (cmd.StartsWith("P"))
            {
                switch (_Cmd)
                {
                    case "T":
                        {
                            String _msg = cmd.Substring(cmd.IndexOf(":") + 1, cmd.LastIndexOf(":") - cmd.IndexOf(":") - 1);
                            Console.WriteLine(_msg);
                            break;
                        }
                    case "S":
                        {
                            String f = cmd.Substring(cmd.IndexOf(":") + 1, cmd.IndexOf(",") - cmd.IndexOf(":") - 1);
                            String c = cmd.Substring(cmd.IndexOf(",") + 1, cmd.LastIndexOf(":") - cmd.IndexOf(",") - 1);

                            int _frequency = System.Convert.ToInt32(f);
                            int _duration = System.Convert.ToInt32(c);
                            Console.WriteLine("Ack");
                            Console.WriteLine("");
                            Console.Beep(_frequency, _duration);

                            break;


                        }
                    default:
                        {
                            Console.WriteLine("NAk");
                            Console.WriteLine("cmd not Found");
                            break;

                        }
                }
            }
            else
            {
                Console.WriteLine("NAk");
            }
        }
    }
}
