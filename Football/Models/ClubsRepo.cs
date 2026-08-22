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
    }
}
