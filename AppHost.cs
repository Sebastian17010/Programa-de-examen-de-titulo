var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.inventario para la ropa >("apiservice")
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.Aplicacion de inventario para sucurasales de ropa >("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(inventario de ropa);

builder.Build().Run();
