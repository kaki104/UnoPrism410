using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace UnoPrism410.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        public ICommand ShowCommand { get; set; }

        private IDialogService _dialogService;

        public ShellViewModel(IDialogService dialogService)
        {
            Title = "Main Page";

            ShowCommand = new DelegateCommand(OnShow);
            _dialogService = dialogService;
        }

        private void OnShow()
        {
            _dialogService.ShowDialog("ListControl", null,
                r => 
                {
                    if (r.Result != ButtonResult.OK) return;
                });
        }
    }
}
