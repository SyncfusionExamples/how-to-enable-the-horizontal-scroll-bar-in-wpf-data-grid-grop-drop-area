using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTestingSample.Model;

namespace WpfTestingSample
{
    public class Viewmodel
    {
        public string Name { get; set; }
     
        private ObservableCollection<BusinessObjects> gdcsource;
        public ObservableCollection<BusinessObjects> GDCSource
        {
            get
            {
                return gdcsource;
            }
            set
            {
                gdcsource = value;
            }
        }

        public Viewmodel()
        {
           var data = new ObservableCollection<BusinessObjects>();

            for (int i = 0; i < 10; i++)
            {
                data.Add(new BusinessObjects() { EmployeeName = "Ragul", EmployeeName1 = "Ragul", EmployeeDesignation = "Ragul", EmployeeNative = "Ragul", Experience = "Ragul", Address = "Ragul",EmployeeName6 = "Ragul",EmployeeName7 = "Ragul", EmployeeArea = "US", EmployeeCity = "sader" });
                data.Add(new BusinessObjects() { EmployeeName = "Mike", EmployeeName1 = "haju", EmployeeDesignation = "Ragul", EmployeeNative = "Ragul", Experience = "Ragul", Address = "Ragul", EmployeeName6 = "Ragul", EmployeeName7 = "Ragul", EmployeeArea = "US", EmployeeCity = "sader" });
                data.Add(new BusinessObjects() { EmployeeName = "Jhon", EmployeeName1 = "jaik", EmployeeDesignation = "Ragul", EmployeeNative = "Ragul", Experience = "Ragul", Address = "Ragul", EmployeeName6 = "Ragul", EmployeeName7 = "Ragul", EmployeeArea = "US", EmployeeCity = "sader" });
                data.Add(new BusinessObjects() { EmployeeName = "Smith", EmployeeName1 = "hagt", EmployeeDesignation = "Ragul", EmployeeNative = "Ragul", Experience = "Ragul", Address = "Ragul", EmployeeName6 = "Ragul", EmployeeName7 = "Ragul", EmployeeArea = "US", EmployeeCity = "sader" });
                data.Add(new BusinessObjects() { EmployeeName = "krish", EmployeeName1 = "jnh", EmployeeDesignation = "Ragul", EmployeeNative = "Ragul", Experience = "Ragul", Address = "Ragul", EmployeeName6 = "Ragul", EmployeeName7 = "Ragul", EmployeeArea = "US", EmployeeCity = "sader" });
                data.Add(new BusinessObjects() { EmployeeName = "Sam", EmployeeName1 = "Rastgul", EmployeeDesignation = "Ragul", EmployeeNative = "Ragul", Experience = "Ragul", Address = "Ragul", EmployeeName6 = "Ragul", EmployeeName7 = "Ragul", EmployeeArea = "US", EmployeeCity = "sader" });
                data.Add(new BusinessObjects() { EmployeeName = "Tom", EmployeeName1 = "hay", EmployeeDesignation = "Ragul", EmployeeNative = "Ragul", Experience = "Ragul", Address = "Ragul", EmployeeName6 = "Ragul", EmployeeName7 = "Ragul", EmployeeArea = "US", EmployeeCity = "sader" });
                //data.Add(new BusinessObjects() { EmployeeName = "Ragul7", EmployeeName1 = "ju", EmployeeDesignation = "Ragul", EmployeeNative = "Ragul", Experience = "Ragul", Address = "Ragul", EmployeeName6 = "Ragul", EmployeeName7 = "Ragul", EmployeeArea = "US", EmployeeCity = "sader" });
            }

            this.gdcsource = data;
        }
    }
}
