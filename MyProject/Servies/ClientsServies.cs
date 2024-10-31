using System.Collections.Generic;
using VacationApartments.Entities;

namespace VacationApartments.Servies
{
    public class ClientsServies
    {

        public List<Client> Clist = new List<Client>() {new Client() {Id=1,Name="moishi",Email="m0083@gmail.com", Address = new Address("Hazofim", 5, "Cnaan"),Phone="09876" },
            {new Client() {Id=1,Name="yaakov",Email="y0083@gmail.com", Address = new Address("Hazofim", 5, "Cnaan"),Phone="09876" } } };
        public List<Client> GetClients()
        { return Clist; }

        public Client GetById(string id)
        {
            return Clist.Where(x => x.Id.Equals(id)).FirstOrDefault<Client>();
        }

        public void AddClient(Client client) { 
            Clist.Add(client);
        }

        public bool DeleteClient(Client client)
        {
            if (Clist.Count == 0)
                return false;
            for (int i = 0; i < Clist.Count; i++)
            {
                if (Clist[i].Id.Equals(client.Id))
                    Clist.Remove(client); return true;
            }
            return false;
        }
        public bool UpdateClient(Client client)
        {
            if (Clist.Count == 0)
                return false;
            for (int i = 0; i < Clist.Count; i++)
            {
                if (Clist[i].Id.Equals(client.Id))
                    Clist[i] = client;
            }
            return false;
        }
    }
}

