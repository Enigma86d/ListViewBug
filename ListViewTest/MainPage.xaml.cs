using ListViewTest.models;

namespace ListViewTest
{
    public partial class MainPage : ContentPage
    {
        private MeasurementCollection data = new MeasurementCollection();

        public MainPage()
        {
            InitializeComponent();

            MyListView.ItemsSource = data;
            data.Add(new Measurement(0));
            data.Add(new Measurement(1));
            data.Add(new Measurement(2));
            data.Add(new Measurement(3));
            data.Add(new Measurement(4));
            data.Add(new Measurement(5));
            data.Add(new Measurement(6));
            data.Add(new Measurement(7));
            data.Add(new Measurement(8));
            data.Add(new Measurement(9));
        }

    }

}
