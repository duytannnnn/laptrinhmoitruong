class Emloyee
{
    public void CalulatePay()
    {
        Console.WriteLine(" Employee.caliulatePay");
    }
}
class SaleEmployee : Emloyee
{
    public void CalulatePay()
    {
        Console.WriteLine(" SaleEmployee.caliulatePay");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Emloyee e = new SaleEmployee();
SaleEmployee s = new SaleEmployee();

e.CalulatePay(); 
s.CalulatePay(); 

e = new SaleEmployee();
e.CalulatePay(); 

    }
}