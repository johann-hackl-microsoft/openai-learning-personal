using Microsoft.SemanticKernel;

var builder = Kernel.CreateBuilder();
builder.Services.AddAzureOpenAIChatCompletion(
    System.Environment.GetEnvironmentVariable("SEMANTIC_KERNEL_SERVICEID"),
    System.Environment.GetEnvironmentVariable("SEMANTIC_KERNEL_ENDPOINT"),
    System.Environment.GetEnvironmentVariable("SEMANTIC_KERNEL_APIKEY"),
    System.Environment.GetEnvironmentVariable("SEMANTIC_KERNEL_MODELID")
    );
var kernel = builder.Build();
System.Console.WriteLine("Hello, World!");
