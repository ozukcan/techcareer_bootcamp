namespace Day5_Linq.Models;

internal class ProductDetailDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Stock { get; set; }
    public string CategoryName { get; set; }
    public  double Price { get; set; }

    public override string ToString()
    {
        return $"ProductId : {ProductId} , ProductName : {ProductName}, Stock : {Stock}, Price : {Price}, CategoryName : {CategoryName}";
    }
}
