using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        private IDialogService _dialogService;
        #endregion

        public IList<string> Texts { get; set; }

        public ICommand TestCommand { get; set; }

        public ListViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
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
            //Error
            _dialogService.ShowDialog("ListControl", new DialogParameters(),
                callback => 
                { 

                });
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
