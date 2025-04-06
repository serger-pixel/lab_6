using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    abstract class Functions
    {
        public enum OPERATION
        {
            SUM, 
            AVERAGE
        }

        static int getSum(List<int> container)
        {
            int sum = 0;
            foreach (var item in container) { sum += item; }
            return sum;
        }

        static string getTime()
        {
            return DateTime.Now.ToString();
        }

        static int getAverage(List<int> container)
        {
            return getSum(container) / container.Capacity;
        }

        static void setBox<T>(T value, TextBox box) { box.Text = value.ToString(); }

        public static async void viewResult(TextBox box)
        {
            setBox<string>(getTime(), box);
        }

        public static async void viewResult(TextBox box, List<int> container, OPERATION type)
        {
            if (type == OPERATION.SUM) 
            {
                setBox<int>(getSum(container), box);
            }
            else
            {
                setBox<int>(getAverage(container), box);
            }
        }
    }
}
