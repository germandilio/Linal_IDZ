using System;
using System.Threading.Tasks;

namespace Linal_IDZ
{
    public class Matrix
    {
        private int[,] matrix;

        public Matrix(int a, int b, int c, int d)
        {
            matrix = new int[4, 4];

            if (a == 1)
            {
                matrix[0, 0] = 1;
                matrix[1, 1] = 1;
            }

            if (b == 1)
                matrix[1, 0] = 1;

            if (c == 1)
            {
                matrix[2, 2] = 1;
                matrix[3, 3] = 1;
            }

            if (d == 1)
                matrix[2, 3] = 1;
        }

        public static Matrix operator *(Matrix A, Matrix B)
        {
            Matrix result = new Matrix(0, 0, 0, 0);

            Parallel.For(0, 4, (int i) =>
            {
                for (int j = 0; j < 4; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        temp += A[k, i] * B[j, k];
                    }
                    result[j, i] = (int)temp;
                }
            });
            return result;
        }

        public override bool Equals(object obj)
        {
            Matrix other = (Matrix)obj;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (this[i, j] != other[i, j]) return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    result += this[i, j] + " ";
                }
                result += "\n";
            }
            return result;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public int this[int a, int b]
        {
            get => matrix[a, b];
            set => matrix[a, b] = value;
        }
    }
}
