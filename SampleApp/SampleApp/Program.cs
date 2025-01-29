using Kodify.AI.Configuration;
using Kodify.AI.Services;
using Kodify.AutoDoc.Services;

var analyzer = new CodeAnalyzer();
var projectInfo = analyzer.Analyze();

var aiConfig = new OpenAIConfig
{
    ApiKey = "",
    Model = "gpt-4o-mini"
};
var aiService = new OpenAIService(aiConfig);
var markdownGenerator = new MarkdownGenerator(aiService);

await markdownGenerator.GenerateReadMe(
    projectInfo,
    "Kodify Sample",
    "A .NET console app that showcases the usage of the Kodify .NET library.",
    "Install the app on your desired platform\nRun as you wish and test the usage of Kodify.");

markdownGenerator.GenerateChangelog();

// Changelog test