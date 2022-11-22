using System.ComponentModel;
namespace WPF_LibraryApplication.Widok
{
    public abstract class ObserveObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(params string[] nazwy)
        {

            if(PropertyChanged!=null)
            {
                foreach (var item in nazwy)
                {
                    PropertyChanged(this,new PropertyChangedEventArgs(item));
                }
            }

            
        }


    }


}
