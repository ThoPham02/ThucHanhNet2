namespace Cshape.models
{
    public class Employee {
        public int ID {get; set;}
        public string Fullname {get; set;}
        public int Age {get; set;}
        public int Salary {get; set;}

        public void enterInfo(int id, string name, int age, int salary) {
            System.Console.Write("Nhap Ma NV: ");
            ID  = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("Nhap Ten NV: ");
            fullname = Console.ReadLine();
            System.Console.WriteLine("Nhap Tuoi: ");
            age = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("Nhap Luong: ");
            salary = Convert.ToInt16(Console.ReadLine());
        }

        public void showInfo() {
            System.Console.WriteLine("Ma NV = {0}", id);
            System.Console.WriteLine("Ten NV = {0}", fullname);
            System.Console.WriteLine("Tuoi = {0}", age);
            System.Console.WriteLine("Luong = {0}", salary);
        }
    }
}

