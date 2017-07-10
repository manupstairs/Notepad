using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notepad
{
    public class NotepadPage : INotifyPropertyChanged
    {
        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                this.OnPropertyChanged();
            }
        }

        private string content;

        public string Content
        {
            get { return content; }
            set
            {
                content = value;
                this.OnPropertyChanged();
            }
        }

        private DateTime lastModifyDate;

        public DateTime LastModifyDate
        {
            get { return lastModifyDate; }
            set
            {
                lastModifyDate = value;
                this.OnPropertyChanged();
            }
        }

        private bool isSelected;

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                this.OnPropertyChanged();
            }
        }

        private bool isFavorite;

        public bool IsFavorite
        {
            get { return isFavorite; }
            set
            {
                isFavorite = value;
                this.OnPropertyChanged();
            }
        }

        private string imagePath;

        public string ImagePath
        {
            get { return imagePath; }
            set
            {
                imagePath = value;
                this.OnPropertyChanged();
            }
        }

        public ICommand FavoriteCommand { get; set; }

        public NotepadPage()
        {
            FavoriteCommand = new EasyCommand<NotepadPage>(Favorite);
        }

        private void Favorite(NotepadPage page)
        {
            IsFavorite = !IsFavorite;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
