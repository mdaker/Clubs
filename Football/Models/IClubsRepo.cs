namespace Football.Models
{
    public interface IClubsRepo
    {
        IEnumerable<Club> GetAllClubs();
        Club Add(Club club);
    }
}
