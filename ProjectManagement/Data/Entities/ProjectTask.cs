using System;

namespace ProjectManagement.Data.Entities
{
    public partial class ProjectTask
    {
        public int Id { get; set; }

        public string TaskDescription { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public TaskState TaskState { get; set; }
    }
}
