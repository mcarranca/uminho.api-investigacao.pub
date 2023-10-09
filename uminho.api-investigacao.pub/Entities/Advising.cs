using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities
{
    [Serializable,
   JsonSerializable(typeof(Advising), TypeInfoPropertyName = "advising")]
    public class Advising
    {
        [JsonPropertyName("AdvisingroleID")]
        public string? AdvisingroleID { get; set; }
        [JsonPropertyName("AvisingroleName ")]
        public string? AdvisingroleName { get; set; }
        [JsonPropertyName("AdviseName")]
        public string? AdviseName { get; set; }
        [JsonPropertyName("AdviseID")]
        public string? AdviseID { get; set; }
        [JsonPropertyName("persons")] 
        public IEnumerable<Person>? Persons { get; set; }
        [JsonPropertyName("start")]
        public string? Start { get; set; }
        [JsonPropertyName("end")]
        public string? End { get; set; }
        [JsonPropertyName("degree")]
        public Degree? Degree { get; set; }
        [JsonPropertyName("courseName")]
        public string? CourseName { get; set; }
        [JsonPropertyName("courseID")]
        public string? CourseID { get; set; }

    }
}
