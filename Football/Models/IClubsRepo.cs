namespace Football.Models
{
    public interface IClubsRepo
    {
        IEnumerable<Club> GetAllClubs();
        IEnumerable<ChampoinsLeague> GetAllChampoins();
        Club Add(Club club);

        Club GetClub(int Id);

        Club Update(Club clubChanges);

        Club Delete(int Id);
    }
}
