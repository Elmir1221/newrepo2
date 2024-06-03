namespace home_project.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool SoftDeleted{ get; set; } = false;
        public DateTime CreatedBy { get; set;} = DateTime.Now;  
    }
}
