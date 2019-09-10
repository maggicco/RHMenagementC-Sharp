using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RHMenagment.Pages
{
    /// <summary>
    /// Interaction logic for Absence.xaml
    /// </summary>
    public partial class Absence : UserControl
    {
        public Absence()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Anée 2018",
                    Values = new ChartValues<double> {5,1,5,3,7,4,1, 4, 6, 5, 2 ,4 }
                },
                new LineSeries
                {
                    Title = "Anée 2019",
                    Values = new ChartValues<double> { 2,4,8,1,3,1,2, 6, 7, 3, 4 ,6 }
                    
                }

            };

            Labels = new[] { "January", "February", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" };
            YFormatter = value => value.ToString();


            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
    }
}
