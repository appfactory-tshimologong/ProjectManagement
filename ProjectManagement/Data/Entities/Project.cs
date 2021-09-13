using System.Collections.Generic;

namespace ProjectManagement.Data.Entities
{
    public class Project
    {
        public int Id { get; set; }

        public string ReferenceNo { get; set; }

        public Employee ResponsibleEmployee { get; set; }

        public string Description { get; set; }

        public ICollection<ProjectTask> ProjectTasks { get; set; }
    }
}
