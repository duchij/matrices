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

            Matrix mtrc = new Matrix();

            int[][] matrix1 = mtrc.fillMatrix(10, 10);
            int[][] matrix2 = mtrc.fillMatrix(10, 10);

            Console.WriteLine("Matrica 1:");
            Matrix.displayMatrix(matrix1);

            Console.WriteLine("Matrica 2:");
            Matrix.displayMatrix(matrix2);

            Console.WriteLine("Matrice 1.Spocitat, 2.Odratat, 3.nasobit, 4.unar operator - ?");
            string function = Console.ReadLine();

            int[][] res;

            try
            {
                switch (function)
                {
                    case "1":
                        res = mtrc.matrixMath(matrix1, matrix2,"sum");
                        Matrix.displayMatrix(res, "Suma");
                        Matrix.unaryNegat(res);
                        break;
                    case "2":
                        res = mtrc.matrixMath(matrix1, matrix2,"sub");
                        Matrix.displayMatrix(res, "Ocitanie");
                        Matrix.unaryNegat(res);
                        break;
                    case "3":
                        res = mtrc.matrixMath(matrix1, matrix2,"multi");
                        Matrix.displayMatrix(res, "Nasobenie");
                        Matrix.unaryNegat(res);
                        break;
                        
                }

               

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
