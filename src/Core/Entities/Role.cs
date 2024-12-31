public class Role : BaseEntity
{
    public string Name { get; set; }
    public List Users { get; set; } = new();
}
