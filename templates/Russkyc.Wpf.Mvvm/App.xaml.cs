using System;
using Russkyc.Wpf.Mvvm.ViewModels;
using Russkyc.Wpf.Mvvm.Views;

namespace Russkyc.Wpf.Mvvm;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
        
    /// <summary>
    /// Application Entry for Russkyc.Wpf.Mvvm
    /// </summary>
    public App()
    {
        var view = new MainView
        {
            DataContext = Activator.CreateInstance<MainViewModel>()
        };
            
        view.Show();
    }
        
}