using VacationApartments.Entities;

namespace VacationApartments.Servies
{
    public class ApartmentsServies
    {
         public List<Apartments> list = new List<Apartments>() {new Apartments() {Id="1", Address = new Address("Hazofim", 5, "Cnaan"),CountDays=3, Category = Ecategory.Villa, NumBeds = 20, Numrooms = 6, WithYard = true, IsActive = true }
        ,{new Apartments() { Id="2",Address = new Address("Talpiyot", 5, "Jerusalem"),CountDays=1, Category = Ecategory.Villa, NumBeds = 8, Numrooms = 3, WithYard = true, IsActive = true } } };
        public List<Apartments>GetApartment()
        { return list; }

        public Apartments GetById(string id)
        {
          return list.Where(x =>x.Id.Equals(id)).FirstOrDefault<Apartments>();
        }

        public void AddApartment(Apartments apartment)
        {
            list.Add(apartment);
        }

        public bool DeleteApartment(int id) 
        { 
            if(list.Count == 0)
                return false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Id.Equals(id))
                    list.Remove(list[i]); return true;
                }
            return false;   
        }
        public bool UpdateApartment(Apartments apartment)
        {
            if (list.Count == 0)
                return false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id.Equals(apartment.Id))
                    list[i]=apartment; 
            }
            return false;
        }
        public bool UpdateLevel(int id,int level)
        {
            foreach (Apartments apartment in list) 
            {
                if (apartment.Id.Equals(id))
                {
                    apartment.LevelEnjoy.Add(level);
                    return true;
                }
            }
            return false;
        }
    }
}

