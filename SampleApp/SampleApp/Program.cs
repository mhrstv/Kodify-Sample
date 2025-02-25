using Kodify.AI.Configuration;
using Kodify.AI.Services;
using Kodify.AutoDoc.Services;
using Kodify.Extensions.Diagrams;
using Kodify.DevOps.IaC;
using Kodify.DevOps.Pipeline;

// Initialize AI service (OpenAI)
var aiConfig = new OpenAIConfig 
{ 
    ApiKey = "",
    Model = "gpt-4o-mini" 
};
var aiService = new OpenAIService(aiConfig);

// Showcase of README and CHANGELOG generation
var markdownGenerator = new MarkdownGenerator(aiService);
await markdownGenerator.GenerateReadMeAsync(
    "Kodify Sample",
    "A .NET console app that showcases the usage of the Kodify .NET library.",
    "Install the app on your desired platform\nRun as you wish and test the usage of Kodify.");
await markdownGenerator.GenerateChangelogAsync(aiService);

// Diagram generation
var diagramGenerator = new PUMLDiagramGenerator();
diagramGenerator.GeneratePUML();

// IaC template generation
var cloudformationGenerator = new CloudFormationGenerator();
await cloudformationGenerator.GenerateTemplateAsync();

var terraformGenerator = new TerraformGenerator();
await terraformGenerator.GenerateTemplateAsync();

// Pipeline template generation
var githubActions = new GithubActionsGenerator();
await githubActions.GenerateAsync();

var gitlabCI = new GitLabCIGenerator();
await gitlabCI.GenerateAsync();

var azureDevops = new AzureDevOpsGenerator();
await azureDevops.GenerateAsync();