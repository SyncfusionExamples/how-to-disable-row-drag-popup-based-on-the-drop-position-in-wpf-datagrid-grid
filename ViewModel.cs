using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfTreeGrid_MVVM
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.Employees = this.GetEmployees();
        }
        private ObservableCollection<EmployeeInfo> _employees;

        public ObservableCollection<EmployeeInfo> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        private ObservableCollection<EmployeeInfo> GetEmployees()
        {
            EmployeeInfos employeeDetails = new EmployeeInfos();

            EmployeeInfo tmp;

            //Management
            tmp = new EmployeeInfo() { FirstName = "Ferando", LastName = "Joseph", DOB = new DateTime(2018, 10, 3), Title = "Management", Salary = 2000000, ReportsTo = -1, ID = 2 };
            employeeDetails.Add(tmp);
            tmp.Children.Add(new EmployeeInfo() { FirstName = "Andrew", LastName = "Fuller", DOB = new DateTime(2018, 10, 3), ID = 9, Salary = 1200000, ReportsTo = 2, Title = "Vice President" });
            tmp.Children.Add(new EmployeeInfo() { FirstName = "Janet", LastName = "Leverling", DOB = new DateTime(2018, 10, 3), ID = 10, Salary = 1000000, ReportsTo = 2, Title = "GM" });
            tmp.Children.Add(new EmployeeInfo() { FirstName = "Steven", LastName = "Buchanan", DOB = new DateTime(2018, 10, 3), ID = 11, Salary = 900000, ReportsTo = 2, Title = "Manager" });

            //Accounts
            tmp = new EmployeeInfo() { FirstName = "John", LastName = "Adams", DOB = new DateTime(2018, 10, 3), Title = "Accounts", Salary = 2000000, ReportsTo = -1, ID = 3 };
            employeeDetails.Add(tmp);
            tmp.Children.Add(new EmployeeInfo() { FirstName = "Nancy", LastName = "Davolio", DOB = new DateTime(2018, 10, 3), ID = 12, Salary = 850000, ReportsTo = 3, Title = "Accounts Manager" });
            tmp.Children.Add(new EmployeeInfo() { FirstName = "Margaret", LastName = "Peacock", DOB = new DateTime(2018, 10, 3), ID = 13, Salary = 700000, ReportsTo = 3, Title = "Accountant" });
            tmp.Children.Add(new EmployeeInfo() { FirstName = "Michael", LastName = "Suyama", DOB = new DateTime(2018, 10, 3), ID = 14, Salary = 700000, ReportsTo = 3, Title = "Accountant" });
            tmp.Children.Add(new EmployeeInfo() { FirstName = "Robert", LastName = "King", DOB = new DateTime(2018, 10, 3), ID = 15, Salary = 650000, ReportsTo = 3, Title = "Accountant" });

            //Sales
            tmp = new EmployeeInfo() { FirstName = "Thomas", LastName = "Jefferson", DOB = new DateTime(2018, 10, 3), Title = "Sales", Salary = 300000, ReportsTo = -1, ID = 4 };
            employeeDetails.Add(tmp);
            tmp.Children.Add(new EmployeeInfo() { FirstName = "Laura", LastName = "Callahan", DOB = new DateTime(2018, 10, 3), ID = 16, Salary = 900000, ReportsTo = 4, Title = "Sales Manager" });
            tmp.Children.Add(new EmployeeInfo() { FirstName = "Anne", LastName = "Dodsworth", DOB = new DateTime(2018, 10, 3), ID = 17, Salary = 800000, ReportsTo = 4, Title = "Sales Representative" });
            tmp.Children.Add(new EmployeeInfo() { FirstName = "Albert", LastName = "Hellstern", DOB = new DateTime(2018, 10, 3), ID = 18, Salary = 750000, ReportsTo = 4, Title = "Sales Representative" });
            tmp.Children.Add(new EmployeeInfo() { FirstName = "Tim", LastName = "Smith", DOB = new DateTime(2018, 10, 3), ID = 19, Salary = 700000, ReportsTo = 4, Title = "Sales Representative" });
            tmp.Children.Add(new EmployeeInfo() { FirstName = "Justin", LastName = "Brid", DOB = new DateTime(2018, 10, 3), ID = 20, Salary = 700000, ReportsTo = 4, Title = "Sales Representative" });

            ////Back Office
            //tmp = new EmployeeInfo() { FirstName = "Andrew", LastName = "Madison", DOB = new DateTime(2018, 10, 3), Title = "Marketing", Salary = 4000000, ReportsTo = -1, ID = 5 };
            //employeeDetails.Add(tmp);
            //tmp.Children.Add(new EmployeeInfo() { FirstName = "Caroline", LastName = "Patterson", DOB = new DateTime(2018, 10, 3), ID = 21, Salary = 800000, ReportsTo = 5, Title = "Receptionist" });
            //tmp.Children.Add(new EmployeeInfo() { FirstName = "Xavier", LastName = "Martin", DOB = new DateTime(2018, 10, 3), ID = 22, Salary = 700000, ReportsTo = 5, Title = "Mail Clerk" });

            ////HR
            //tmp = new EmployeeInfo() { FirstName = "Ulysses", LastName = "Pierce", DOB = new DateTime(2018, 10, 3), Title = "HumanResource", Salary = 1500000, ReportsTo = -1, ID = 6 };
            //employeeDetails.Add(tmp);
            //tmp.Children.Add(new EmployeeInfo() { FirstName = "Laurent", LastName = "Pereira", DOB = new DateTime(2018, 10, 3), ID = 23, Salary = 900000, ReportsTo = 6, Title = "HR Manager" });
            //tmp.Children.Add(new EmployeeInfo() { FirstName = "Syed", LastName = "Abbas", DOB = new DateTime(2018, 10, 3), ID = 24, Salary = 650000, ReportsTo = 6, Title = "HR Assistant" });
            //tmp.Children.Add(new EmployeeInfo() { FirstName = "Amy", LastName = "Alberts", DOB = new DateTime(2018, 10, 3), ID = 25, Salary = 650000, ReportsTo = 6, Title = "HR Assistant" });

            ////Purchasing
            //tmp = new EmployeeInfo() { FirstName = "Jimmy", LastName = "Harrison", DOB = new DateTime(2018, 10, 3), Title = "Purchasing", Salary = 200000, ReportsTo = -1, ID = 7 };
            //employeeDetails.Add(tmp);
            //tmp.Children.Add(new EmployeeInfo() { FirstName = "Pamela", LastName = "Ansman-Wolfe", DOB = new DateTime(2018, 10, 3), ID = 26, Salary = 600000, ReportsTo = 7, Title = "Purchase Manager" });
            //tmp.Children.Add(new EmployeeInfo() { FirstName = "Michael", LastName = "Blythe", DOB = new DateTime(2018, 10, 3), ID = 27, Salary = 550000, ReportsTo = 7, Title = "Store Keeper" });
            //tmp.Children.Add(new EmployeeInfo() { FirstName = "David", LastName = "Campbell", DOB = new DateTime(2018, 10, 3), ID = 28, Salary = 450000, ReportsTo = 7, Title = "Store Keeper" });

            ////Production
            //tmp = new EmployeeInfo() { FirstName = "Ronald", LastName = "Fillmore", DOB = new DateTime(2018, 10, 3), Title = "Production", Salary = 2800000, ReportsTo = -1, ID = 8 };
            //employeeDetails.Add(tmp);
            //tmp.Children.Add(new EmployeeInfo() { FirstName = "Jillian", LastName = "Carson", DOB = new DateTime(2018, 10, 3), ID = 29, Salary = 600000, ReportsTo = 8, Title = "Production Manager" });
            //tmp.Children.Add(new EmployeeInfo() { FirstName = "Shu", LastName = "Ito", DOB = new DateTime(2018, 10, 3), ID = 30, Salary = 550000, ReportsTo = 8, Title = "Production Engineer" });
            //tmp.Children.Add(new EmployeeInfo() { FirstName = "Stephen", LastName = "Jiang", DOB = new DateTime(2018, 10, 3), ID = 31, Salary = 450000, ReportsTo = 8, Title = "Production Engineer" });

            return employeeDetails;
        }
    }
}
