using System;
using System.Collections.Generic;
using System.Text;

namespace AllLabs.Lab5
{
    class Matrix
    {
        private int _stroki;
        private int _stolbi;
        private int[,] _massiv;

        public Matrix(int stroki, int stolbi)
        {
            _stroki = stroki;
            _stolbi = stolbi;
            _massiv = new int[stroki, stolbi];
        }

        public void Random()
        {
            Random rnd = new Random();
            for (int i = 0; i < _stroki; i++)
            {
                for (int j = 0; j < _stolbi; j++)
                {
                    _massiv[i, j] = rnd.Next(0, 100);

                }
            }

        }
        public void Print()
        {
            for (int i = 0; i < _stroki; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < _stolbi; j++)
                {
                    Console.Write(_massiv[i, j] + "\t");
                }
            }

        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < _massiv.GetLength(0); i++)
            {
                for (int j = 0; j < _massiv.GetLength(1); j++)
                {
                    sum += _massiv[i, j];
                }
            }
            return sum;
        }
        public void GlavDiag()
        {
            for (int i = 0; i < _stroki; i++)
            {
                for (int j = 0; j < _stolbi; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(_massiv[i, i]);
                    }
                }
            }

        }

        public void PassivDiag()
        {
            for (int i = 0; i < _massiv.GetLength(0); i++)
            {
                for (int j = 0; j < _massiv.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(_massiv[i, _massiv.GetLength(0) - i - 1]);
                    }
                }
            }

        }
    }
}
