namespace TabDemo
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class ListViewModel : INotifyPropertyChanged
    {
        private ItemViewModel selected;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<ItemViewModel> Items { get; } = new ObservableCollection<ItemViewModel>
        {
            new ItemViewModel { Name = "Johan" },
            new ItemViewModel { Name = "Joseph" },
        };

        public ItemViewModel Selected
        {
            get => this.selected;
            set
            {
                if (ReferenceEquals(value, this.selected))
                {
                    return;
                }

                this.selected = value;
                this.OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
