using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_Task
{
    /// <summary>
    /// Класс, реализуюший алгоритм Евклида для вычисления НОД двух целых чисел. Также содержит перегруженные методы 
    /// вычисления НОД для трех, четырех и пяти целых чисел; алгоритм Стейна; метод, подготавливающий данные для построения гистограммы.
    /// </summary>
    public class GCD_Program
    {

        /// <summary>
        /// Метод, реализующий алгоритм Евклида для двух целых чисел
        /// </summary>
        /// <param name="x1">Первое число</param>
        /// <param name="x2">Второе число</param>
        /// <param name="leadTime">Выходной параметр, содержащий затраченное время на выполнение алгоритма</param>
        /// <returns></returns>
        public int Euclid(int x1, int x2, out double leadTime)
        {
            DateTime start = DateTime.Now;

            x1 = Math.Abs(x1);
            x2 = Math.Abs(x2);

            if (x1 == x2)
            {
                DateTime finish1 = DateTime.Now;
                long elapsedTicks1 = finish1.Ticks - start.Ticks;
                double time1 = Convert.ToDouble(elapsedTicks1);
                leadTime = time1 / 10;
                return x1;
            }

            if (x1 == 0 || x2 == 0)
            {
                DateTime finish1 = DateTime.Now;
                long elapsedTicks1 = finish1.Ticks - start.Ticks;
                double time1 = Convert.ToDouble(elapsedTicks1);
                leadTime = time1 / 10;
                return 0;
            }

            while (x1 != 0 && x2 != 0)
            {
                if (x1 > x2)
                {
                    x1 = x1 % x2;
                }
                else
                {
                    x2 = x2 % x1;
                }
            }

            DateTime finish = DateTime.Now;
            long elapsedTicks = finish.Ticks - start.Ticks;
            double time = Convert.ToDouble(elapsedTicks);
            leadTime = time / 10;
            return x1+x2;
        }
        /// <summary>
        /// Метод, реализующий алгоритм Евклида для трех чисел
        /// </summary>
        /// <param name="x1">Первое число</param>
        /// <param name="x2">Второе число</param>
        /// <param name="x3">Третье число</param>
        /// <returns></returns>
        public int Euclid(int x1, int x2, int x3)
        {

            int[] mas = { Math.Abs(x1), Math.Abs(x2), Math.Abs(x3) };
            int nulls = 0;
            int min = mas[1], max = mas[1];
            int imin = 1; int imax = 1;
            while (nulls != mas.Length - 1)
            {
                min = mas[imin]; max = mas[imin];
                imax = imin;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] == 0) continue;
                    if (mas[i] < min)
                    {
                        min = mas[i];
                        imin = i;
                    }
                    if (mas[i] > max)
                    {
                        max = mas[i];
                        imax = i;
                    }
                }

                max = max % min;
                if (max == 0)
                {
                    Array.Clear(mas, imax, 1);
                    nulls++;
                }
                mas[imax] = max;

            }
            return mas[imin];
        }
        /// <summary>
        ///  Метод, реализующий алгоритм Евклида для четырех чисел
        /// </summary>
        /// <param name="x1">Первое число</param>
        /// <param name="x2">Второе число</param>
        /// <param name="x3">Третье число</param>
        /// <param name="x4">Четвертое число</param>
        /// <returns></returns>
        public int Euclid(int x1, int x2, int x3,int x4)
        {

            int[] mas = { Math.Abs(x1), Math.Abs(x2), Math.Abs(x3), Math.Abs(x4) };
            int nulls = 0;
            int min = mas[1], max = mas[1];
            int imin = 1; int imax = 1;
            while (nulls!=mas.Length-1)
            {
                min = mas[imin]; max = mas[imin];
                imax = imin;
                for(int i=0; i < mas.Length; i++)
                {
                    if (mas[i] == 0) continue;
                    if (mas[i] < min)
                    {
                        min = mas[i];
                        imin = i;
                    }
                    if (mas[i] > max) 
                    { 
                        max = mas[i];
                        imax = i;
                    }
                }

                max = max % min;
                if(max == 0)
                {
                    Array.Clear(mas, imax, 1);
                    nulls++;
                }
                mas[imax] = max;
                
            }
            return mas[imin];
        }

        /// <summary>
        ///  Метод, реализующий алгоритм Евклида для пяти чисел
        /// </summary>
        /// <param name="x1">Первое число</param>
        /// <param name="x2">Второе число</param>
        /// <param name="x3">Третье число</param>
        /// <param name="x4">Четвертое число</param>
        /// <param name="x5">Пятое число</param>
        /// <returns></returns>
        public int Euclid(int x1, int x2, int x3, int x4, int x5)
        {
            int[] mas = { Math.Abs(x1), Math.Abs(x2), Math.Abs(x3), Math.Abs(x4), Math.Abs(x5) };
            int nulls = 0;
            int min = mas[1], max = mas[1];
            int imin = 1; int imax = 1;
            while (nulls != mas.Length - 1)
            {
                min = mas[imin]; max = mas[imin];
                imax = imin;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] == 0) continue;
                    if (mas[i] < min)
                    {
                        min = mas[i];
                        imin = i;
                    }
                    if (mas[i] > max)
                    {
                        max = mas[i];
                        imax = i;
                    }
                }

                max = max % min;
                if (max == 0)
                {
                    Array.Clear(mas, imax, 1);
                    nulls++;
                }
                mas[imax] = max;

            }
            return mas[imin];
        }

        /// <summary>
        ///  Метод, реализующий алгоритм Стейна для двух чисел
        /// </summary>
        /// <param name="x1">Первое число</param>
        /// <param name="x2">Второе число</param>
        /// <param name="leadTime"></param>
        /// <returns></returns>
        public int Stein(int x1, int x2, out double leadTime)
        {
            DateTime start = DateTime.Now;
            x1 = Math.Abs(x1);
            x2 = Math.Abs(x2);
            int k = 1;
            while ((x1 != 0) && (x2 != 0))
            {
                while ((x1 % 2 == 0) && (x2 % 2 == 0))
                {
                    x1 /= 2;
                    x2 /= 2;
                    k *= 2;
                }
                while (x1 % 2 == 0) x1 /= 2;
                while (x2 % 2 == 0) x2 /= 2;
                if (x1 >= x2) x1 -= x2; 
                else x2 -= x1;
            }

            DateTime finish = DateTime.Now;
            long elapsedTicks = finish.Ticks - start.Ticks;
            double time = Convert.ToDouble(elapsedTicks);
            leadTime = time / 10;
            return x2 * k;

        }

        /// <summary>
        /// Метод, выводящий на экран информацию о среднем времени выполнения алгоритмов
        /// </summary>
        public void Info()
        {
            double averageTimeEuclid = 0;
            double averageTimeStein = 0;
            int[,] mas = { { 144, 540 }, { 504 , 216} , { 117, 156 } };
            for (int i=0; i<3; i++)
            {
                double time;
                Euclid(mas[i, 0], mas[i, 1],out time);
                averageTimeEuclid += time;

                Stein(mas[i, 0], mas[i, 1], out time);
                averageTimeStein += time;
            }
            averageTimeEuclid /= 3;
            averageTimeStein  /= 3;

            Console.WriteLine("Average lead time of Euclid algorithm: {0}", averageTimeEuclid);
            Console.WriteLine("Average lead time of Stein algorithm: {0}", averageTimeStein);
        }
    }
}
