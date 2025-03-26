Browse to Solution Explorer > Connected Services and double click to start

Microsoft Identity Plantform ... Connect
 - Connect to existing Azure App Registration
 - Add [x] Code
 - Add [x] Nuget Packages
 - Add [x] App Regisration to appsettings

If it fails restoring packages, then run again

Move settings to user secrets:

- Browse to Solution Explorer > Right Click > manage user secrets
- copy all of appsettings.json to secrets.json
- remove the AzureAD section from appsettings.json

# Main Changes


## Program.cs

```c#
      builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
          .AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("AzureAd"));

      builder.Services.AddAuthorization(options =>
      {
          // By default, all incoming requests will be authorized according to the default policy.
          // you can add Groups and Roles here
          options.FallbackPolicy = options.DefaultPolicy;
      });
      builder.Services
          .AddRazorPages()
          .AddMicrosoftIdentityUI(); // this is the UI assembly
```

and add `app.MapControllers`

```c#
        app.MapRazorPages();
        app.MapControllers(); // add this too
```