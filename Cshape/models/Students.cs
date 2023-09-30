namespace Cshape.models
{
    public class Student {
        public string fullname {get; set;}
        public int age {get; set;}
        public bool gender {get; set;}

        public void showInfo() {
            System.Console.WriteLine("Fullname = {0}", fullname);
            System.Console.WriteLine("Age = {0}", age);
            System.Console.WriteLine("Gender = {0}", gender == 1 ? "Male" : "Female");
        }
    }
}

