using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices
{
    class Program
    {
        static void Main(string[] args)
        {

            MatrixM mtrc1 = new MatrixM(10,10);
            MatrixM mtrc2 = new MatrixM(10,10);

            mtrc1.fillMatrix(40);

            mtrc2.fillMatrix(60);

            Console.WriteLine("Matrica 1:");
            MatrixM.displayMatrix(mtrc1);

            Console.WriteLine("Matrica 2:");
            MatrixM.displayMatrix(mtrc2);

            Console.WriteLine("Matrice 1.Spocitat, 2.Odratat, 3.nasobit, 4.unar operator - ?");
            string function = Console.ReadLine();

            MatrixM res = new MatrixM(10, 10);

            try
            {
               switch (function)
                {
                    case "1":
                        res = mtrc1 + mtrc2;
                        MatrixM.displayMatrix(res, "Suma");
                        MatrixM.unaryNegat(res);
                        break;
                    case "2":
                        res = mtrc1 - mtrc2;
                        MatrixM.displayMatrix(res, "Ocitanie");
                        MatrixM.unaryNegat(res);
                        break;
                    case "3":
                        res = mtrc1 * mtrc2;
                        MatrixM.displayMatrix(res, "Nasobenie");
                        MatrixM.unaryNegat(res);
                        break;
                        
                }

                Console.WriteLine("Pozicia riadok {0} stlpec {1} vysledok:{2}",4,5,res[4,5]);

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }


        }
    }
}
