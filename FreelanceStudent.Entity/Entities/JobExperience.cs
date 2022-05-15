namespace FreelanceStudent.Entity.Entities
{
    public class JobExperience
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail{ get; set; }

        public Background Background { get; set; }
        public int BackgroundId { get; set; }
    }
}