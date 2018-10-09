using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Matrizes
{
    class Program
    {
        private static int[,] matUm = new int[2, 2];
        private static int[,] matDois = new int[2, 2];
        private static int[,] matTres = new int[2, 2];
        private static int[,] matQuatro = new int[2, 2];

        static void Main(string[] args)
        {
            CalculoMatrizes(matUm, matDois, matTres, matQuatro);
        }

        private static void CalculoMatrizes(int[,] mat1, int[,] mat2, int[,] mat3, int[,] mat4)
        {
            #region Matriz 01

            int determinanteMat01 = 0;
            Random r = new Random();

            while(determinanteMat01 != 4)
            {
                #region Carrega matriz

                //Atribui valores aleatórios a Matriz
                for (int i = 0; i < mat1.Length / 2; i++)
                {
                    for (int j = 0; j < mat1.Length / 2; j++)
                    {

                        mat1[i, j] = r.Next(1, 9);

                        if (i > 0 && j > 0)
                        {
                            if (mat1[i - 1, j - 1] == mat1[i, j])
                            {
                                mat1[i, j] = r.Next(1, 9);
                            }
                        }
                    }
                }

                #endregion

                #region Extração Diagonal Principal

                List<int> itensDiagonalPrincMat01 = new List<int>();

                for (int i = 0; i < mat1.Length / 2; i++)
                {
                    for (int j = 0; j < mat1.Length / 2; j++)
                    {
                        if (i == j)
                        {
                            itensDiagonalPrincMat01.Add(mat1[i, j]);
                        }
                    }
                }

                #endregion

                #region Extração Diagonal Secundária

                List<int> itensDiagonalSecundMat01 = new List<int>();
                int indiceCol = (mat1.Length / 2) - 1;

                for (int i = 0; i < mat1.Length / 2; i++)
                {
                    for (int j = indiceCol; j >= 0; j--)
                    {
                        if (i != j)
                        {
                            itensDiagonalSecundMat01.Add(mat1[i, j]);
                        }
                    }
                }

                #endregion

                #region Calculo Diagonal Principal

                int diagonalPrincipalMat01 = 0;

                for (int i = 0; i < itensDiagonalPrincMat01.Count; i++)
                {
                    diagonalPrincipalMat01 += itensDiagonalPrincMat01[i];
                }

                #endregion

                #region Calculo Diagonal Secundária

                int diagonalSecundariaMat01 = 0;

                for (int i = 0; i < itensDiagonalSecundMat01.Count; i++)
                {
                    diagonalSecundariaMat01 += itensDiagonalSecundMat01[i];
                }

                #endregion

                #region Calculo Determinante

                determinanteMat01 = diagonalPrincipalMat01 - diagonalSecundariaMat01;

                #endregion
            }

            #endregion

            #region Matriz 02

            int determinanteMat02 = 0;
            Random r2 = new Random();

            while (determinanteMat02 != 3)
            {
                #region Carrega matriz

                //Atribui valores aleatórios a Matriz
                for (int i = 0; i < mat2.Length / 2; i++)
                {
                    for (int j = 0; j < mat2.Length / 2; j++)
                    {

                        mat2[i, j] = r2.Next(1, 9);

                        if (i > 0 && j > 0)
                        {
                            if (mat2[i - 1, j - 1] == mat2[i, j])
                            {
                                mat2[i, j] = r2.Next(1, 9);
                            }
                        }
                    }
                }

                #endregion

                #region Extração Diagonal Principal

                List<int> itensDiagonalPrincMat02 = new List<int>();

                for (int i = 0; i < mat2.Length / 2; i++)
                {
                    for (int j = 0; j < mat2.Length / 2; j++)
                    {
                        if (i == j)
                        {
                            itensDiagonalPrincMat02.Add(mat2[i, j]);
                        }
                    }
                }

                #endregion

                #region Extração Diagonal Secundária

                List<int> itensDiagonalSecundMat02 = new List<int>();
                int indiceCol = (mat2.Length / 2) - 1;

                for (int i = 0; i < mat2.Length / 2; i++)
                {
                    for (int j = indiceCol; j >= 0; j--)
                    {
                        if (i != j)
                        {
                            itensDiagonalSecundMat02.Add(mat2[i, j]);
                        }
                    }
                }

                #endregion

                #region Calculo Diagonal Principal

                int diagonalPrincipalMat02 = 0;

                for (int i = 0; i < itensDiagonalPrincMat02.Count; i++)
                {
                    diagonalPrincipalMat02 += itensDiagonalPrincMat02[i];
                }

                #endregion

                #region Calculo Diagonal Secundária

                int diagonalSecundariaMat02 = 0;

                for (int i = 0; i < itensDiagonalSecundMat02.Count; i++)
                {
                    diagonalSecundariaMat02 += itensDiagonalSecundMat02[i];
                }

                #endregion

                #region Calculo Determinante

                determinanteMat02 = diagonalPrincipalMat02 - diagonalSecundariaMat02;

                #endregion
            }

            #endregion

            #region Matriz 03

            int determinanteMat03 = 0;
            Random r3 = new Random();

            while (determinanteMat03 != 5)
            {
                #region Carrega matriz

                //Atribui valores aleatórios a Matriz
                for (int i = 0; i < mat3.Length / 2; i++)
                {
                    for (int j = 0; j < mat3.Length / 2; j++)
                    {

                        mat3[i, j] = r3.Next(1, 9);

                        if (i > 0 && j > 0)
                        {
                            if (mat3[i - 1, j - 1] == mat3[i, j])
                            {
                                mat3[i, j] = r3.Next(1, 9);
                            }
                        }
                    }
                }

                #endregion

                #region Extração Diagonal Principal

                List<int> itensDiagonalPrincMat03 = new List<int>();

                for (int i = 0; i < mat3.Length / 2; i++)
                {
                    for (int j = 0; j < mat3.Length / 2; j++)
                    {
                        if (i == j)
                        {
                            itensDiagonalPrincMat03.Add(mat3[i, j]);
                        }
                    }
                }

                #endregion

                #region Extração Diagonal Secundária

                List<int> itensDiagonalSecundMat03 = new List<int>();
                int indiceCol = (mat3.Length / 2) - 1;

                for (int i = 0; i < mat3.Length / 2; i++)
                {
                    for (int j = indiceCol; j >= 0; j--)
                    {
                        if (i != j)
                        {
                            itensDiagonalSecundMat03.Add(mat3[i, j]);
                        }
                    }
                }

                #endregion

                #region Calculo Diagonal Principal

                int diagonalPrincipalMat03 = 0;

                for (int i = 0; i < itensDiagonalPrincMat03.Count; i++)
                {
                    diagonalPrincipalMat03 += itensDiagonalPrincMat03[i];
                }

                #endregion

                #region Calculo Diagonal Secundária

                int diagonalSecundariaMat03 = 0;

                for (int i = 0; i < itensDiagonalSecundMat03.Count; i++)
                {
                    diagonalSecundariaMat03 += itensDiagonalSecundMat03[i];
                }

                #endregion

                #region Calculo Determinante

                determinanteMat03 = diagonalPrincipalMat03 - diagonalSecundariaMat03;

                #endregion
            }

            #endregion

            #region Matriz 04

            int determinanteMat04 = 0;
            Random r4 = new Random();

            while (determinanteMat04 != 1)
            {
                #region Carrega matriz

                //Atribui valores aleatórios a Matriz
                for (int i = 0; i < mat4.Length / 2; i++)
                {
                    for (int j = 0; j < mat4.Length / 2; j++)
                    {

                        mat4[i, j] = r4.Next(1, 9);

                        if (i > 0 && j > 0)
                        {
                            if (mat4[i - 1, j - 1] == mat4[i, j])
                            {
                                mat4[i, j] = r4.Next(1, 9);
                            }
                        }
                    }
                }

                #endregion

                #region Extração Diagonal Principal

                List<int> itensDiagonalPrincMat04 = new List<int>();

                for (int i = 0; i < mat4.Length / 2; i++)
                {
                    for (int j = 0; j < mat4.Length / 2; j++)
                    {
                        if (i == j)
                        {
                            itensDiagonalPrincMat04.Add(mat4[i, j]);
                        }
                    }
                }

                #endregion

                #region Extração Diagonal Secundária

                List<int> itensDiagonalSecundMat04 = new List<int>();
                int indiceCol = (mat4.Length / 2) - 1;

                for (int i = 0; i < mat4.Length / 2; i++)
                {
                    for (int j = indiceCol; j >= 0; j--)
                    {
                        if (i != j)
                        {
                            itensDiagonalSecundMat04.Add(mat4[i, j]);
                        }
                    }
                }

                #endregion

                #region Calculo Diagonal Principal

                int diagonalPrincipalMat04 = 0;

                for (int i = 0; i < itensDiagonalPrincMat04.Count; i++)
                {
                    diagonalPrincipalMat04 += itensDiagonalPrincMat04[i];
                }

                #endregion

                #region Calculo Diagonal Secundária

                int diagonalSecundariaMat04 = 0;

                for (int i = 0; i < itensDiagonalSecundMat04.Count; i++)
                {
                    diagonalSecundariaMat04 += itensDiagonalSecundMat04[i];
                }

                #endregion

                #region Calculo Determinante

                determinanteMat04 = diagonalPrincipalMat04 - diagonalSecundariaMat04;

                #endregion
            }

            #endregion

            int result = determinanteMat01 + determinanteMat02 + determinanteMat03 + determinanteMat04;

            Console.WriteLine("\n\n");

            Console.WriteLine("O resultado das operações com as matrizes é: " + --result);

            Console.WriteLine("\n\n------------------------------------------------------\n\n");

            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();
        }
    }
}