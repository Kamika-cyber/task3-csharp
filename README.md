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

## Deploy

1. Create a public GitHub repository.
2. Push this project to the repository.
3. Create a new Web Service on Render.
4. Connect the GitHub repository.
5. Select Docker as the runtime.
6. Deploy the service.

After deployment, check:

```text
https://your-render-service.onrender.com/kk_issabay_gmail_com?x=12&y=18
```
