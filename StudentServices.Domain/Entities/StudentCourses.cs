namespace StudentServices.Domain.Entities
{
    public class StudentCourses
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public decimal Score { get; set; }
    }
}
