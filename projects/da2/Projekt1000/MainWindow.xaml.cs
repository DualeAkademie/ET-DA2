using System.ComponentModel;

namespace Projekt1000;

// https://learn.microsoft.com/en-us/ef/core/get-started/wpf#test-the-wpf-application


public partial class MainWindow
{
    public ViewModel.ViewModel ViewModel { get; set; }
    public DbContext.DbContext DbContext { get; set; }

    public MainWindow()
    {
        ViewModel = new ViewModel.ViewModel(this);
        DbContext = new DbContext.DbContext(ViewModel, this);

        InitializeComponent();
        DataContext = ViewModel;
    }
    protected override void OnClosing(CancelEventArgs e) => DbContext.DbClose();
}
