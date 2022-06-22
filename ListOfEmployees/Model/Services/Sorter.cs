using ListOfEmployees.Model.Employees;
using System.Collections.Generic;
using System.Linq;

namespace ListOfEmployees.Model
{
    /// <summary>
    /// Класс реализует сортировку данных.
    /// </summary>
    public static class Sorter
    {
        /// <summary>
        /// Проводит сортировку коллекции сотрудников по имени.
        /// </summary>
        /// <param name="employees">Коллекция класса <see cref="Employee"/>.</param>
        /// <returns>Возвращает отсортированную коллекцию рабочих.</returns>
        public static List<Employee> SortEmployeesByFullName(List<Employee> employees)
        {
            var sortedListEmployees = from employee in employees
                                      orderby employee.FullName
                                      select employee;

            return sortedListEmployees.ToList();
        }
    }
}