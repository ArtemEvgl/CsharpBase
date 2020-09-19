using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson05._3
{
    class MyMatrix
    {
        int[][] matrix;

        public MyMatrix(int rows, int cols)
        {           
            matrix = new int[rows][];
            for(int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
            }
            Fill(); 
        }

        public void Show()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.Write("\n");
            }
        }
        private void Fill()
        {
            Random random = new Random();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = random.Next(10,90);
                }
            }
        }

        public void ChangeSize(int rows, int cols)
        {
            if(rows <= 0 || cols <= 0)
            {
                Console.WriteLine("Неверно заданы данные");
                return;
            }
            
            int[][] newMatrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                newMatrix[i] = new int[cols];
            }
            
            for(int i = 0; i < Math.Min(matrix.Length, rows); i++)
            {                
                for(int j = 0; j < Math.Min(matrix[0].Length, cols); j++)
                {
                    newMatrix[i][j] = matrix[i][j];
                }
            }
            
            Random random = new Random();
            
            if(rows > matrix.Length)
            {
                for(int i = matrix.Length; i < rows; i++)
                {
                    for(int j = 0; j < cols; j++)
                    {
                        newMatrix[i][j] = random.Next(10, 90);
                    }
                }
            }

            if (cols > matrix.Length)
            {
                for (int i = matrix[0].Length; i < cols; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        newMatrix[j][i] = random.Next(10, 90);
                    }
                }
            }

            matrix = newMatrix;

        }

        public void ShowPartly(int startRow, int startCol, int endRow, int endCol)
        {
            if(startRow < 0 || startCol < 0 || endCol > matrix[0].Length || endRow > matrix.Length)
            {
                Console.WriteLine("Неверно заданы данные");
                return;
            }
            if(startCol > endCol || startRow > endRow)
            {
                Console.WriteLine("Неверно заданы данные");
                return;
            }

            for(int i = startRow; i < endRow; i++)
            {
                for(int j = startCol; j < endCol; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.Write("\n");
            }
        }
        
        public int this[int indexRow, int indexCol]
        {
            get
            {
                if(indexRow >= 0 && indexCol >= 0 && indexCol < matrix[0].Length && indexRow < matrix.Length)
                    return matrix[indexRow][indexCol];
                else
                    Console.WriteLine("Вы вышли за пределы массива");
                return 0;
            }
            set
            {
                if (indexRow >= 0 && indexCol >= 0 && indexCol < matrix[0].Length && indexRow < matrix.Length)
                    matrix[indexRow][indexCol] = value;
                else
                    Console.WriteLine("Вы вышли за пределы массива");
            }
        }
    }
}
