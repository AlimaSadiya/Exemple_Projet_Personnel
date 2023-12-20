using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assurance_exo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Saisir le montant des dommages : ");
            double montantDommages = Convert.ToDouble(Console.ReadLine());

            double montantRemboursement = montantDommages;
            double franchise = 0;
            Console.WriteLine("Le montant qui sera remboursé est de : " + montantRemboursement + " euros.");

            if (montantDommages > 4000)
            {
                franchise = 10 / 100 * (montantDommages - 4000);
                montantRemboursement = montantDommages - franchise;
            }
            Console.WriteLine("La franchise correspondante est de : " + franchise + " euros.");

            Console.ReadKey();
        }
    }
}
        
