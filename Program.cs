using System.Numerics;

var builder = WebApplication.CreateBuilder(args);

string? port = Environment.GetEnvironmentVariable("PORT");

if (!string.IsNullOrWhiteSpace(port))
{
    builder.WebHost.UseUrls($"http://0.0.0.0:{port}");
}
else if (Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER") == "true")
{
    builder.WebHost.UseUrls("http://0.0.0.0:10000");
}

var app = builder.Build();

app.MapGet("/healthz", () => "OK");
app.MapGet("/kk_issabay_gmail_com", (string? x, string? y) => FindLcm(x, y));
app.MapGet("/{*path}", (string? x, string? y) => FindLcm(x, y));

app.Run();

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
