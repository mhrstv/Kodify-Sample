using Kodify.AI.Configuration;
using Kodify.AI.Services;
using Kodify.AutoDoc.Services.Documentation;
using Kodify.Extensions.Diagrams.Services;

// Initialize AI service (OpenAI)
var aiConfig = new OpenAIConfig 
{ 
    ApiKey = "",
    Model = "gpt-4o-mini" 
};
var aiService = new OpenAIService(aiConfig);

// Create instances of the services we will be using
var markdownGenerator = new MarkdownGenerator(aiService);
var diagramGenerator = new PUMLDiagramGenerator();

// Example usage of generation methods
await markdownGenerator.GenerateReadMeAsync(
    "Kodify Sample",
    "A .NET console app that showcases the usage of the Kodify .NET library.",
    "Install the app on your desired platform\nRun as you wish and test the usage of Kodify.");
await markdownGenerator.GenerateChangelogAsync(aiService);
diagramGenerator.GeneratePUML();