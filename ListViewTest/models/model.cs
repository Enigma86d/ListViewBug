using System.Collections.ObjectModel;

namespace ListViewTest.models
{
    public class Measurement
    {
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string Item4 { get; set; }

        public Measurement(int no)
        {
            Item1 = no.ToString();
            Item2 = (no+10).ToString();
            Item3 = (no+100).ToString();
            Item4 = (no + 1000).ToString();
        }
    }

    public class MeasurementCollection : ObservableCollection<Measurement>
    {
        public MeasurementCollection()
        {
        }
    }

}
