/*
 *
 *  https://gist.github.com/alex-groshev/f433f0e0972da24c2106
 *
 */

// ReSharper disable UnusedMember.Global
namespace Projekt523.Model;

public class Mittelwert
{
    public static IEnumerable<double> CumulativeMovingAverage(IEnumerable<double> source)
    {
        ulong count = 0;
        double sum = 0;

        foreach (var d in source) { yield return (sum += d) / ++count; }
    }

    public static IEnumerable<double> SimpleMovingAverage(IEnumerable<double> source, int length)
    {
        var sample = new Queue<double>(length);

        foreach (var d in source)
        {
            if (sample.Count == length) { _ = sample.Dequeue(); }

            sample.Enqueue(d);
            yield return sample.Average();
        }
    }
    public static IEnumerable<double> ExponentialMovingAverage(IEnumerable<double> source, int length)
    {
        var alpha = 2 / (double) (length + 1);
        var s = source.ToArray();
        double result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            result = i == 0 ? s[i] : alpha * s[i] + (1 - alpha) * result;
            yield return result;
        }
    }
}
