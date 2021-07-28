using System;

namespace AcademyCRM.BLL.Models
{
    public class StudentGroup
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Teacher Teacher { get; set; }

        public DateTime StartDate { get; set; }

        public GroupStatus Status { get; set; }
    }

    public enum GroupStatus
    {
        NotStarted,
        Started,
        Finished,
        Cancelled
    }
}