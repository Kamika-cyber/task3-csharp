using System.Numerics;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/kk_issabay_gmail_com", (string? x, string? y) =>
{
    string result = GetLowestCommonMultiple(x, y);
    return Results.Text(result, "text/plain");
});

app.Run();

static string GetLowestCommonMultiple(string? x, string? y)
{
    if (!TryParseNaturalNumber(x, out BigInteger firstNumber) ||
        !TryParseNaturalNumber(y, out BigInteger secondNumber))
    {
        return "NaN";
    }

    BigInteger greatestCommonDivisor = GetGreatestCommonDivisor(firstNumber, secondNumber);
    BigInteger lowestCommonMultiple = firstNumber / greatestCommonDivisor * secondNumber;

    return lowestCommonMultiple.ToString();
}

static bool TryParseNaturalNumber(string? text, out BigInteger number)
{
    number = BigInteger.Zero;

    if (string.IsNullOrEmpty(text))
    {
        return false;
    }

    foreach (char character in text)
    {
        if (character < '0' || character > '9')
        {
            return false;
        }
    }

    number = BigInteger.Parse(text);
    return number > BigInteger.Zero;
}

static BigInteger GetGreatestCommonDivisor(BigInteger firstNumber, BigInteger secondNumber)
{
    while (secondNumber != BigInteger.Zero)
    {
        BigInteger remainder = firstNumber % secondNumber;
        firstNumber = secondNumber;
        secondNumber = remainder;
    }

    return firstNumber;
}
