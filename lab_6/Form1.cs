using System.Numerics;
using System.Threading;
using System.Timers;

namespace lab_6
{
    public partial class Form1 : Form
    {
        // ������ ��������
        List<int> _list;

        // ����������� ��������
        private const int MIN = 10;

        // ������������ ��������
        private const int MAX = 1000;

        // ����� ������
        private const int LENGTH = 100;

        // �������� ������
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

        // ����������� ��������� ���������� ��. ��������
        private async void calculateAvg_Click(object sender, EventArgs e)
        {
            _list = loadList();
            await Task.Run(() => Functions.viewResult(averageBox, _list, Functions.OPERATION.AVERAGE));
        }

        // ����������� ��������� ����������� �������
        private void calculateTime_Click(object sender, EventArgs e)
        {
            calculateTime.Enabled = false;
            System.Threading.Timer timer = new System.Threading.Timer((Object state) => Functions.viewResult(timeBox), null, 0, 1000);
        }
        
        // ����������� ���������� ���������� �����
        private async void calculateSum_Click(object sender, EventArgs e)
        {
            _list = loadList();
            await Task.Run(() => Functions.viewResult(sumBox, _list, Functions.OPERATION.SUM));
        }



    }
}