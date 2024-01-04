namespace System_zarządzania_błędami.Entities
{
    public class UserReports
    {
        public int Id { get; set; }
        //public int ReportId { get; set; }
        //public int UserId { get; set; }
        public Reports Reports { get; set; }
        public Users Users { get; set; }
    }
}
