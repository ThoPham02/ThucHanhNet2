using Cshape.models;

int n = 0;
while (n < 1)
{
    Console.Write("Nhap so phan tu");
    n = Convert.ToInt16(Console.ReadLine());
}

// Nhap arr
Employee[] arrEmp = new Employee[n];
for (int i = 0; i < arrEmp.Length; i++)
{
    Employee emp = new Employee();
    emp.EnterInfo();

    arrEmp[i] = emp;
}
// Chinh sua arr
for (int i = 0; i < arrEmp.Length; i++)
{
    Employee emp = new Employee();
    Console.Write("Nhap Ma NV: ");
    int id = Convert.ToInt16(Console.ReadLine());
    Console.Write("Nhap Ten NV: ");
    string? fullname = Console.ReadLine();
    Console.Write("Nhap Tuoi: ");
    int age = Convert.ToInt16(Console.ReadLine());
    Console.Write("Nhap Luong: ");
    int salary = Convert.ToInt16(Console.ReadLine());

    emp.Changeinfo(id, fullname, age, salary);
    arrEmp[i] = emp;
}

// Hien thi Arr
foreach (Employee emp in arrEmp)
{
    emp.ShowInfo();
}