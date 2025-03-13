using LiveCharts;
using LiveCharts.Wpf;

namespace _13032025_JW_RC
{
    public partial class Form1 : Form
    {
        public SeriesCollection SeriesCollection { get; set; }
        public List<double> values = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void myChart_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title="Nowy wykres",
                    Values =new ChartValues<double>()

                }

            };
            myChart.AxisX.Add(new Axis
            {
                Title = "Oœ X"
            });

            myChart.AxisY.Add(new Axis
            {
                Title = "oœ Y",
                LabelFormatter = value => value + "oC"
            });

            button2.Click += button2_Click;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double value = random.Next(0, 20);

            SeriesCollection[0].Values.Add(value);

            myChart.Series = SeriesCollection;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double value;

            SeriesCollection[0].Values.Clear();

            //SeriesCollection[0].Values.RemoveAt(0);

            for (int i = 0; i < 10; i++)
            {
                value = random.Next(0, 20);
                SeriesCollection[0].Values.Add((double)value);
            }

            myChart.Series = SeriesCollection;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double value = random.Next(0, 20);

            SeriesCollection[0].Values.RemoveAt(0);

            myChart.Series = SeriesCollection;

            value = random.Next(0, 20);
            SeriesCollection[0].Values.Add((double)value);

            myChart.Series = SeriesCollection;
        }
    }
}
