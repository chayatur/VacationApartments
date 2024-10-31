namespace VacationApartments.Entities
{
    public enum Ecategory { Suite, Zimer, Villa }
    public class Apartments
    {
        public string Id {  get; set; }
        public Address Address { get; set; }
        public int CountDays { get; set; }
        public Ecategory Category { get; set; }
        public int NumBeds { get; set; }
        public int Numrooms { get; set; }
        public bool WithYard { get; set; }
        public bool IsActive { get; set; }

        public List<int> LevelEnjoy =new List<int>();
       
    }
}
