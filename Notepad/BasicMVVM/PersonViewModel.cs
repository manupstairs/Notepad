using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicMVVM
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private PersonModel personModel { get; set; }

        public Guid Id
        {
            get
            {
                return personModel.Id;
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                this.OnPropertyChanged();
            }
        }

        private DateTime birthday;

        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                this.OnPropertyChanged();
            }
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - Birthday.Year;
            }
        }

        public PersonViewModel()
        {
            this.InitData();
        }

        private void InitData()
        {
            this.personModel = new FakeDataService().GetPersonFromDatabase();
            this.Name = personModel.Name;
            this.Birthday = personModel.Birthday;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
