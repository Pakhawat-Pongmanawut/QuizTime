public class Employee
    {
        public string name;
        public string surname;
        public string employeeID;


        public Employee(string name, string surname, string EmployeeIDCard)
        {
            this.name = name;
            this.surname = surname;
            this.employeeID = employeeID;
}
        
    

        public string PrintUserInformation() {
        return "User information is : " 
        + this.name + " " + this.surname + " " +
         this.employeeID + " This Employee is: ";
         
    }
    Console.ReadLine();
    
