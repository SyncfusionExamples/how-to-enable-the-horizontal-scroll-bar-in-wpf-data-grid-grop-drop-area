using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestingSample.Model
{
   public class BusinessObjects : INotifyPropertyChanged
    {
        private string _ename;
        public string EmployeeName
        {
            get
            {
                return _ename;
            }
            set
            {
                _ename = value;
                OnPropertyChanged("EmployeeName");
            }
        }
        private string _ename1;
        public string EmployeeName1
        {
            get
            {
                return _ename1;
            }
            set
            {
                _ename1 = value;
                OnPropertyChanged("EmployeeName1");
            }
        }
        private string _ename2;
        public string EmployeeDesignation
        {
            get
            {
                return _ename2;
            }
            set
            {
                _ename2 = value;
                OnPropertyChanged("EmployeeDesignation");
            }
        }
        private string _ename3;
        public string EmployeeNative
        {
            get
            {
                return _ename3;
            }
            set
            {
                _ename3 = value;
                OnPropertyChanged("EmployeeNative");
            }
        }
        private string _ename4;
        public string Experience
        {
            get
            {
                return _ename4;
            }
            set
            {
                _ename4 = value;
                OnPropertyChanged("Experience");
            }
        }
        private string _ename5;
        public string Address
        {
            get
            {
                return _ename5;
            }
            set
            {
                _ename5 = value;
                OnPropertyChanged("Address");
            }
        }
        private string _ename6;
        public string EmployeeName6
        {
            get
            {
                return _ename6;
            }
            set
            {
                _ename6 = value;
                OnPropertyChanged("EmployeeName6");
            }
        }
        private string _ename7;
        public string EmployeeName7
        {
            get
            {
                return _ename7;
            }
            set
            {
                _ename7 = value;
                OnPropertyChanged("EmployeeName7");
            }
        }

        private string _earea;
        public string EmployeeArea
        {
            get
            {
                return _earea;
            }
            set
            {
                _earea = value;
                OnPropertyChanged("EmployeeArea");
            }
        }

        private string _city;
        public string EmployeeCity
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
                OnPropertyChanged("EmployeeCity");
            }
        }

        private double _salary;
        public double EmployeeSalary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
                OnPropertyChanged("EmployeeSalary");
            }
        }


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }

 
}
