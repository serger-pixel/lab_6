using System.Numerics;

namespace lab_6
{
    public partial class Form1 : Form
    {
        // Список значений
        List<int> _list;

        // Минимальное значение
        private const int MIN = 10;

        // Максимальное значение
        private const int MAX = 1000;

        // Длина списка
        private const int LENGTH = 100;

        // Создание списка
        private List<int> loadList()
        {
            Random random = new Random();
            List<int> localList = new List<int>(LENGTH);
            for (int i = 0; i < localList.Capacity; i++) { localList.Add(random.Next(MIN, MAX)); }
            return localList;
        }

        public Form1()
        {
            InitializeComponent();
        }

        // Запуск функций и получение результатов
        private void calculateRes_Click(object sender, EventArgs e)
        {
             _list = loadList();
            Task.Run(() =>Functions.viewResult(timeBox));
            Task.Run(()=>Functions.viewResult(sumBox, _list, Functions.OPERATION.SUM));
            Task.Run(() => Functions.viewResult(averageBox, _list, Functions.OPERATION.AVERAGE));
        }
    }
}