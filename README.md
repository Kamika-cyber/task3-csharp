# Task 3

C# ASP.NET Core web method for finding the lowest common multiple of two natural numbers.

## Run locally

```powershell
dotnet run --project Task3.csproj
```

Then open:

```text
http://localhost:5211/kk_issabay_gmail_com?x=12&y=18
```

The result should be:

```text
36
```

## Rules

- `x` and `y` must be natural numbers: digits only and greater than `0`.
- If one value is missing, zero, negative, or not a number, the response is exactly `NaN`.
- The response is plain text, not HTML or JSON.

## Submission URL

Email: `kk.issabay@gmail.com`

Path: `kk_issabay_gmail_com`

Submit using this format:

```text
!task3 kk.issabay@gmail.com https://PASTE_YOUR_DEPLOYED_SITE_HERE/kk_issabay_gmail_com?x={}&y={}
```

Do not submit `localhost` or `PASTE_YOUR_DEPLOYED_SITE_HERE`.
Use the real public URL from the hosting site.

## Publish

Create a publish folder:

```powershell
dotnet publish Task3.csproj -c Release -o publish
```

Upload the files from the `publish` folder to the website on Somee.

After deployment, check the public URL:

```text
https://your-site.somee.com/kk_issabay_gmail_com?x=12&y=18
```

The page should contain only:

```text
36
```
