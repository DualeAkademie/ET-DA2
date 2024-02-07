using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace Projekt2001.ViewModel;

public partial class ViewModel
{
    [ObservableProperty] private Brush? _brush0;
    [ObservableProperty] private Brush? _brush1;
    [ObservableProperty] private Brush? _brush2;
    [ObservableProperty] private Brush? _brush3;
    [ObservableProperty] private Brush? _brush4;
    [ObservableProperty] private Brush? _brush5;
    [ObservableProperty] private Brush? _brush6;

    [ObservableProperty] private Brush? _brush00;
    [ObservableProperty] private Brush? _brush01;
    [ObservableProperty] private Brush? _brush02;
    [ObservableProperty] private Brush? _brush03;
    [ObservableProperty] private Brush? _brush04;
    [ObservableProperty] private Brush? _brush05;
    [ObservableProperty] private Brush? _brush06;

    [ObservableProperty] private Brush? _brush10;
    [ObservableProperty] private Brush? _brush11;
    [ObservableProperty] private Brush? _brush12;
    [ObservableProperty] private Brush? _brush13;
    [ObservableProperty] private Brush? _brush14;
    [ObservableProperty] private Brush? _brush15;
    [ObservableProperty] private Brush? _brush16;

    [ObservableProperty] private Brush? _brush20;
    [ObservableProperty] private Brush? _brush21;
    [ObservableProperty] private Brush? _brush22;
    [ObservableProperty] private Brush? _brush23;
    [ObservableProperty] private Brush? _brush24;
    [ObservableProperty] private Brush? _brush25;
    [ObservableProperty] private Brush? _brush26;

    [ObservableProperty] private Brush? _brush30;
    [ObservableProperty] private Brush? _brush31;
    [ObservableProperty] private Brush? _brush32;
    [ObservableProperty] private Brush? _brush33;
    [ObservableProperty] private Brush? _brush34;
    [ObservableProperty] private Brush? _brush35;
    [ObservableProperty] private Brush? _brush36;

    [ObservableProperty] private Brush? _brush40;
    [ObservableProperty] private Brush? _brush41;
    [ObservableProperty] private Brush? _brush42;
    [ObservableProperty] private Brush? _brush43;
    [ObservableProperty] private Brush? _brush44;
    [ObservableProperty] private Brush? _brush45;
    [ObservableProperty] private Brush? _brush46;

    [ObservableProperty] private Brush? _brush50;
    [ObservableProperty] private Brush? _brush51;
    [ObservableProperty] private Brush? _brush52;
    [ObservableProperty] private Brush? _brush53;
    [ObservableProperty] private Brush? _brush54;
    [ObservableProperty] private Brush? _brush55;
    [ObservableProperty] private Brush? _brush56;

    [ObservableProperty] private Brush? _brush60;
    [ObservableProperty] private Brush? _brush61;
    [ObservableProperty] private Brush? _brush62;
    [ObservableProperty] private Brush? _brush63;
    [ObservableProperty] private Brush? _brush64;
    [ObservableProperty] private Brush? _brush65;
    [ObservableProperty] private Brush? _brush66;



    [ObservableProperty] private Thickness? _thickness0;
    [ObservableProperty] private Thickness? _thickness1;
    [ObservableProperty] private Thickness? _thickness2;
    [ObservableProperty] private Thickness? _thickness3;
    [ObservableProperty] private Thickness? _thickness4;
    [ObservableProperty] private Thickness? _thickness5;
    [ObservableProperty] private Thickness? _thickness6;

    [ObservableProperty] private Thickness? _thickness00;
    [ObservableProperty] private Thickness? _thickness01;
    [ObservableProperty] private Thickness? _thickness02;
    [ObservableProperty] private Thickness? _thickness03;
    [ObservableProperty] private Thickness? _thickness04;
    [ObservableProperty] private Thickness? _thickness05;
    [ObservableProperty] private Thickness? _thickness06;

    [ObservableProperty] private Thickness? _thickness10;
    [ObservableProperty] private Thickness? _thickness11;
    [ObservableProperty] private Thickness? _thickness12;
    [ObservableProperty] private Thickness? _thickness13;
    [ObservableProperty] private Thickness? _thickness14;
    [ObservableProperty] private Thickness? _thickness15;
    [ObservableProperty] private Thickness? _thickness16;

    [ObservableProperty] private Thickness? _thickness20;
    [ObservableProperty] private Thickness? _thickness21;
    [ObservableProperty] private Thickness? _thickness22;
    [ObservableProperty] private Thickness? _thickness23;
    [ObservableProperty] private Thickness? _thickness24;
    [ObservableProperty] private Thickness? _thickness25;
    [ObservableProperty] private Thickness? _thickness26;

