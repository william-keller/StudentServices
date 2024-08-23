namespace StudentServices.Domain.Entities
{
    public class StudentVersion
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }
}
