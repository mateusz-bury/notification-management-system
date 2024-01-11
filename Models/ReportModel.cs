using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System_zarządzania_błędami.Entities;

namespace System_zarządzania_błędami.Models
{
    public class ReportModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionDate { get; set; }
        public bool Status { get; set; }

        [NotMapped]
        public List<Errors> Errors { get; set; }
        [NotMapped]
        public List<Priorities> Priorities { get; set; }
        [NotMapped]
        public string ErrorName { get; set; }
        [NotMapped]
        public string PriorityName { get; set; }
        public int SelectedErrorId { get; set; }
        public int SelectedPriorityId { get; set; }
    }
}
