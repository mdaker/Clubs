namespace Football.Models
{
    public class ClubsRepo : IClubsRepo
    {
        private readonly AppDbContext context;
        public ClubsRepo(AppDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Club> GetAllClubs()
        {
            return context.Clubs.ToList();
        }

        public Club Add(Club club)
        {
            context.Clubs.Add(club);
            context.SaveChanges();
            return club;
        }

        public Club GetClub(int Id)
        {
            return context.Clubs.Find(Id);
        }

        public Club Update(Club clubChanges)
        {
            var car = context.Clubs.Attach(clubChanges);
            car.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return clubChanges;
        }
    }
}
