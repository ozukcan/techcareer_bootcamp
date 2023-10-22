using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_OOP;

public struct Book
{
    public string Adi;
    public string Yazar;
    public int SayfaSayisi;

    public override string ToString()
    {
        return $"Kitap adı: {Adi}, Kitap Yazarı: {Yazar}, Kitap Sayfası: {SayfaSayisi}";
    }
}
