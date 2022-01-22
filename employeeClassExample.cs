using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamzasEmployeeProgram
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;
        public DateTime birthday;

        public EmployeeType employeeType;

        public Employee(string first, string last, string mail, DateTime birth, EmployeeType empType, double rate)
        {
            firstName = first;
            lastName = last;
            email = mail;
            birthday = birth;
            employeeType = empType;
            hourlyRate = rate;
        }

        public Employee(string first, string last, string mail, DateTime birth, EmployeeType empType) : this(first, last, mail, birth, empType, 0)
        {

        }
        public void PerformWork()
        {
            numberOfHoursWorked++;
            Console.WriteLine($"{firstName} {lastName} has worked an additional hour!");
        }

        public double ReceiveWage()
        {
            wage = numberOfHoursWorked * hourlyRate;
            Console.WriteLine($"The wage for {numberOfHoursWorked} hours worked is {wage}");
            numberOfHoursWorked = 0;
            return wage;
        }

        public void DisplayEmployeeInformation()
        {
            Console.WriteLine($"\nFirst Name: {firstName}\nLast Name: {lastName}\nEmail: {email}\nEmployee Type: {employeeType}\nBirthday: {birthday}");
        }
    }
}