using System.Collections.Generic;

namespace sdf
{
    public class EmployeeService : EmployeeServiceBase
    {
        // Sənəd tələbi: public static List<Employee> Employees = new List<Employee>();[cite: 4]
        public static List<Employee> Employees = new List<Employee>();

        public override bool AddEmployee(Employee employee)
        {
            foreach (Employee e in Employees)
            {
                if (e.Code.ToLower() == employee.Code.ToLower())
                {
                    return false; // Eyni koda malik işçi artıq varsa false qaytarır[cite: 4]
                }
            }
            Employees.Add(employee);
            return true;
        }

        public override Employee FindEmployee(string code)
        {
            foreach (Employee e in Employees)
            {
                if (e.Code.ToLower() == code.ToLower())
                {
                    return e; // Koda görə tapıb qaytarır[cite: 4]
                }
            }
            return null; // Tapılmazsa null[cite: 4]
        }

        public override bool AddPayment(string employeeCode, string title, double amount)
        {
            Employee emp = FindEmployee(employeeCode);

            // İşçi tapılmazsa və ya məbləğ 0-dan böyük deyilsə false qaytarır[cite: 4]
            if (emp == null || amount <= 0)
            {
                return false;
            }

            Payment pay = new Payment();
            pay.Title = title;
            pay.Amount = amount;

            emp.Payments.Add(pay);
            return true;
        }

        public override List<Payment> GetEmployeePayments(string employeeCode)
        {
            Employee emp = FindEmployee(employeeCode);
            if (emp == null)
            {
                return null; // İşçi tapılmazsa null[cite: 4]
            }
            return emp.Payments; // Ödənişləri qaytarır[cite: 4]
        }

        public override List<Employee> GetAllEmployees()
        {
            return Employees; // Bütün işçiləri qaytarır[cite: 4]
        }
    }
}