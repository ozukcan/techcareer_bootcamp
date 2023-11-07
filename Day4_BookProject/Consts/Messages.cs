namespace Day4_BookProject.Consts;

public class Messages
{
    public static string BookPriceAndStockExceptionMessage(double price, int stock)
    {
        return $"Girdiğiniz stok ve değer bilgisi negatif değer alamaz {stock}, fiyatı {price}";
    }

    public static string BookTitleExceptionMessage(string title)
    {
        return $"{title}, minimum 2 karakterli olmalıdır girdiğiniz karakter sayısı : {title.Length}";
    }
}
