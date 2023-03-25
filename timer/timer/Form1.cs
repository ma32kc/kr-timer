using System.Diagnostics;

namespace timer
{
    public partial class Form1 : Form
    {
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        static void StartTimer(int count)
        {
            int seconds = 0;
            while (true)
            {
                seconds++;
                Thread.Sleep(1000);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = count.ToString();
            count++;
            if (count % 30 == 0)
            {
                count = 0;
                Thread thread = new Thread(() => StartTimer(count));
                thread.Start();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}