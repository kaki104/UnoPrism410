using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace UnoPrism410
{
    public class ListViewModel : BindableBase, IDialogAware
    {
        #region Title
        private string _title = "Notification";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        #endregion

        public IList<string> Texts { get; set; }

        public ICommand TestCommand { get; set; }

        public ListViewModel()
        {
            Texts = new List<string>
            {
                "Item1",
                "Item2",
                "Item3",
                "Item4",
                "Item5",
            };

            TestCommand = new DelegateCommand(OnTest);
        }

        private void OnTest()
        {
        }

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
        }
    }
}
