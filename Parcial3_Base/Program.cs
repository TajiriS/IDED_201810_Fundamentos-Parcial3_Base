﻿using System;

namespace Parcial3_Base
{
    public struct Centro
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Centro(float x, float y)
        {
            X = x;
            Y = y;
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            //Puede usar este main para probar sus métodos.
            Program myProgram = new Program();

            Console.WriteLine("Presione Enter para salir");
            Console.ReadLine();
        }

        #region EASY

        // VALOR DE LOS SIGUIENTES NUMERALES: 0.5 / 5.0

        /// <summary>
        /// Determina si dos matrices pueden sumarse
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns>'true' si las matrices pueden sumarse, 'false' de otro modo</returns>
        public bool SePuedenSumarMatrices(int[,] A, int[,] B)
        {
            if (A.GetLength(0) == B.GetLength(0) && A.GetLength(1) == B.GetLength(1))
            {
                return true;
            }

            if (A.GetLength(0) == 0 || A.GetLength(1) == 0 || B.GetLength(0) == 0 || B.GetLength(1) == 0) 
            {
                return false;
            }

            else
            {
                return false;
            }
        }

        /// <summary>
        /// Retorna el promedio aritmético de los elementos en  arr
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public float PromedioDeArreglo(int[] arr)
        {
            return 0F;
        }

        /// <summary>
        /// Determina cuántas veces aparece char en input
        /// </summary>
        /// <param name="input"></param>
        /// <param name="car"></param>
        /// <returns>La cantidad de veces que aparece char en input</returns>
        public int ConteoDeCaracter(string input, char car)
        {
            return 0;
        }

        #endregion EASY

        #region MEDIUM

        // VALOR DE LOS SIGUIENTES NUMERALES: 1.0 / 5.0

        /// <summary>
        /// Retorna otro arreglo cuyos elementos tengan los mismos que arr, pero con orden invertido.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>Un arreglo cuyos elementos están en orden inverso a arr</returns>
        public int[] InvertirArreglo(int[] arr)
        {
            int a = 0;
            int e = 0;
            int b = 1;
            int d = 0;
            int c = 0;

            if (arr.Length >= 0)
            {
                

                while (a <= arr.Length)
                {
                    d = arr[b];
                    arr[b] = arr[e];
                    arr[e] = d;
                    a += 1;
                    e += 1;
                    b += 1;
                }

                while (a == arr.Length && c < arr.Length)
                {
                    c += 1;
                    a = c;
                    e = 0;
                    b = 1;

                }

                if (c == arr.Length)
                {
                    return arr;//return null;
                }
                else
                {
                    return arr;
                }
            }
            else
            {
                return arr;
            }

        }

        /// <summary>
        /// Determina si un string es palíndromo
        /// Un palíndromo es una palabra que se escribe igual al derecho y al revés
        /// </summary>
        /// <param name="input"></param>
        /// <returns>'true' si input es palíndromo, `false` de otro modo</returns>
        public bool EsPalindromo(string input)
        {
            int b = input.Length;
            int a = 0;
            bool one = false;

            while (a <= input.Length && b >= 0)
            {
                if(input[a] == input[b])
                {
                    one = true;
                }
                else
                {
                   
                }
                a += 1;
                b -= 1;
            }

            if (a == input.Length && b == 0 && one == true)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        /// <summary>
        /// Calcula el n-ésimo término de la serie de Fibonacci, basado en índice 0
        /// </summary>
        /// <param name="n"></param>
        /// <returns>El número correspondiente a la posición n en la serie de Fibonacci</returns>
        public int CalcularFibonacciEn(int n)
        {
            return 0;
        }

        /// <summary>
        /// Retorna la matriz resultada de multiplicar A x B, si es posible hacer la operación.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns>La matriz AxB</returns>
        public int[,] MultiplicarMatrices(int[,] A, int[,] B)
        {
            return null;
        }

        #endregion MEDIUM

        #region HARD

        //VALOR DE LOS SIGUIENTES NUMERALES: 1.5 / 5.0

        /// <summary>
        ///  Devuelve un string que indique cuántas horas, minutos y segundos hay dada la cantidad total de segundos
        ///  Recuerde: 1 hr = 3600 segs.
        /// </summary>
        /// <param name="totalSegs"></param>
        /// <returns>Un string indicando cuántas horas, minutos y segundos hay en totalSegs</returns>
        public string FormatearTiempo(int totalSegs)
        {
            int hrs = 0;
            int mins = 0;
            int segs = 0;

            // hrs = totalSegs/3600;
            // mins = 62/60;
            //mins = totalSegs%60;
            // segs = totalSegs%1;
            if (totalSegs >= 60)
            {
                mins = totalSegs / 60;
                segs = totalSegs % 60;
            }
            if (mins >= 60)
            {
                hrs = mins / 60;
                mins = mins % 60;
            }
            return string.Format("{0} hrs : {1} mins : {2} segs", hrs, mins, segs);
        }

        /// <summary>
        /// Determina si dos circunferencias se tocan en algún punto, dados sus radios y centros.
        /// Recuerde, la distancia entre dos puntos está dada por la fórmula
        /// d^2 = [(x2 - x1)^2] + [(y2 - y1)^2]
        /// </summary>
        /// <param name="c1">El centro de la primera circunferencia</param>
        /// <param name="r1">El radio de la primera circunferencia</param>
        /// <param name="c2">El centro de la segunda circunferencia</param>
        /// <param name="r2">El radio de la segunda circunferencia</param>
        /// <returns>'true' si hay algún punto en que las esferas se toquen, 'false' de otro modo</returns>
        public bool HayColisión(Centro c1, float r1, Centro c2, float r2)
        {
            return false;
        }

        /// <summary>
        /// Determina el próximo número que sea primo a mayor que n
        /// </summary>
        /// <param name="n"></param>
        /// <returns>El primer número primo mayor que n</returns>
        public int ProximoPrimo(int n)
        {
            return 0;
        }

        /// <summary>
        /// Combina los elementos de dos matrices A y B de dimensiones iguales,
        /// de manera que los elementos de la diagonal sean
        /// los elementos de la diagonal de A, y el resto los de B
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public int[,] CombinaMatrices(int[,] A, int[,] B)
        {
            return null;
        }

        #endregion HARD
    }
}