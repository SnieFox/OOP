using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    public class Show
    {
        public static void ShowMessage()
        {
            string trial = "";
            Console.Write("Введите код доступа(Trial/Pro): ");
            trial = Console.ReadLine().ToLower();
            switch (trial)
            {
                case "trial":
                    ApplicationLicense.AllowTrial();
                    break;
                case "pro":
                    ApplicationLicense.AllowPro();
                    break;
                default:
                    ApplicationLicense.AllowCommon();
                    break;
            }

        }
    }
}
