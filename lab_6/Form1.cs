using System.Numerics;
using System.Threading;
using System.Timers;

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

        // Отображение реультата нахождения ср. значения
        private async void calculateAvg_Click(object sender, EventArgs e)
        {
            _list = loadList();
            await Task.Run(() => Functions.viewResult(averageBox, _list, Functions.OPERATION.AVERAGE));
        }

        // Отображение реультата отображения времени
        private void calculateTime_Click(object sender, EventArgs e)
        {
            calculateTime.Enabled = false;
            System.Threading.Timer timer = new System.Threading.Timer((Object state) => Functions.viewResult(timeBox), null, 0, 1000);
        }
        
        // Отображение результата нахождения суммы
        private async void calculateSum_Click(object sender, EventArgs e)
        {
            _list = loadList();
            await Task.Run(() => Functions.viewResult(sumBox, _list, Functions.OPERATION.SUM));
        }



    }
}