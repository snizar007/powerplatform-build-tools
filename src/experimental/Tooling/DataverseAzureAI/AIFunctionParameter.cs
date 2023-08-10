using System.Text.Json.Serialization;

namespace Microsoft.PowerPlatform.Tooling.DataverseAzureAI;

public class AIFunctionParameter
{
    [JsonPropertyName("type")]
    public required string TypeName { get; set; }
    [JsonPropertyName("description")]
    public required string Description { get; set; }
}
