public class Program {
     public static void Main(string[] args) {
        Employee[] Employee = EmployeeID();

        PrintEmployeeInformation(Employee);
    }

    public static Employee[] InputUsers() {
        Employee[] users = new Employee[8];

        for(int index = 0; index < users.Length; index++) {
            Console.WriteLine("******** Input Employee ID : {0} ********", index + 1);

            Employee user = new Employee(InputName(),
            InputSurname(),
            InputStudentID(),
            InputScore());

            users[index] = user;

            Console.WriteLine("****************************************");
            Console.WriteLine();
        }

        return users;
    }

    public static void PrintUsersInformation(Employee[] users) {
       Array.ForEach(users, user => Console.WriteLine(user.PrintEmployeeInformation()));
    }

    public static string InputName() {
        Console.Write("Input Name: ");

        return Console.ReadLine();
    }

    public static int InputScore() {
        Console.Write("Input Score: ");
        string scoreText = Console.ReadLine();

          if (int.TryParse(scoreText, out int number)) {
            return number;
         }

       throw new Exception("Please input decimal data."); 
    }

    public static string InputStudentID() {
        Console.Write("Input StudentID: ");

        return Console.ReadLine();
    }

    public static string InputSurname() {
        Console.Write("input Surname:");

        return Console.ReadLine();