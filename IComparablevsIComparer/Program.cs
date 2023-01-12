using IComparablevsIComparer;

/*List<int> listOfIntegaers = new List<int>() { 55, 12, 5, 78, 9, 65, 35, 5, 80, 8, 14 };
listOfIntegaers.Sort();//ordenar una lista de numeros
foreach (var item in listOfIntegaers)
{
    System.Console.WriteLine(item + " ");
}
*/
//IComparable
class Program
{
    static void Main(string[] args)
    {

        List<SmartPhone> smartPhones = new List<SmartPhone>()
            {
                new SmartPhone()
                {
                    Name = "One Plus 8",
                    IsFlagship = true,
                    OS = "Android 10",
                    Price = 55000
                },
                new SmartPhone()
                {
                    Name = "IPhone 11",
                    IsFlagship = true,
                    OS = "IOS 11",
                    Price = 75000
                },
                new SmartPhone()
                {
                    Name = "Samsung Note 10",
                    IsFlagship = true,
                    OS = "Android 10",
                    Price = 110000
                },
                new SmartPhone()
                {
                    Name = "Samsung S20 Ultra",
                    IsFlagship = true,
                    OS = "Android 10",
                    Price = 130000
                },
                new SmartPhone()
                {
                    Name = "IPhone 11 Pro",
                    IsFlagship = true,
                    OS = "IOS 11",
                    Price = 130000
                }
            };
        smartPhones.Sort();
        foreach (var item in smartPhones)
        {
            System.Console.WriteLine(item.ToString());
        }
    }
}
