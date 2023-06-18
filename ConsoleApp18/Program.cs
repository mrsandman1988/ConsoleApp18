namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student t = new Student("John","Smith","London", 30,3);
            var type = t.GetType();
            if(type== typeof(Student) )
            {

            }
            Console.WriteLine(t);
             
        }
    }
}