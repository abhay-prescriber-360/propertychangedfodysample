using Xamarin.Forms;

namespace propertychangedfodysample
{
    public partial class propertychangedfodysamplePage : ContentPage
    {
        private readonly propertychangedfodysamplePageModel _pageModel;

        public propertychangedfodysamplePage ()
        {
            InitializeComponent ();

            _pageModel = new propertychangedfodysamplePageModel ();
            _pageModel.SampleText = "Hello!";

            BindingContext = _pageModel;
        }

        void Handle_Clicked (object sender, System.EventArgs e)
        {
            _pageModel.SampleText = "Hello from INotifyPropertyChanged!";
        }

        void Handle_Clicked1 (object sender, System.EventArgs e)
        {
            Navigation.PushAsync (new propertychangedfodysampleWithFodyPage ());
        }
    }
}
