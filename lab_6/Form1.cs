using System.Numerics;

namespace lab_6
{
    public partial class Form1 : Form
    {
        List<int> _list;

        private const int MIN = 10;

        private const int MAX = 1000;

        private const int LENGTH = 100;

        private async Task<List<int>> loadList()
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

        private async void calculateRes_Click(object sender, EventArgs e)
        {
             _list = await loadList();
            Functions.viewResult(timeBox);
            Functions.viewResult(sumBox, _list, Functions.OPERATION.SUM);
            Functions.viewResult(averageBox, _list, Functions.OPERATION.AVERAGE);

        }
    }
}
