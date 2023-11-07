namespace Day3_Inheritance;

internal class Product : EntityBase
{

    public string Name { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, Kim oluşturdu : {CreatedBy}, Ne Zaman : {CreatedDate}, Adı : {Name}, Değeri : {Price}";
    }
}
