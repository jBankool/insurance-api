var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.insurance_api>("insurance-api");

builder.Build().Run();
