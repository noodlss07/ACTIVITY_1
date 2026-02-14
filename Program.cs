namespace ACTIVITY_1_SULAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====ACCOUNT MANAGEMENT SYSTEM====");
            string username = "sularlance";
            string password = "sularlance123";

            Console.Write("Enter username: ");
            string inputUsername = Console.ReadLine();
            Console.Write("Enter password: ");
            string inputPassword = Console.ReadLine();

            if (inputUsername == username && inputPassword == password)
            {
                Console.WriteLine("Login successful! Welcome, " + username + "!");
            }
            else
            {
                Console.WriteLine("Login failed! Invalid username or password.");
            }   
        }
    }
}
