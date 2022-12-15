using System;

namespace TransformerAPI2.Entities
{
    public class Test : Base
    {
        public int IdTest { get; set; }
        public int Name { get; set; }
        public bool Status { get; set; }
        public DateTime Duration_In_Seconds { get; set; }
    }
}