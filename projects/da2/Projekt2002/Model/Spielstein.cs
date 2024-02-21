using System.Windows;
#pragma warning disable CS0169 // Field is never used

namespace Projekt2002.Model;

// ReSharper disable UnusedMember.Global
// ReSharper disable NotAccessedField.Local
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable ArrangeMethodOrOperatorBody
// ReSharper disable UnusedMember.Local
// ReSharper disable CollectionNeverUpdated.Local
#pragma warning disable IDE0022

public class Spielsteine(int zahl)
{
    private Visibility _sichtbarkeit;
    private string? _zahl = zahl.ToString();
}
