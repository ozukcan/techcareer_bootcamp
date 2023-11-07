namespace Day3_Inheritance;

public abstract class EntityBase //Abstract classlardan yeni nesne üretilemez
{
    public int Id { get; set; }
    public string CreatedDate { get; set; }
    public string CreatedBy { get; set; }
}
