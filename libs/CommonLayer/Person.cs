using System.Text.Json.Serialization;

namespace CommonLayer
{
  public class Person
  {
    public int? age;

    [JsonIgnore]
    public readonly string FullName = "Test";

    [JsonPropertyName("fName")]
    [JsonPropertyOrder(2)]
    public string FirstName { get; set; }

    [JsonPropertyName("lName")]
    [JsonPropertyOrder(1)]
    public string LastName { get; set; }

    // FullName gibi bir özellik elemek istiyorum.

  }
}
