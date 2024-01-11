using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace Projekt521.ViewModel;

public partial class ViewModel
{
    [ObservableProperty] private bool _boolPv;
    [ObservableProperty] private bool _boolWp;
    [ObservableProperty] private bool _boolH0;
    [ObservableProperty] private bool _boolG0;
    [ObservableProperty] private bool _boolG1;
    [ObservableProperty] private bool _boolG2;
    [ObservableProperty] private bool _boolG3;
    [ObservableProperty] private bool _boolG4;
    [ObservableProperty] private bool _boolG5;
    [ObservableProperty] private bool _boolG6;
    [ObservableProperty] private bool _boolL0;
    [ObservableProperty] private bool _boolL1;
    [ObservableProperty] private bool _boolL2;
    [ObservableProperty] private bool _boolWpVonPv;
    [ObservableProperty] private bool _boolWpVomNetz;
    [ObservableProperty] private bool _boolWpVonPvAkku;
    [ObservableProperty] private bool _boolPvUeberschuss;
    [ObservableProperty] private bool _boolAkku;

    [ObservableProperty] private Brush? _brushPv;
    [ObservableProperty] private Brush? _brushWp;
    [ObservableProperty] private Brush? _brushH0;
    [ObservableProperty] private Brush? _brushG0;
    [ObservableProperty] private Brush? _brushG1;
    [ObservableProperty] private Brush? _brushG2;
    [ObservableProperty] private Brush? _brushG3;
    [ObservableProperty] private Brush? _brushG4;
    [ObservableProperty] private Brush? _brushG5;
    [ObservableProperty] private Brush? _brushG6;
    [ObservableProperty] private Brush? _brushL0;
    [ObservableProperty] private Brush? _brushL1;
    [ObservableProperty] private Brush? _brushL2;
    [ObservableProperty] private Brush? _brushWpvonPv;
    [ObservableProperty] private Brush? _brushWpvonPvAkku;
    [ObservableProperty] private Brush? _brushWpvomNetz;
    [ObservableProperty] private Brush? _brushPvUeberschuss;
    [ObservableProperty] private Brush? _brushAkku;


    [ObservableProperty] private double[]? _doubleZeitAchse;
    [ObservableProperty] private double[]? _doubleEnergiePv;
    [ObservableProperty] private double[]? _doubleEnergieWp;
    [ObservableProperty] private double[]? _doubleEnergieH0;
    [ObservableProperty] private double[]? _doubleEnergieG0;
    [ObservableProperty] private double[]? _doubleEnergieG1;
    [ObservableProperty] private double[]? _doubleEnergieG2;
    [ObservableProperty] private double[]? _doubleEnergieG3;
    [ObservableProperty] private double[]? _doubleEnergieG4;
    [ObservableProperty] private double[]? _doubleEnergieG5;
    [ObservableProperty] private double[]? _doubleEnergieG6;
    [ObservableProperty] private double[]? _doubleEnergieL0;
    [ObservableProperty] private double[]? _doubleEnergieL1;
    [ObservableProperty] private double[]? _doubleEnergieL2;
    [ObservableProperty] private double[]? _doubleEnergieWpVonPv;
    [ObservableProperty] private double[]? _doubleEnergieWpVonPvAkku;
    [ObservableProperty] private double[]? _doubleEnergieWpVomNetz;
    [ObservableProperty] private double[]? _doubleEnergiePvUeberschuss;
    [ObservableProperty] private double[]? _doubleEnergieAkku;
    [ObservableProperty] private double[]? _doubleEnergieflussAkku;

    [ObservableProperty] private string? _stringJahresMaximalLeistungPv;
    [ObservableProperty] private string? _stringJahresMaximalLeistungWp;
    [ObservableProperty] private string? _stringJahresMaximalLeistungH0;
    [ObservableProperty] private string? _stringJahresMaximalLeistungG0;
    [ObservableProperty] private string? _stringJahresMaximalLeistungG1;
    [ObservableProperty] private string? _stringJahresMaximalLeistungG2;
    [ObservableProperty] private string? _stringJahresMaximalLeistungG3;
    [ObservableProperty] private string? _stringJahresMaximalLeistungG4;
    [ObservableProperty] private string? _stringJahresMaximalLeistungG5;
    [ObservableProperty] private string? _stringJahresMaximalLeistungG6;
    [ObservableProperty] private string? _stringJahresMaximalLeistungL0;
    [ObservableProperty] private string? _stringJahresMaximalLeistungL1;
    [ObservableProperty] private string? _stringJahresMaximalLeistungL2;

