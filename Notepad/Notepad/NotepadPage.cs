using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
