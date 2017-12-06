using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices
{
    class MatrixM
    {
        int[,] _m;
        int _i, _j;

        int v;

       public int Rows { get; private set; }
       public int Cols { get; private set; }

        public MatrixM(int rows, int cols, int[,] mdata)
        {
            this.Cols = cols;
            this.Rows = rows;

            this._m = new int[rows, cols];

            this._m = mdata;

        }

        public void fillMatrix(int max)
        {
            Random rnd = new Random();

            for (int i=0; i< this.Rows; i++)
            {
                for (int j=0; j<this.Cols; j++)
                {
                    this._m[i, j] = rnd.Next(0,max);
                }
            }
           
        }


        public MatrixM(int rows, int cols)
        {
            this.Cols = cols;
            this.Rows = rows;

            this._m = new int[rows, cols];

           /// this._m = mdata;

        }

        public int this[int r,int c]
        {
            get { return this._m[r, c]; }
            set { this._m[r, c] = value; }
        }

        public void setIndex(int i, int j)
        {
            this._i = i;
            this._j = j;
        }

     /*  public static int multiply(MatrixM m1,MatrixM m2)
        {

            for (int i = 0; i < MatrixM.rows; i++)
                for (int j = 0; j < R.cols; j++)
                    for (int k = 0; k < A.cols; k++)
                        R[i, j] += A[i, k] * B[k, j];
            return R;
        }*/
              

        public MatrixM(int v)
        {
           this.v = v; 
        }

        private static MatrixM mSum(MatrixM m1,MatrixM m2)
        {
            MatrixM m = new MatrixM(m1.Rows, m1.Cols);

            for (int i=0; i<m1.Rows; i++)
            {
                for (int j=0; j<m1.Cols; j++)
                {
                    m[i, j] = m1[i, j] + m2[i, j];
                }
            }

            return m;
        }


        private static MatrixM mSub(MatrixM m1, MatrixM m2)
        {
            MatrixM m = new MatrixM(m1.Rows, m1.Cols);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    m[i, j] = m1[i, j] - m2[i, j];
                }
            }

            return m;
        }

        private static MatrixM multi(MatrixM m1, MatrixM m2)
        {
            MatrixM m = new MatrixM(m1.Rows, m1.Cols);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    for (int k = 0; k < m1.Cols; k++)
                    {
                        m[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }
            return m;
        }

        public static void unaryNegat(MatrixM m)
        {
            MatrixM r = new MatrixM(m.Rows, m.Cols);

            for (int i = 0; i < m.Rows; i++)
            {
                for (int j = 0; j < m.Cols; j++)
                {
                    r[i, j] = -m[i, j];
                }
            }
            MatrixM.displayMatrix(r,"unary Negat");
        }



        public static MatrixM operator +(MatrixM m1, MatrixM m2)
        {
            return MatrixM.mSum(m1,m2);
        }

        public static MatrixM operator -(MatrixM m1, MatrixM m2)
        {
            return MatrixM.mSub(m1, m2);
        }

        public static MatrixM operator *(MatrixM m1, MatrixM m2)
        {
            return MatrixM.multi(m1,m2);
        }

        public static implicit operator int(MatrixM M)
        {
            return (int)M.v;
        }


        public static void displayMatrix(MatrixM matrix, string type = "vypis")
        {
            Console.WriteLine("Matrica vypis ({0}):", type);
            int n = matrix.Cols;
            int m = matrix.Rows;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + ",");
                }
                Console.WriteLine();
            }

        }

    }
    
}
