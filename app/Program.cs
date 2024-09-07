
namespace app;
using app.Classes;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Saisir le Produit");
        int ProdId = int.Parse(Console.ReadLine());
        string Name = Console.ReadLine();
        string BarCode = Console.ReadLine();
        decimal Price = decimal.Parse(Console.ReadLine()) ;

        Product product = new Product(ProdId,Name,BarCode,Price) ;
          product.displayProductInfo();

    }
}
