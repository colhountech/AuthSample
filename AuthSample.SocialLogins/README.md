This is the None Base Project. 
This has not been implemented yet.

For documentation on how to do this see:

https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social


Where you will find 

* Facebook instructions
* Twitter instructions
* [Google instructions](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/google-logins)
* Microsoft instructions
* Other provider instructions


The Basic Pattern is to setup a API Key and Secret, then change the Authentication:

```c#
services.AddAuthentication().AddTwitter(twitterOptions =>
    {
        twitterOptions.ConsumerKey = configuration["Authentication:Twitter:ConsumerAPIKey"];
        twitterOptions.ConsumerSecret = configuration["Authentication:Twitter:ConsumerSecret"];
    });
```

if you want multiple, the end code would look like this:

```c#

services.AddAuthentication()
    .AddMicrosoftAccount(microsoftOptions => { ... })
    .AddGoogle(googleOptions => { ... })
    .AddTwitter(twitterOptions => { ... })
    .AddFacebook(facebookOptions => { ... });


```