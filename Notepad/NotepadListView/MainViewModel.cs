using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadListView
{
    public class MainViewModel
    {
        public List<NotepadPage> Pages { get; set; } = new List<NotepadPage>();

        public List<string> Titles { get; set; } = new List<string>();

        public MainViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                var title = "Title" + i;
                Titles.Add(title);

                var page = new NotepadPage
                {
                    Title = title
                };
                Pages.Add(page);
            }
        }
    }
}
