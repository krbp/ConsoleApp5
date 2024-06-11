namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CustomException.ThrowError(DateTime.Now);
            }
            catch(CustomException e)
            {
                Console.WriteLine($"{e}");
            }
        }
    }
}
