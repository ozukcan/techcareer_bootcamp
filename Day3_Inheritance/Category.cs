namespace Day3_Inheritance;

public class Category : EntityBase
{
    public string CategoryName { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, Kim oluşturdu : {CreatedBy}, Ne Zaman : {CreatedDate}, Kategori Adı : {CategoryName}";
    }

    
}
