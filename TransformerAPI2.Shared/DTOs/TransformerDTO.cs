namespace TransformerAPI2.Shared.DTOs
{
    public class TransformerDTO : BaseDTO
    {
        public string Name { get; set; }
        public double Internal_Number { get; set; }
        public double Tension_Class { get; set; }
        public double Potency { get; set; }
        public int Current { get; set; }
    }
}