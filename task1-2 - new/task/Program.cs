using System;

namespace task
{
  internal class Program
  {
    
    private static int[][] MatrixCount(int[][] matrix,int m,int n)
    {
      for (int i = 0; i < m-1; i++)
      {
        for (int k = i + 1; k < m; k++)
        {
          if (SummRow(matrix, i, n) > SummRow(matrix, k, n))
          {
            int[] t;
            t = matrix[i];
            matrix[i] = matrix[k];
            matrix[k] = t;

          }
        }
      }

      return matrix;
    }
    
    private static int[,] EnterMatrix(int m, int n){
    int[,] answerMas = new int[m, n];
            for (int i = 0; i < answerMas.GetLength(0); i++)
            {
                string enterString = Console.ReadLine();
                string[] massiveString = enterString.Split(new Char[] { ' ' });
                for (int j = 0; j < massiveString.Length; j++)
                {
                    answerMas[i, j] = int.Parse(massiveString[j]);
                }
            } 
            return answerMas;
       }

    private  static int SummRow(int[][] matrix, int i, int n)
    {
      int sum = 0;
      for (int i0 = 0; i0 < n; i0++)
      {
        sum += matrix[i][i0];
      }

      return sum;
    }

    private static void PrintMatrix(int[,] matrix,int m,int n)
    {
      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
      }
    }

    private static int[][] ConvertInMat(int[,] mat,int m, int n)
    { 
      int[][] matrix=new int[m][];
      for (int i = 0; i < m; i++)
      {
        matrix[i] = new int[n];
        for (int j = 0; j < n; j++)
        {
          matrix[i][j] = mat[i, j];
        }
      }

      return matrix;
    }
    
    private static int[,] ConvertFromMat(int[][] mat,int m, int n)
    {
      int[,] matrix=new int[m,n];
      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          matrix[i,j] = Convert.ToInt32(mat[i][j]);
        }
      }

      return matrix;
    }
    
    private static void Start(int m, int n){
      int[,] mat= EnterMatrix(m,n);
      int[][] rez = ConvertInMat(mat,m,n);
      rez = MatrixCount(rez, m, n);
      Console.WriteLine();
      PrintMatrix(ConvertFromMat(rez,m,n),m,n);
    }
    
    public static void Main(string[] args)
    {
      int m, n;
      Console.WriteLine("Please, enter row and column");
      m = Convert.ToInt32(Console.ReadLine());
      n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Row: "+m+"  "+"Column:"+n);
      
      Start(m,n);

      //int[,] mat = {{1, 8, 4, 3}, {0, 10 , 15,6}, {7, 12, 2, 5}};
      
    }
  }
}