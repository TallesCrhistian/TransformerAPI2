using Google.Protobuf.WellKnownTypes;

namespace TransformerAPI2.Shared.DTOs
{
    public class BaseDTO
    {
        public Timestamp Created_at { get; set; }
        public Timestamp Update_at { get; set; }
    }
}