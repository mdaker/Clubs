namespace Football.Models
{
    public interface IClubsRepo
    {
        IEnumerable<Club> GetAllClubs();
    }
}
