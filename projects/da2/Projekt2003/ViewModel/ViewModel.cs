using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
// ReSharper disable UnusedMember.Local

namespace Projekt2003.ViewModel;

public partial class ViewModel : ObservableObject
{
    private readonly Model.Model _model;
    private readonly CancellationTokenSource _cancellationTokenSource;

    public ViewModel(Model.Model model, CancellationTokenSource cancellationTokenSource)
    {
        _model = model;

        ItemsList =
        [
            new ComboBoxItem() ,

            new ComboBoxItem { Content = "1", Tag = 1, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "2", Tag = 2, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "5", Tag = 5, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "10", Tag = 10, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "20", Tag = 20, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "100", Tag = 100, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center},
            new ComboBoxItem { Content = "200", Tag = 200, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center },
            new ComboBoxItem { Content = "1000", Tag = 1000, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center },
            new ComboBoxItem { Content = "2000", Tag = 2000, HorizontalContentAlignment = HorizontalAlignment.Right, VerticalContentAlignment = VerticalAlignment.Center }

        ];

        _cancellationTokenSource = cancellationTokenSource;

        Image00 = new BitmapImage();
        Image10 = new BitmapImage();
        Image20 = new BitmapImage();

        Image01 = new BitmapImage();
        Image11 = new BitmapImage();
        Image21 = new BitmapImage();

        Image02 = new BitmapImage();
        Image12 = new BitmapImage();
        Image22 = new BitmapImage();

        _ = Task.Run(VmTask);
    }
    private void VmTask()
    {
        while (!_cancellationTokenSource.IsCancellationRequested)
        {
            /*
            (Image00, Visibility00) = SetKachel(0, 0);
            (Image10, Visibility10) = SetKachel(1, 0);
            (Image20, Visibility20) = SetKachel(2, 0);

            (Image01, Visibility01) = SetKachel(0, 1);
            (Image11, Visibility11) = SetKachel(1, 1);
            (Image21, Visibility21) = SetKachel(2, 1);

            (Image02, Visibility02) = SetKachel(0, 2);
            (Image12, Visibility12) = SetKachel(1, 2);
            (Image22, Visibility22) = SetKachel(2, 2);
            */
            Thread.Sleep(50);
        }
    }
    private (BitmapImage?, Visibility) SetKachel(int x, int y)
    {
        _ = x;
        _ = y;

        return (null, Visibility.Visible);
    }
}
