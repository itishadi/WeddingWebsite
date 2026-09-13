namespace WeddingWebsite.Models
{
    public class GuestManager
    {
        private List<Guest> guests = new();

        public int NumOfGuests => guests.Count;

        public void Add(Guest guest)
        {
            guests.Add(guest);
        }

        public List<Guest> GetAll()
        {
            return guests;
        }
    }
}