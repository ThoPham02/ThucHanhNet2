namespace Cshape.models
{
    public class Person {
        public int ID {get; set;}
        public string? Fullname {get; set;}
        public int Age {get; set;}

        public Person(){
            this.ID = 0;
            this.Fullname = "";
            this.Age = 0;
        }

        public void EnterInfo() {
            Console.Write("Nhap Ma NV: ");
            ID  = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap Ten NV: ");
            Fullname = Console.ReadLine();
            Console.Write("Nhap Tuoi: ");
            Age = Convert.ToInt16(Console.ReadLine());
        }

        public void ShowInfo() {
            Console.Write("Nhan vien: {0} Ten: {1} Tuoi: {2} ", ID, Fullname, Age);
        }
    }
}

