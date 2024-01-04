using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace System_zarządzania_błędami.Entities
{
    public class Reports
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description{ get; set; }
        public DateTime SubmissionDate { get; set; }
        public bool Status { get; set; }
        //public int ErrorId { get; set; }
        public Errors Errors { get; set; }
        public ICollection<UserReports> UserReports { get; set; }

    }
}
