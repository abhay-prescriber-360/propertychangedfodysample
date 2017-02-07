using Xamarin.Forms;

namespace propertychangedfodysample
{
    public partial class propertychangedfodysampleWithFodyPage : ContentPage
    {
        private readonly propertychangedfodysampleWithFodyPageModel _pageModel;

        public propertychangedfodysampleWithFodyPage ()
        {
            InitializeComponent ();

            _pageModel = new propertychangedfodysampleWithFodyPageModel ();
            _pageModel.SampleText = "Hello again!";

            BindingContext = _pageModel;
        }

        void Handle_Clicked (object sender, System.EventArgs e)
        {
            _pageModel.SampleText = "Hello from PropertyChanged.Fody!";
        }
    }
}