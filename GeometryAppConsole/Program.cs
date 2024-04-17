using System.Configuration;
using Microsoft.Extensions.Configuration;

var featureManagement = new Dictionary<string, string> {{ "FeatureManagement:Square", "true"}, { "FeatureManagement:Rectangle", "false"}, { "FeatureManagement:Triangle", "true"}};
IConfiguration configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();