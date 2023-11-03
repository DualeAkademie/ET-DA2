namespace Projekt110;

public class DatumKalender
{
    //Implementing Fast Calendar Algorithms - Speeding Date - Cassio Neri - CppNow 2023
    //https://www.cppnow.org
    //https://www.youtube.com/watch?v=0s9F4QWAl-E

    public enum Monate
    {
        Januar = 1,
        Februar,
        März,
        April,
        Mai,
        Juni,
        Juli,
        August,
        September,
        Oktober,
        November,
        Dezember
    }

    public static int DaysInMonth(int year, Monate monat)
    {
        _ = year;
        _ = monat;
        return 0;
    }

    public static int LastDayOfMonth(int year, int month)
    {
        _ = year;
        _ = month;
        return 0;
    }

    public static bool IsLeapYear(int year)
    {
        _ = year;
        return false;
    }
}