    [ObservableProperty] private string? _stringGesamtEnergieWpVonPv;
    [ObservableProperty] private string? _stringGesamtEnergieWpVomNetz;
    [ObservableProperty] private string? _stringGesamtEnergiePvUeberschuss;
    [ObservableProperty] private string? _stringFensterEnergieWpVonPv;
    [ObservableProperty] private string? _stringFensterEnergieWpVonPvAkku;
    [ObservableProperty] private string? _stringFensterEnergieWpVomNetz;
    [ObservableProperty] private string? _stringFensterEnergiePvUeberschuss;
    [ObservableProperty] private string? _stringFensterEnergieWp;
    [ObservableProperty] private string? _stringFensterEnergiePv;
    [ObservableProperty] private string? _stringFensterEnergieAkkuLaden;
    [ObservableProperty] private string? _stringFensterEnergieAkkuEntladen;
    [ObservableProperty] private string? _stringFensterEnergieAkkuZyklen;

    [ObservableProperty] private string? _stringTooltipAkku;
    [ObservableProperty] private string? _stringTooltipPv;
    [ObservableProperty] private string? _stringTooltipWp;
    [ObservableProperty] private string? _stringTooltipH0;
    [ObservableProperty] private string? _stringTooltipG0;
    [ObservableProperty] private string? _stringTooltipG1;
    [ObservableProperty] private string? _stringTooltipG2;
    [ObservableProperty] private string? _stringTooltipG3;
    [ObservableProperty] private string? _stringTooltipG4;
    [ObservableProperty] private string? _stringTooltipG5;
    [ObservableProperty] private string? _stringTooltipG6;
    [ObservableProperty] private string? _stringTooltipL0;
    [ObservableProperty] private string? _stringTooltipL1;
    [ObservableProperty] private string? _stringTooltipL2;


    [ObservableProperty] private int _intJahresenergiePv;
    [ObservableProperty] private int _intJahresenergieWp;
    [ObservableProperty] private int _intJahresenergieH0;
    [ObservableProperty] private int _intJahresenergieG0;
    [ObservableProperty] private int _intJahresenergieG1;
    [ObservableProperty] private int _intJahresenergieG2;
    [ObservableProperty] private int _intJahresenergieG3;
    [ObservableProperty] private int _intJahresenergieG4;
    [ObservableProperty] private int _intJahresenergieG5;
    [ObservableProperty] private int _intJahresenergieG6;
    [ObservableProperty] private int _intJahresenergieL0;
    [ObservableProperty] private int _intJahresenergieL1;
    [ObservableProperty] private int _intJahresenergieL2;
    [ObservableProperty] private int _intEnergieAkku;
    [ObservableProperty] private int _intLeistungAkku;

    [ObservableProperty] private Visibility _visibilityJahresenergiePv;
    [ObservableProperty] private Visibility _visibilityJahresenergieWp;
    [ObservableProperty] private Visibility _visibilityJahresenergieH0;
    [ObservableProperty] private Visibility _visibilityJahresenergieG0;
    [ObservableProperty] private Visibility _visibilityJahresenergieG1;
    [ObservableProperty] private Visibility _visibilityJahresenergieG2;
    [ObservableProperty] private Visibility _visibilityJahresenergieG3;
    [ObservableProperty] private Visibility _visibilityJahresenergieG4;
    [ObservableProperty] private Visibility _visibilityJahresenergieG5;
    [ObservableProperty] private Visibility _visibilityJahresenergieG6;
    [ObservableProperty] private Visibility _visibilityJahresenergieL0;
    [ObservableProperty] private Visibility _visibilityJahresenergieL1;
    [ObservableProperty] private Visibility _visibilityJahresenergieL2;

    [ObservableProperty] private Visibility _visibilityWpvonPv;
    [ObservableProperty] private Visibility _visibilityWpvonPvAkku;
    [ObservableProperty] private Visibility _visibilityWpvomNetz;
    [ObservableProperty] private Visibility _visibilityPvUeberschuss;
    [ObservableProperty] private Visibility _visibilityAkku;

    [ObservableProperty] private DateTime _dateTimeStart;
    [ObservableProperty] private DateTime _dateTimeEnd;
}
