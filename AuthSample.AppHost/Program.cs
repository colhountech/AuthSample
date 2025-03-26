var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AuthSample_None>("authsample-none");

builder.AddProject<Projects.AuthSample_Individual>("authsample-individual");

builder.AddProject<Projects.AuthSample_EntraID>("authsample-entraid");

builder.AddProject<Projects.AuthSample_SocialLogins>("authsample-sociallogins");

builder.Build().Run();
