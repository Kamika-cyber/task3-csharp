# Task 3

ASP.NET Core web method that returns the lowest common multiple of two natural numbers.

## Endpoint

```text
GET /kk_issabay_gmail_com?x={number}&y={number}
```

Example:

```text
http://task3kk.somee.com/kk_issabay_gmail_com?x=12&y=18
```

Response:

```text
36
```

## Run locally

```powershell
dotnet run --project Task3.csproj
```

Local URL:

```text
http://localhost:5211/kk_issabay_gmail_com?x=12&y=18
```

## Validation

- `x` and `y` must be natural numbers: digits only and greater than `0`.
- If one value is missing, zero, negative, or not a number, the response is `NaN`.
- The response is plain text, not HTML or JSON.

## Examples

| Request | Response |
| --- | --- |
| `?x=12&y=18` | `36` |
| `?x=10&y=15` | `30` |
| `?x=0&y=5` | `NaN` |
| `?x=abc&y=5` | `NaN` |

## Publish

Create a publish folder:

```powershell
dotnet publish Task3.csproj -c Release -o publish
```

Upload the files from the `publish` folder to the website root on Somee.

## Project Files

- `Program.cs` contains the endpoint and LCM calculation.
- `Task3.csproj` contains project settings.
- `appsettings.json` contains ASP.NET Core configuration.