    [ObservableProperty] private Thickness? _thickness30;
    [ObservableProperty] private Thickness? _thickness31;
    [ObservableProperty] private Thickness? _thickness32;
    [ObservableProperty] private Thickness? _thickness33;
    [ObservableProperty] private Thickness? _thickness34;
    [ObservableProperty] private Thickness? _thickness35;
    [ObservableProperty] private Thickness? _thickness36;

    [ObservableProperty] private Thickness? _thickness40;
    [ObservableProperty] private Thickness? _thickness41;
    [ObservableProperty] private Thickness? _thickness42;
    [ObservableProperty] private Thickness? _thickness43;
    [ObservableProperty] private Thickness? _thickness44;
    [ObservableProperty] private Thickness? _thickness45;
    [ObservableProperty] private Thickness? _thickness46;

    [ObservableProperty] private Thickness? _thickness50;
    [ObservableProperty] private Thickness? _thickness51;
    [ObservableProperty] private Thickness? _thickness52;
    [ObservableProperty] private Thickness? _thickness53;
    [ObservableProperty] private Thickness? _thickness54;
    [ObservableProperty] private Thickness? _thickness55;
    [ObservableProperty] private Thickness? _thickness56;

    [ObservableProperty] private Thickness? _thickness60;
    [ObservableProperty] private Thickness? _thickness61;
    [ObservableProperty] private Thickness? _thickness62;
    [ObservableProperty] private Thickness? _thickness63;
    [ObservableProperty] private Thickness? _thickness64;
    [ObservableProperty] private Thickness? _thickness65;
    [ObservableProperty] private Thickness? _thickness66;


    [ObservableProperty] private Visibility? _visibility0;
    [ObservableProperty] private Visibility? _visibility1;
    [ObservableProperty] private Visibility? _visibility2;
    [ObservableProperty] private Visibility? _visibility3;
    [ObservableProperty] private Visibility? _visibility4;
    [ObservableProperty] private Visibility? _visibility5;
    [ObservableProperty] private Visibility? _visibility6;

    [ObservableProperty] private Visibility? _visibility00;
    [ObservableProperty] private Visibility? _visibility01;
    [ObservableProperty] private Visibility? _visibility02;
    [ObservableProperty] private Visibility? _visibility03;
    [ObservableProperty] private Visibility? _visibility04;
    [ObservableProperty] private Visibility? _visibility05;
    [ObservableProperty] private Visibility? _visibility06;

    [ObservableProperty] private Visibility? _visibility10;
    [ObservableProperty] private Visibility? _visibility11;
    [ObservableProperty] private Visibility? _visibility12;
    [ObservableProperty] private Visibility? _visibility13;
    [ObservableProperty] private Visibility? _visibility14;
    [ObservableProperty] private Visibility? _visibility15;
    [ObservableProperty] private Visibility? _visibility16;

    [ObservableProperty] private Visibility? _visibility20;
    [ObservableProperty] private Visibility? _visibility21;
    [ObservableProperty] private Visibility? _visibility22;
    [ObservableProperty] private Visibility? _visibility23;
    [ObservableProperty] private Visibility? _visibility24;
    [ObservableProperty] private Visibility? _visibility25;
    [ObservableProperty] private Visibility? _visibility26;

    [ObservableProperty] private Visibility? _visibility30;
    [ObservableProperty] private Visibility? _visibility31;
    [ObservableProperty] private Visibility? _visibility32;
    [ObservableProperty] private Visibility? _visibility33;
    [ObservableProperty] private Visibility? _visibility34;
    [ObservableProperty] private Visibility? _visibility35;
    [ObservableProperty] private Visibility? _visibility36;

    [ObservableProperty] private Visibility? _visibility40;
    [ObservableProperty] private Visibility? _visibility41;
    [ObservableProperty] private Visibility? _visibility42;
    [ObservableProperty] private Visibility? _visibility43;
    [ObservableProperty] private Visibility? _visibility44;
    [ObservableProperty] private Visibility? _visibility45;
    [ObservableProperty] private Visibility? _visibility46;

    [ObservableProperty] private Visibility? _visibility50;
    [ObservableProperty] private Visibility? _visibility51;
    [ObservableProperty] private Visibility? _visibility52;
    [ObservableProperty] private Visibility? _visibility53;
    [ObservableProperty] private Visibility? _visibility54;
    [ObservableProperty] private Visibility? _visibility55;
    [ObservableProperty] private Visibility? _visibility56;

    [ObservableProperty] private Visibility? _visibility60;
    [ObservableProperty] private Visibility? _visibility61;
    [ObservableProperty] private Visibility? _visibility62;
    [ObservableProperty] private Visibility? _visibility63;
    [ObservableProperty] private Visibility? _visibility64;
    [ObservableProperty] private Visibility? _visibility65;
    [ObservableProperty] private Visibility? _visibility66;
}
