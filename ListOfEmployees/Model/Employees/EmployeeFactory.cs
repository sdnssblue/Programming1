using System;

namespace ListOfEmployees.Model.Employees
{
    /// <summary>
    /// Класс создает шаблон для заполнения информации о рабочем.
    /// </summary>
    public static class EmployeeFactory
    {
        /// <summary>
        /// Создание шаблона для заполнения информации о сотруднике.
        /// </summary>
        /// <returns> Шаблон для заполнения информации о сотруднике. </returns>
        public static Employee CreateDefault()
        {
            Employee employee = new Employee();
            employee.Salary = 0;
            employee.FullName = "ФИО";
            employee.Post = "Должность";
            employee.DateOfEmployment = DateTime.Today.AddDays(-1);
            return employee;
        }
    }
}