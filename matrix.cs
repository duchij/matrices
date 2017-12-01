using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices
{
    class MatrixM
    {
        int[][] _m;
        int _i, _j;

        int v;

       public int rows;
       public int cols;


        public MatrixM(int[][] m)
        {
            this._m = m;

            this.rows = m.Length;
            this.cols = m[this.rows].Length;

        }

        public void setIndex(int i, int j)
        {
            this._i = i;
            this._j = j;
        }

        public static int multiply(MatrixM m1,MatrixM m2)
        {

            for (int i = 0; i < MatrixM.rows; i++)
                for (int j = 0; j < R.cols; j++)
                    for (int k = 0; k < A.cols; k++)
                        R[i, j] += A[i, k] * B[k, j];
            return R;
        }
              

        public MatrixM(int v)
        {
           this.v = v; 
        }

        public static MatrixM operator +(MatrixM m1, MatrixM m2)
        {
            return new MatrixM(m1._m[m1._i][m1._j] + m2._m[m2._i][m2._j]);
        }

        public static MatrixM operator -(MatrixM m1, MatrixM m2)
        {
            return new MatrixM(m1._m[m1._i][m1._j] - m2._m[m2._i][m2._j]);
        }

        public static MatrixM operator *(MatrixM m1, MatrixM m2)
        {
            return new MatrixM(m1._m[m1._i][m1._j] * m2._m[m2._i][m2._j]);
        }

        public static implicit operator int(MatrixM M)
        {
            return (int)M.v;
        }

    }


    class Matrix
    {
        private int i, j;
        public Random rnd = new Random();

        public Matrix()
        {

        }

        public int[][] fillMatrix(int n, int m)
        {
            int[][] res = new int[n][];

            for (int i=0; i<n; i++)
            {
                res[i] = new int[m];

                for (int j=0; j<m; j++)
                {
                    res[i][j] = this.rnd.Next(0, 100);
                }
            }

            return res;
        }


        public static void displayMatrix(int[][] matrix,string type="vypis")
        {
            Console.WriteLine("Matrica vypis ({0}):", type);
            int n = matrix.Length;

            for (int i=0; i < n; i++)
            {
                string tmp = String.Join(",", Array.ConvertAll<int, String>(matrix[i], Convert.ToString));
                Console.WriteLine(tmp);
            }

        } 

        public static void unaryNegat(int[][] matrix)
        {
            

            int n = matrix.Length;
            int m = matrix[n - 1].Length;
            int[][] res = new int[n][];

            for (int i=0; i<n; i++)
            {
                res[i] = new int[m];

                for (int j=0; j<m; j++)
                {
                    res[i][j] = -matrix[i][j];
                }
            }

            Matrix.displayMatrix(res,"unary negat");

        }

        private bool checkSize(int[][] matrix1, int[][] matrix2)
        {
            bool result = true;

            int n1 = matrix1.Length;
            //int n2 = matrix2.Length;

            if (n1 != matrix2.Length)
            {
                result = false;
            }

            int m1 = matrix1[n1-1].Length;
            //int m2 = matrix2[n2].Length;

            if (m1 != matrix2[n1-1].Length)
            {
                result = false;
            }
            return result;
        }

        public int matrixIndex(int x, int y, int[][] matrix)
        {
            int result = -1;

            result = matrix[x][y];

            return result;
           
        }

        public int[][] matrixMath(int[][]matrix1, int[][]matrix2, string operation)
        {

           // MatrixM.matrix = matrix1;

            if (!this.checkSize(matrix1, matrix2))
            {
                throw new Exception("Matrice sa nerovnaju vo vertikalnom alebo horizontalnom smere !!!!");
            }

            int n = matrix1.Length;
            int m = matrix1[n-1].Length;
            
            int[][] result = new int[n][];


            MatrixM M1 = new MatrixM(matrix1);
            MatrixM M2 = new MatrixM(matrix2);


            for (int i=0; i<n; i++)
            {
                result[i] = new int[m];

                for (int j=0; j<m; j++)
                {
                    M1.setIndex(i, j);
                    M2.setIndex(i, j);

                    switch (operation){

                        case "sum":
                            result[i][j] =M1 + M2;
                            break;
                        case "sub":
                            result[i][j] = M1 - M2;
                            break;
                        case "multi":
                            result[i][j] = M1 * M2;
                            break;
                        default:
                            break;
                    }
                }
            }

            return result;
        }

    }
}
