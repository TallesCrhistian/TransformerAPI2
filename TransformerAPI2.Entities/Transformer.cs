namespace TransformerAPI2.Entities
{
    public class Transformer : Base
    {
        public int IdTransformer { get; set; }
        public string Name { get; set; }
        public double Internal_Number { get; set; }
        public double Tension_Class { get; set; }
        public double Potency { get; set; }
        public int Current { get; set; }
    }
}