using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaApplication1.ViewModels;
using AvaloniaApplication1.Views;
using ViewModelLibraries;

namespace AvaloniaApplication1
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                //desktop.MainWindow = new MainWindow // ������� ��� ����
                desktop.MainWindow = new ViewLibrary.Window1
                {
                    //DataContext = new MainWindowViewModel()  // ������� - �� ����� VM
                    DataContext = new ViewModelLibraries.MainWindowViewModel(), // VM �� �������
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
