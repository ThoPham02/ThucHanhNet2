namespace Cshape.models
{
    public class Employee : Person{
        public int Salary {get; set;}

        public Employee(){
            this.ID = 0;
            this.Fullname = "";
            this.Age = 0;
            this.Salary = 0;
        }

        
        public void EnterInfo() {
            Console.Write("Nhap Ma NV: ");
            ID  = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap Ten NV: ");
            Fullname = Console.ReadLine();
            Console.Write("Nhap Tuoi: ");
            Age = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap Luong: ");
            Salary = Convert.ToInt16(Console.ReadLine());
        }

        public void Changeinfo(int id, string? fullname, int age, int salary) {
            this.ID = id;
            this.Fullname = fullname;
            this.Age = age;
            this.Salary = salary;
        }

        public void ShowInfo() {
            Console.WriteLine("Nhan vien: {0} Ten: {1} Tuoi: {2} Luong: {3}", ID, Fullname, Age, Salary);
        }
    }
}

