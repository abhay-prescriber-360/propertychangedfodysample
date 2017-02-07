using PropertyChanged;

namespace propertychangedfodysample
{
    [ImplementPropertyChanged]
    public class propertychangedfodysampleWithFodyPageModel
    {
        public string SampleText {
            get;
            set;
        }
    }
}