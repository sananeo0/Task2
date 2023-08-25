namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your date (dd/MM/yyyy): ");
            string input = Console.ReadLine();
            try
            {
                DateTime time = DateTime.ParseExact(input, "dd/MM/yyyy", null);
                /* TimeSpan timeAdd = new TimeSpan(30, 06, 17, 00);
                 DateTime finalDate = time + timeAdd;*/
                DateTime finalDate = time.AddDays(30).AddHours(06).AddMinutes(17);
                Console.WriteLine(finalDate);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }
    }
}