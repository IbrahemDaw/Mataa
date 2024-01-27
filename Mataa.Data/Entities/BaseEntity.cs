namespace Mataa.Data.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreateAt { get; set; }
    public int CreateBy { get; set; }
    public DateTime UpdateAt { get; set; }
    public int UpdateBy { get; set; }
}
