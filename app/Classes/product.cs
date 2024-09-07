namespace app.Classes
{
    public class Product {
      public  int ProdId_{ get; set; }
      public string Name_  { get; set; }
      //public string Name_ {  get{return Name;} set{Name=value;} }
      public string BarCode_{ get; set; }
      public decimal Price_{ get; set; }
      
    public Product(int ProdId,string Name,string BarCode,decimal Price){
            ProdId_=ProdId;
            Name_=Name;
            BarCode_=BarCode;
            Price_=Price;
    }
    virtual public void displayProductInfo(){
       Console.WriteLine("ID Produit: "+ ProdId_ +"  Désignation: "+Name_+"  Code à Barres: "+BarCode_+"  Catégorie:-- "+"  Prix: "+Price_);
    //Console.WriteLine("Désignation : "+ Name_ );
    }
    }
    
}