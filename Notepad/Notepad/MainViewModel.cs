using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    public class MainViewModel
    {
        public ObservableCollection<NotepadPage> Pages { get; set; } = new ObservableCollection<NotepadPage>();

        public MainViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                var page = new NotepadPage
                {
                    Title = "Title" + i
                };
                Pages.Add(page);
            }
        }
    }
}
