using System.Threading;
using System.Windows.Controls;

namespace Projekt510;

public partial class MainWindow
{
    public CancellationTokenSource CancellationTokenSource { get; set; }

    private readonly ViewModel.ViewModel _viewModel;

    public MainWindow()
    {
        CancellationTokenSource = new CancellationTokenSource();
        

        _viewModel = new ViewModel.ViewModel(this, CancellationTokenSource);

        InitializeComponent();
        DataContext = _viewModel;

      //  DataGridHornerBin.Columns[0].Width = 200;
      //  DataGridHornerBin.Columns[1].Width = 200;
        //DataGridHornerHex.DataContext = _viewModel.HornerSchemaHex;
    }

    private void AnzahlByte_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is ComboBox s)
        {
            _viewModel.AnzahlByte = 1 + s.SelectedIndex;
        }
    }
}
