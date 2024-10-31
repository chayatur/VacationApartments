namespace VacationApartments.Entities
{
    public class Address
    {
        public string street;
        public int NumStreet;
        public string City;

        public Address(string street, int numStreet, string city)
        {
            this.street = street;
            NumStreet = numStreet;
            City = city;
        }
    }
}
