using Kodify.AI.Configuration;
using Kodify.AI.Services;
using Kodify.AutoDoc.Documentation;
using Kodify.DevOps.IaC;
using Kodify.DevOps.Pipeline;
using Kodify.Extensions.Diagrams.Services;

// Initialize AI service (OpenAI)
var aiConfig = new OpenAIConfig 
{ 
    ApiKey = "",
    Model = "gpt-4o-mini" 
};
var aiService = new OpenAIService(aiConfig);

// Example usage of README and CHANGELOG generation methods
var markdownGenerator = new MarkdownGenerator(aiService);
await markdownGenerator.GenerateReadMeAsync(
    "Kodify Sample",
    "A .NET console app that showcases the usage of the Kodify .NET library.",
    "Install the app on your desired platform\nRun as you wish and test the usage of Kodify.");
await markdownGenerator.GenerateChangelogAsync(aiService);

// Example usage of PUML generation
var diagramGenerator = new PUMLDiagramGenerator();
diagramGenerator.GeneratePUML();

// Generates Terraform template
var terraformGenerator = new TerraformGenerator();
await terraformGenerator.GenerateTemplateAsync();

// Generates AWS CloudFormation template
var awsGenerator = new CloudFormationGenerator();
await awsGenerator.GenerateTemplateAsync();

// Automatically detects the type of pipeline needed and generates based on that
var pipelineGenerator = Pipelines.DetectCI();
await pipelineGenerator.GenerateAsync();