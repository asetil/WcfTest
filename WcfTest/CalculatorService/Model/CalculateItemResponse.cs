using System.Runtime.Serialization;

namespace CalculatorService.Model
{
    [DataContract]
    public class CalculateItemResponse
    {
        [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public decimal Result { get; set; }
    }
}