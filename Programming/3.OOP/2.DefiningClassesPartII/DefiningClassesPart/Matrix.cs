using System;
using System.Text;

namespace MatrixClass
{
    public class Matrix<T> where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>, new()
    {


        private readonly int rows;
        private readonly int cols;
        private T[,] matrix;





        public Matrix()
            : this(0, 0, new T[0, 0])
        {
        }

        public Matrix(int rows, int cols)
            : this(rows, cols, new T[rows, cols])
        {
        }

        public Matrix(int rows, int cols, T[,] matr)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = matr;
        }



        public int GetRows
        {
            get
            {
                return this.rows;
            }
        }

        public int GetCols
        {
            get
            {
                return this.cols;
            }
        }

        public T this[int i, int j]
        {
            get
            {
                if (i < 0 || j < 0 || i > this.rows || j > this.cols)
                {
                    throw new IndexOutOfRangeException("Trying to access not existing element!");
                }
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }




        public void Print()
        {
            Console.WriteLine(new string('-', 20));
            for (int i = 0; i < GetRows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < GetCols; j++)
                {
                    Console.Write("{0,8}", this.matrix[i, j]);
                }
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < this.GetRows; i++)
            {
                builder.Append('\n');
                for (int j = 0; j < this.GetCols; j++)
                {
                    builder.Append(this.matrix[i, j]).Append("  ");
                }
            }
            return builder.ToString();
        }
    }
}

