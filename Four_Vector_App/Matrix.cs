using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Four_Vector_App
{
    public class Matrix
    {

        public double[,] array;

        public Matrix()
        {
        }

        /**
         * Creates a matrix using a copy of a two dimensional array.
         *
         * @param array
         */
        public Matrix(double[,] array)
        {
            Copy(array);
            this.array = array;
        }

        /**
         * Creates a matrix using a two dimensional array without checking equal row
         * lengths.
         *
         * @param array
         * @param bypass dummy input that does nothing
         */
        private Matrix(double[,] array, bool bypass)
        {
            this.array = array;
        }

        /**
         * Creates an n x m matrix with entries equal to zero.
         *
         * @param row n
         * @param col m
         */
        public Matrix(int row, int col) : this(row, col, 0.0)
        {
        }

        /**
         * Creates an n x m matrix with entries equal to a constant value.
         *
         * @param row n
         * @param col m
         * @param entry constant value
         */
        public Matrix(int row, int col, double entry)
        {
            double[,] a = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    a[i, j] = entry;
                }
            }
            this.array = a;
        }
        public Matrix(double[][] jaggedarray)
        {
            this.array = create_rectangulararray(jaggedarray);
        }
        /**
         * Creates a double[][] array from a double[,] matrix
         */
        public double[][] getjaggedarray()
        {
            double[][] result = new double[this.array.GetLength(0)][];
            for (int i = 0; i < this.array.GetLength(0); i++)
            {
                double[] row = new double[this.array.GetLength(1)];
                for (int j = 0; j < this.array.GetLength(1); j++)
                {
                    row[j] = this.array[i, j];
                }
                result[i] = row;
            }
            return result;
        }
        public double[][] getjaggedarray(double[,] rectangulararray)
        {
            double[][] result = new double[rectangulararray.GetLength(0)][];
            for (int i = 0; i < rectangulararray.GetLength(0); i++)
            {
                double[] row = new double[rectangulararray.GetLength(1)];
                for (int j = 0; j < rectangulararray.GetLength(1); j++)
                {
                    row[j] = rectangulararray[i, j];
                }
                result[i] = row;
            }
            return result;
        }
        /**
         * Creates a double[,] matrix from a double[][] array.
         */
        public double[,] create_rectangulararray(double[][] jaggedarray)
        {
            Rectify(jaggedarray);
            double[,] result = new double[jaggedarray.Length, jaggedarray[0].Length];
            for (int i = 0; i < jaggedarray.Length; i++)
            {
                for (int j = 0; j < jaggedarray[0].Length; j++)
                {
                    result[i, j] = jaggedarray[i][j];
                }
            }
            return result;
        }
        /**
     * Makes all rows of a 2D array of equal length by extending the lengths of
     * shorter rows using zeros. The input array changes.
     *
     * @param array
     * @return
     */
        public static double[][] Rectify(double[][] array)
        {
            int[] lengths = new int[array.Length];
            int count = 0;
            int maxSize = array[0].Length;
            for (int i = 0; i < array.Length; i++)
            {
                int size = array[i].Length;
                lengths[i] = size;
                if (size != maxSize)
                {
                    count++;
                    if (size > maxSize)
                    {
                        maxSize = size;
                    }
                }
            }
            if (count > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (lengths[i] < maxSize)
                    {
                        double[] extend = new double[maxSize];
                        for (int j = 0; j < array[i].Length; j++)
                        {
                            extend[j] = array[i][j];
                        }
                        for (int j = array[i].Length; j < maxSize; j++)
                        {
                            extend[j] = 0;
                        }
                        array[i] = extend;
                    }
                }
            }
            return array;
        }
        public void set(double[,] array)
        {
            this.array = array;
        }

        public void set(double[][] array)
        {
            this.array = create_rectangulararray(array);
        }
        public Matrix(double[] s_array)
        {
            double[,] matrix = new double[s_array.Length, 1];
            for (int i = 0; i < s_array.Length; i++)
            {
                matrix[i, 0] = s_array[i];
            }
            this.array = matrix;
        }

        public void set(int row, int col, double entry)
        {
            array[row, col] = entry;
        }

        /**
         * Makes a deep copy of an array.
         *
         * @param array
         * @return
         */
        public static double[,] Copy(double[,] array)
        {
            double[,] result = new double[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result[i, j] = array[i, j];
                }
            }
            return result;
        }
        /**
         * Gets the diagonal of a matrix, setting all non-diagonal entries to zero
         * 
         */
        public static double[,] Diagonal(double[,] array)
        {
            double[,] result = new double[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        result[i, j] = array[i, j];
                    }
                    else
                    {
                        result[i, j] = 0;
                    }
                }
            }
            return result;
        }

        /**
         * returns the dimensions of the matrix as a 1-d array
         */
        public int[] dim()
        {
            return new int[] { array.GetLength(0), array.GetLength(1) };
        }

        public void print()
        {
            int[] d = dim();
            Console.Out.WriteLine(d[0] + "x" + d[1] + " matrix");
            for (int i = 0; i < d[0]; i++)
            {
                for (int j = 0; j < d[1]; j++)
                {
                    Console.Out.Write(array[i, j].ToString() + " ");
                }
                Console.Out.Write("\n\n");
            }
        }

        public void printdata()
        {
            int[] d = dim();
            String entry;
            Console.Out.WriteLine(d[0] + "x" + d[1] + " matrix");
            for (int i = 0; i < d[0]; i++)
            {
                entry = "";
                for (int j = 0; j < d[1]; j++)
                {
                    entry += array[i, j] + ",";
                }
                Console.Out.WriteLine(entry);
            }
        }
        public void print_plain()
        {
            int[] d = dim();
            String entry;
            Console.Out.WriteLine(d[0] + "x" + d[1] + " matrix");
            for (int i = 0; i < d[0]; i++)
            {
                entry = "";
                for (int j = 0; j < d[1]; j++)
                {
                    entry += array[i, j] + "    ";
                }
                Console.Out.WriteLine(entry);
            }
        }

        public Matrix add(double constant)
        {
            double[,] b = this.array;
            int row = b.GetLength(0);
            int col = b.GetLength(1);
            double[,] c = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    c[i, j] = constant + b[i, j];
                }
            }
            Matrix result = new Matrix(c, true);
            return result;
        }

        public Matrix add(Matrix matrix)
        {
            int[] dimA = this.dim();
            int[] dimB = matrix.dim();
            if (dimA[0] != dimB[0] || dimA[1] != dimB[1])
            {
                throw new ArithmeticException("matrix dimensions do not agree: (" + dimA[0] + "x" + dimA[1] + "),(" + dimB[0] + "x" + dimB[1] + ") ");
            }
            int row = dimA[0];
            int col = dimA[1];
            double[,] a = this.array;
            double[,] b = matrix.array;
            double[,] c = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            Matrix result = new Matrix(c, true);
            return result;
        }
        public Matrix subtract(Matrix matrix)
        {
            int[] dimA = this.dim();
            int[] dimB = matrix.dim();
            if (dimA[0] != dimB[0] || dimA[1] != dimB[1])
            {
                throw new ArithmeticException("matrix dimensions do not agree: (" + dimA[0] + "x" + dimA[1] + "),(" + dimB[0] + "x" + dimB[1] + ") ");
            }
            int row = dimA[0];
            int col = dimA[1];
            double[,] a = this.array;
            double[,] b = matrix.array;
            double[,] c = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    c[i, j] = a[i, j] - b[i, j];
                }
            }
            Matrix result = new Matrix(c, true);
            return result;
        }

        public Matrix multiply(double constant)
        {
            double[,] a = this.array;
            int row = a.GetLength(0);
            int col = a.GetLength(1);
            double[,] c = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    c[i, j] = constant * a[i, j];
                }
            }
            Matrix result = new Matrix(c, true);
            return result;
        }

        public Matrix multiply(Matrix matrix)
        {
            int[] dimA = this.dim();
            int[] dimB = matrix.dim();
            if (dimA[1] != dimB[0])
            {
                throw new ArithmeticException("matrix dimensions do not agree: (" + dimA[0] + "x" + dimA[1] + "),(" + dimB[0] + "x" + dimB[1] + ") ");
            }
            double[,] a = this.array;
            double[,] b = matrix.array;
            int row = dimA[0];
            int col = dimB[1];
            double[,] c = new double[row, col];
            int multiplications = dimA[1];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    double entry = 0;
                    for (int m = 0; m < multiplications; m++)
                    {
                        entry += a[i, m] * b[m, j];
                    }
                    c[i, j] = entry;
                }
            }
            Matrix result = new Matrix(c, true);
            return result;
        }
        public static double[] Gaussian(double[][] matrix)
        {
            double numOfEq = matrix.Length;
            int numOfVar = matrix[0].Length - 1; // all rows assumed to be equal length
            for (int i = 0; i < numOfEq; i++)
            {
                double[] currentRow = matrix[i];
                double leadingTerm = 0;
                int leadingIndex = 0;
                for (int j = i; j <= numOfVar; j++)
                {
                    if (currentRow[j] != 0)
                    {
                        leadingTerm = currentRow[j];
                        leadingIndex = j;
                        break;
                    }
                }
                if (leadingTerm == 0)
                {
                    return null; // no unique solution exists
                }
                if (leadingIndex != i)
                {
                    // reorder the rows to diagonalize the matrix if not already done
                    matrix[i] = matrix[leadingIndex];
                    matrix[leadingIndex] = currentRow;
                }
                // elminate the leading term of the row below by subtracting a multiple of that row with this row
                for (int j = i + 1; j < numOfVar; j++)
                {
                    double coef = matrix[j][i] / matrix[i][i];
                    for (int k = 0; k < matrix[j].Length; k++)
                    {
                        matrix[j][k] = matrix[j][k] - coef * matrix[i][k];
                    }
                }

            }
            if (matrix[numOfVar - 1][numOfVar - 1] == 0)
            {
                return null; // no unique solution exists
            }
            // backwards substitution for the variable values
            double[] result = new double[numOfVar];
            result[numOfVar - 1] = matrix[numOfVar - 1][numOfVar] / matrix[numOfVar - 1][numOfVar - 1];
            for (int i = numOfVar - 1; i >= 0; i--)
            {
                double sum = 0;
                for (int j = i + 1; j < numOfVar; j++)
                {
                    sum += matrix[i][j] * result[j];
                }
                result[i] = (matrix[i][numOfVar] - sum) / matrix[i][i];
            }
            return result;
        }

        /**
         * Reduces a matrix into reduced row-echelon form using the algorithm
         * described here: http://www.csun.edu/~panferov/math262/262_rref.pdf.
         *
         * @param matrix
         */
        public static void reduce(double[][] matrix)
        {
            int row = matrix.Length;
            int col = matrix[0].Length;
            for (int i = 0, j = 0; i < row && j < col; i++, j++)
            {
                /* if aij = 0 swap the ith row with some other row below to guarantee that aij != 0.
                 * if all entries in the column are zero, increase j by 1.
                 */
                if (matrix[i][j] == 0)
                {
                    bool found = false;
                    for (int k = i; k < row; k++)
                    {
                        if (matrix[k][j] != 0)
                        {
                            double[] swap = matrix[k];
                            matrix[k] = matrix[i];
                            matrix[i] = swap;
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        j++;
                        if (j >= col)
                        {
                            break;
                        }
                    }
                }
                // divide the ith row by aij to make the pivot entry = 1
                double aij = matrix[i][j];
                for (int k = 0; k < col; k++)
                {
                    matrix[i][k] = matrix[i][k] / aij;
                }
                // eliminate all other entries in the jth column by subtracting suitable multiples of the ith row from other rows
                for (int k = 0; k < row; k++)
                {
                    double coef = matrix[k][j];
                    for (int m = 0; m < col; m++)
                    {
                        if (k != i)
                        {
                            matrix[k][m] = matrix[k][m] - coef * matrix[i][m];
                        }
                    }
                }
            }
        }
        public Matrix reduce()
        {
            double[][] jaggedarray = this.getjaggedarray();
            reduce(jaggedarray);
            return new Matrix(jaggedarray);
        }

        private void reduce(bool nocopy)
        {
            double[][] jaggedarray = this.getjaggedarray();
            reduce(jaggedarray);
            set(jaggedarray);
        }

        public double[] solve(bool print)
        {
            double[] result = Gaussian(getjaggedarray(array));
            if (print)
            {
                Console.Out.WriteLine(result.ToString());
            }
            return result;
        }

        public double[] solve()
        {
            return solve(false);
        }

        public Matrix solve(double[] array, bool print)
        {
            Matrix result = this.inverse().multiply(new Matrix(array));
            if (print)
            {
                result.print();
            }
            return result;
        }

        public Matrix solve(double[] array)
        {
            return solve(array, false);
        }

        /**
         * Creates a matrix of a n_x_n square matrix augmented with the n_x_n
         * identity.
         *
         * @return
         */
        private Matrix augment()
        {
            int[] d = dim();
            if (d[0] != d[1])
            {
                throw new ArithmeticException("matrix is not square: (" + d[0] + "x" + d[1] + ")");
            }
            int n = d[0];
            double[,] identity = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    identity[i, j] = 0;
                }
                identity[i, i] = 1;
            }
            double[,] augment = new double[n, 2 * n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    augment[i, j] = array[i, j];
                    augment[i, j + n] = identity[i, j];
                }
            }
            Matrix result = new Matrix(augment);
            return result;
        }

        /**
         * Creates a matrix by augmenting column or row vectors.
         *
         * @param matrix
         * @param column true joins the array as column vectors to the right of
         * matrix. false joins the array as row vectors to the bottom of the matrix.
         * @return
         */
        public Matrix augment(double[,] matrix, bool column)
        {
            int[] d = dim();
            int row = d[0];
            int col = d[1];
            double[,] addend = Copy(matrix);

            int addrow = addend.GetLength(0);
            int addcol = addend.GetLength(1);
            if (column)
            {
                col += addcol;
                if (row != addrow)
                {
                    throw new ArithmeticException("row lengths do not match: " + row + "," + addrow);
                }
            }
            else
            {
                row += addrow;
                if (col != addcol)
                {
                    throw new ArithmeticException("row lengths do not match: " + col + "," + addcol);
                }
            }
            double[,] augment = new double[row, col];
            if (column)
            {
                for (int i = 0; i < d[0]; i++)
                {
                    for (int j = 0; j < d[1]; j++)
                    {
                        augment[i, j] = array[i, j];
                        augment[i, j + addcol] = addend[i, j];
                    }
                }
            }
            else
            {
                for (int i = 0; i < d[0]; i++)
                {
                    for (int j = 0; j < d[1]; j++)
                    {
                        augment[i, j] = array[i, j];
                        augment[i + addrow, j] = addend[i, j];
                    }
                }
            }
            Matrix result = new Matrix(augment);
            return result;
        }

        /**
         * Creates a matrix by augmenting another matrix as column or row vectors.
         *
         * @param matrix
         * @param column true joins the input matrix as column vectors to the right
         * of matrix. false joins the input matrix as row vectors to the bottom of
         * the matrix.
         * @return
         */
        public Matrix augment(Matrix matrix, bool column)
        {
            return augment(matrix.array, column);
        }

        public static Matrix Identity(int n)
        {
            Matrix result = new Matrix(Identity(n, true));
            return result;

        }

        private static double[,] Identity(int n, bool array)
        {
            double[,] identity = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    identity[i, j] = 0;
                }
                identity[i, i] = 1;
            }
            return identity;
        }

        public Matrix transpose()
        {
            int[] d = dim();
            double[,] transpose = new double[d[1], d[0]];
            for (int i = 0; i < d[1]; i++)
            {
                for (int j = 0; j < d[0]; j++)
                {
                    transpose[i, j] = this.array[j, i];
                }
            }
            Matrix result = new Matrix(transpose);
            return result;
        }

        /**
         * Returns the inverse of a square matrix. Original matrix is not modified.
         *
         * @return
         */
        public Matrix inverse()
        {
            int[] d = dim();
            int n = d[0];
            Matrix result = this.augment();
            result.reduce(true);
            result.crop(new int[] { 0, n, n, 2 * n });
            return result;
        }

        private void crop(int[] corners)
        {
            int rowstart = corners[0];
            int rowend = corners[1];
            int colstart = corners[2];
            int colend = corners[3];

            int row = rowend - rowstart;
            int col = colend - colstart;
            double[,] crop = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    crop[i, j] = array[rowstart + i, colstart + j];
                }
            }
            array = crop;
        }

        public static void test01()
        {
            double[][] test =
            {
                new[] {1.0,2,3},
                new[] {1.0},
                new[] {1.0,2,3,4,5}
            };

            Matrix m1 = new Matrix(test);
            m1.print();

            Matrix m2 = new Matrix(5, 4, 1);
            m1.add(m1).print();
            m1.add(2).print();
            m1.print();
            m1.multiply(m2).print();

            m2 = new Matrix(new double[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 0, 4, 5 } });
            m1 = new Matrix(new double[,] { { 1, 4, 6 }, { 3, 5, 9 } });
            m1.multiply(m2).print();
            m1.multiply(2).print();
            Console.Out.WriteLine("solving matrix 1:");
            double[] solution = m1.solve();
            Console.Out.WriteLine(
            string.Join(",",
                          solution.Select(x => x.ToString()).ToArray()));
            m1.print();
            m1.transpose().print();
            m1 = new Matrix(4, 4, 5);
            m2.augment(Matrix.Identity(3), true).print();
            m2.print();
            m2.augment(Matrix.Identity(3), true).reduce().print();
            m2.inverse().print();
            m2.print();
        }

        public double dotproduct(double[] array1, double[] array2)
        {
            int rows = array1.Length;
            int cols = array2.Length;
            double result = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result += array1[i] * array2[j];
                }
            }
            return result;
        }

        public Matrix[] LUdoolittle()
        {
            Matrix[] result = new Matrix[2];
            int rows = dim()[1];
            int cols = dim()[0];
            double[,] lower = new double[rows, cols];
            // make lower matrix have ones in diagonal
            for (int i = 0; i < rows; i++)
            {
                lower[i, i] = 1;
                for (int j = i + 1; j < cols; j++)
                {
                    lower[i, j] = 0;
                }
            }
            double[,] upper = new double[rows, cols];
            double alpha;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    alpha = array[i, j];
                    for (int k = 0; k < j; k++)
                    {
                        alpha = alpha - lower[i, k] * upper[k, j];
                    }
                    lower[i, j] = alpha / upper[j, j];
                }
                for (int j = i; j < rows; j++)
                {
                    alpha = array[i, j];
                    for (int k = 0; k < i; k++)
                    {
                        alpha = alpha - lower[i, k] * upper[k, j];
                    }
                    upper[i, j] = alpha;
                }
            }

            Matrix ml = new Matrix(lower);
            //        ml.print();
            Matrix mu = new Matrix(upper);
            //        mu.print();
            result[0] = ml;
            result[1] = mu;
            return result;
        }

        public double det(bool print)
        {
            Matrix[] lu = LUdoolittle();
            double[,] upperm = lu[1].array;
            double result = 1;
            for (int i = 0; i < upperm.GetLength(0); i++)
            {
                result *= upperm[i, i];
            }
            if (print)
            {
                Console.Out.WriteLine("det of " + dim()[0] + "x" + dim()[1] + " matrix: " + result);
            }
            return result;
        }

        public double det()
        {
            return det(false);
        }

        public static int kronecker_delta(int i, int j)
        {
            if (i == j)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static int levi_cita_3d(int i, int j, int k)
        {
            if (i == 0 && j == 1 && k == 2) return 1;
            if (i == 1 && j == 2 && k == 0) return 1;
            if (i == 2 && j == 0 && k == 1) return 1;
            if (i == 0 && j == 2 && k == 1) return -1;
            if (i == 1 && j == 0 && k == 2) return -1;
            if (i == 2 && j == 1 && k == 0) return -1;
            return 0;
        }

        public static int levi_cita_n(int[] indices)
        {
            int parity = 1;

            for (int i = 0; i < indices.Length - 1; i++)
            {
                for (int j = i + 1; j < indices.Length; j++)
                {
                    if (indices[i] > indices[j])
                    {
                        parity = -parity;
                    }
                    else if (indices[i] == indices[j])
                    {
                        return 0;
                    }

                }
            }
            return parity;
        }
        public static double[,] Calculate_spacetime_rotationmatrix(double rotation_angle, double[] rotation_vector)
        {
            double[] _n = new double[rotation_vector.Length + 1]; // renumber the index from 1 to 3
            rotation_vector.CopyTo(_n, 1);
            double[,] rotation_array = new double[rotation_vector.Length + 1, rotation_vector.Length + 1];
            rotation_array[0, 0] = 1;
            for (int i = 0; i < rotation_array.Rank; i++)
            {
                rotation_array[i, 0] = 0;
            }
            for (int i = 0; i < rotation_array.Length; i++)
            {
                rotation_array[0, i] = 0;
            }

            for (int i = 1; i < rotation_vector.Length; i++)
            {
                for (int j = 1; j < rotation_vector.Length; j++)
                {
                    double term1 = (kronecker_delta(i, j) - _n[i] * _n[j]) * Math.Cos(rotation_angle);
                    double levicita_term = 0;
                    for (int k=1; k<rotation_vector.Length; k++)
                    {
                        levicita_term += levi_cita_3d(i, j, k);
                    }
                    double term2 = -levicita_term * Math.Sin(rotation_angle) + _n[i] * _n[j];
                    rotation_array[i, j] = term1+term2;
                }
            }
            return rotation_array;
        }

    } // end matrix class
} // end four_vector_app namespace


