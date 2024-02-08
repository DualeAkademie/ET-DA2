using Projekt511.Model;

namespace Projekt511;

// Quellen: https://ws-export.wmcloud.org/?lang=en&title=Pride_and_Prejudice_(1813)

public partial class MainWindow
{
    public MainWindow()
    {
        var modelTexte = new ModelTexte();
        var viewModel = new ViewModel.ViewModel(modelTexte, this);

        InitializeComponent();
        DataContext = viewModel;
    }
}
