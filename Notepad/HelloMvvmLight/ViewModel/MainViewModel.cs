using GalaSoft.MvvmLight;

namespace HelloMvvmLight.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private string helloWorld;

        public string HelloWorld
        {
            get { return helloWorld; }
            set
            {
                Set(ref helloWorld, value);
            }
        }


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
                HelloWorld = "HelloWorld in design view";
            }
            else
            {
                // Code runs "for real"
                HelloWorld = "HelloWorld in real view";
            }
        }
    }
}