using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelLibraries
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!(VM из отдельного решения)";
    }
}
