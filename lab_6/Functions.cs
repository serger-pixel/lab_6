using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    // Абстрактный класс для функций
    abstract class Functions
    {
        // Типы операций суммирования и нахождения среднего значения
        public enum OPERATION
        {
            SUM, 
            AVERAGE
        }

        // Суммирование элементов списка
        static int getSum(List<int> container)
        {
            int sum = 0;
            foreach (var item in container) { sum += item; }
            return sum;
        }

        // Получение системного времени
        static string getTime()
        {
            return DateTime.Now.ToString();
        }

        // Получение среднего значения
        static int getAverage(List<int> container)
        {
            return getSum(container) / container.Capacity;
        }

        // Установка результата в textBox
        static void setBox<T>(T value, TextBox box) { box.Text = value.ToString(); }

        // Отображение результата получения системного времени
        public static  void viewResult(TextBox box)
        {
            setBox<string>(getTime(), box);
        }

        // Отображение результата в зависимости от типа
        public static void viewResult(TextBox box, List<int> container, OPERATION type)
        {
            if (type == OPERATION.SUM) 
            {
                setBox<int>(getSum(container), box);
            }            else
            {
                setBox<int>(getAverage(container), box);
            }
        }
    }
}