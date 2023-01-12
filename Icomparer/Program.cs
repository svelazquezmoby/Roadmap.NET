using Icomparerejemplo;

class Program
{
    static void Main(string[] args)
    {
        List<Display> displays = new List<Display>()
          {
              new Display()
              {
                  PPI = 224,
                  Resolution = "1080 * 1920",
                  Size = "6.1"
              },
              new Display()
              {
                  PPI = 300,
                  Resolution = "1440 * 2180",
                  Size = "7.1"
              },
              new Display()
              {
                  PPI = 115,
                  Resolution = "564 * 900",
                  Size = "4.2"
              },
              new Display()
              {
                  PPI = 160,
                  Resolution = "880 * 980",
                  Size = "5"
              }
          };
        SortDisplay sorted = new SortDisplay();
        displays.Sort(sorted);
        foreach (var item in displays)
        {
            System.Console.WriteLine("PPI: " + item.PPI + " Resolution: " + item.Resolution + " Size: " + item.Size);
        }
    }
}