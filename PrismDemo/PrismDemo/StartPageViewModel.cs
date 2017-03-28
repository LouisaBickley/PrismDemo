using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismDemo
{
    public class StartPageViewModel : BindableBase
    {
        public ObservableCollection<string> People { get; set; }

        public StartPageViewModel()
        {
            People = new ObservableCollection<string>();
            People.Add("John");
            People.Add("Tom");
            People.Add("Kate");
            People.Add("Mike");
        }

        public DelegateCommand<string> PersonSelectedCommand => new DelegateCommand<string>(OnPersonSelectedCommandExecuted);        
        void OnPersonSelectedCommandExecuted(string name)
        {
            Debug.WriteLine("Hi " + name + "!");
        }
    }
}
