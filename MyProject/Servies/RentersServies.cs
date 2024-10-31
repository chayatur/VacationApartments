using VacationApartments.Entities;

namespace VacationApartments.Servies
{
    public class RentersServies
    {


        public List<Renters> Rlist = new List<Renters>() {new Renters() {Id=1,Name="moishi",Email="m0083@gmail.com", Address = new Address("Hazofim", 5, "Cnaan"),Phone="09876" },
            {new Renters() {Id=1,Name="yaakov",Email="y0083@gmail.com", Address = new Address("Hazofim", 5, "Cnaan"),Phone="09876" } } };
        public List<Renters> GetRent()
        { return Rlist; }

        public Renters GetById(string id)
        {
            return Rlist.Where(x => x.Id.Equals(id)).FirstOrDefault<Renters>();
        }

        public void AddRenter(Renters renter)
        {
            Rlist.Add(renter);
        }

        public bool DeleteRenter(Renters renter)
        {
            if (Rlist.Count == 0)
                return false;
            for (int i = 0; i < Rlist.Count; i++)
            {
                if (Rlist[i].Id.Equals(renter.Id))
                    Rlist.Remove(renter); return true;
            }
            return false;
        }
        public bool UpdateRenter(int id,Renters renter)
        {
            if (Rlist.Count == 0)
                return false;
            for (int i = 0; i < Rlist.Count; i++)
            {
                if (Rlist[i].Id.Equals(id))
                    Rlist[i] = renter;
            }
            return false;
        }
    }
}
