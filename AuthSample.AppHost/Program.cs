var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AuthSample_None>("authsample-none");

builder.Build().Run();
