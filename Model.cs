using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfTreeGrid_MVVM
{
    public class EmployeeInfo: IDataErrorInfo,INotifyDataErrorInfo, INotifyPropertyChanged
    {
        int _id;
        string _firstName;
        string _lastName;
        DateTime _dob;
        private string _title;
        decimal _salary;
        int _reportsTo;
        EmployeeInfos _children;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

        public EmployeeInfos Children
        {
            get {
                if (_children == null)
                    _children = new EmployeeInfos();
                return _children;
            }
            set { _children = value; NotifyPropertyChanged(); }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; NotifyPropertyChanged(); }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; NotifyPropertyChanged(); }
        }

        public DateTime DOB
        {
            get { return _dob; }
            set { _dob = value; NotifyPropertyChanged(); }
        }

        public string DOBDateString
        {
            get
            {
                return "DOB: " + DOB.ToString("MM-yyyy"); ;
            }
        }

        [Range(1, 2, ErrorMessage = "ID between 1 and 2 alone processed")]
        public int ID
        {
            get { return _id; }
            set { _id = value; NotifyPropertyChanged(); }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; NotifyPropertyChanged(); }
        }

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; NotifyPropertyChanged(); }
        }

        public int ReportsTo
        {
            get { return _reportsTo; }
            set { _reportsTo = value; NotifyPropertyChanged(); }
        }

        [Display(AutoGenerateField = false)]

        public string Error => string.Empty;
       
        public string this[string columnName]
        {
            get
            {
                if (!columnName.Equals("Salary"))
                    return string.Empty;
                if (this.Salary < 10000 || this.Salary > 30000)
                    return "The 'Salary' field can range from 10000 to 30000 " ;

                return string.Empty;
            }
        }

        [Display(AutoGenerateField = false)]

        public bool HasErrors
        {
            get
            {
                return false;
            }
        }

        private List<string> errors = new List<string>();
        public IEnumerable GetErrors(string propertyName)
        {
            if (!propertyName.Equals("Title"))
                return null;

            if (this.Title.Contains("Management"))
                errors.Add("Management is not valid ");

            return errors;
        }
    }

    public class EmployeeInfos : ObservableCollection<EmployeeInfo>
    {

    }
}
