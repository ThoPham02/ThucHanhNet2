namespace Cshape.models
{
    public class Fruit {
        public string Name {get; set;}
        public int Price {get; set;}

        public Fruit(string name, int price){
            this.Name = name;
            this.Price = price;
        }

        public void ShowInfo() {
            System.Console.WriteLine("Name = {0}", Name);
            System.Console.WriteLine("Price = {0}", Price);
        }
    }
}

