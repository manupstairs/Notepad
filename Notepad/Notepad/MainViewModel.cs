using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notepad
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand AddCommand { get; set; }

        public ICommand DeleteCommand { get; set; }

        public ICommand SingleDeleteCommand { get; set; }

        public ICommand SelectCommand { get; set; }

        private bool isMultipleSelect;

        public bool IsMultipleSelect
        {
            get { return isMultipleSelect; }
            set
            {
                isMultipleSelect = value;
                this.OnPropertyChanged();
            }
        }

        private NotepadPage selectedItem;

        public NotepadPage SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                this.OnPropertyChanged();
            }
        }

        public ObservableCollection<NotepadPage> Pages { get; set; } = new ObservableCollection<NotepadPage>();

        public MainViewModel()
        {
            AddCommand = new EasyCommand<object>(Add);
            DeleteCommand = new EasyCommand<object>(Delete);
            SelectCommand = new EasyCommand<object>(Select);
            SingleDeleteCommand = new EasyCommand<object>(SingleDelete);

            for (int i = 0; i < 10; i++)
            {
                var page = new NotepadPage
                {
                    Title = "Title" + i,
                    LastModifyDate = DateTime.Now,
                    ImagePath = "Assets/chushibiao.jpg",
                    Content = @"先帝创业未半而中道崩殂，今天下三分，益州疲弊，此诚危急存亡之秋也。然侍卫之臣不懈于内，忠志之士忘身于外者，盖追先帝之殊遇，欲报之于陛下也。诚宜开张圣听，以光先帝遗德，恢弘志士之气，不宜妄自菲薄，引喻失义，以塞忠谏之路也。 宫中府中，俱为一体，陟罚臧否，不宜异同。若有作奸犯科及为忠善者，宜付有司论其刑赏，以昭陛下平明之理，不宜偏私，使内外异法也。 侍中侍郎郭攸之、费祎、董允等，此皆良实，志虑忠纯，是以先帝简拔以遗陛下。愚以为宫中之事，事无大小，悉以咨之，然后施行，必能裨补阙漏，有所广益。 将军向宠，性行淑均，晓畅军事，试用于昔日，先帝称之曰能，是以众议举宠为督。愚以为营中之事，悉以咨之，必能使行阵和睦，优劣得所。"
                };
                Pages.Add(page);
            }
        }

        private void SingleDelete(object obj)
        {
            if (SelectedItem != null)
            { 
                Pages.Remove(SelectedItem);
            }
        }

        private void Delete(object obj)
        {
            var removeItems = Pages.Where(_ => _.IsSelected).ToList();
            foreach (var item in removeItems)
            {
                Pages.Remove(item);
            }
        }

        private void Select(object obj)
        {
            IsMultipleSelect = !IsMultipleSelect;
        }

        private void Add(object obj)
        {
            var page = new NotepadPage
            {
                Title = "New Page",
                LastModifyDate = DateTime.Now
            };
            Pages.Add(page);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
