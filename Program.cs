using System.Numerics;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/kk_issabay_gmail_com", (string? x, string? y) => FindLcm(x, y));
app.MapGet("/{*path}", (string? x, string? y) => FindLcm(x, y));

string? port = Environment.GetEnvironmentVariable("PORT");

if (string.IsNullOrEmpty(port))
{
    app.Run();
}
else
{
    app.Run($"http://0.0.0.0:{port}");
}

static string FindLcm(string? xText, string? yText)
{
    if (!TryReadNaturalNumber(xText, out BigInteger x) ||
        !TryReadNaturalNumber(yText, out BigInteger y))
    {
        return "NaN";
    }

    return (x / GreatestCommonDivisor(x, y) * y).ToString();
}

static bool TryReadNaturalNumber(string? text, out BigInteger number)
{
    number = BigInteger.Zero;

    if (string.IsNullOrWhiteSpace(text))
    {
        return false;
    }

    foreach (char symbol in text)
    {
        if (symbol < '0' || symbol > '9')
        {
            return false;
        }
    }

    number = BigInteger.Parse(text);
    return number > BigInteger.Zero;
}

static BigInteger GreatestCommonDivisor(BigInteger a, BigInteger b)
{
    while (b != BigInteger.Zero)
    {
        BigInteger remainder = a % b;
        a = b;
        b = remainder;
    }

    return a;
}
