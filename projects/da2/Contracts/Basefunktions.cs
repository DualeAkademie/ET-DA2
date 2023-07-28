using System.Windows.Controls;

namespace Contracts;

public static class Basefunktions
{
    public static (bool ergebnis, ClickMode clickModeTaster) ButtonClickMode(ClickMode clickMode) => clickMode == ClickMode.Press ? (true, ClickMode.Release) : (false, ClickMode.Press);
}
