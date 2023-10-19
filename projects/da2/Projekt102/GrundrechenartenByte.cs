namespace Projekt102;

public static class GrundrechenartenByte
{
    public static byte Addieren(byte summand1, byte summand2) => (byte) (summand1 + summand2);
    public static byte Subtrahieren(byte minuend, byte subtrahend) => (byte) (minuend - subtrahend);
    public static byte Multiplizieren(byte multiplikand, byte multiplikator) => (byte) (multiplikand * multiplikator);
    public static byte Dividieren(byte dividend, byte divisor) => (byte) (dividend / divisor);
    public static byte RestBerechnen(byte a, byte b) => (byte) (a % b);

}
