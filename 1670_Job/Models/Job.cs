namespace _1670_Job.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public DateTime Application_Deadline { get; set; }

        public decimal Salary { get; set; }
    }
}
