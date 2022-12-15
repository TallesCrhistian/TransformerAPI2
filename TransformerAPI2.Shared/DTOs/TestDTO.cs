using System;

namespace TransformerAPI2.Shared.DTOs
{
    public class TestDTO : BaseDTO
    {
        public int Name { get; set; }
        public bool Status { get; set; } = true;
        public DateTime Duration_In_Seconds { get; set; }
    }
}