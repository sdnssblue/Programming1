using Employees.Model.Employees;

namespace Employees.Model
{
    /// <summary>
    /// Хранит данные о максимальных и минимальных константах.
    /// </summary>
    public static class InitialConstants
    {
        public const string SerializerResult = @"DataUser.json";

        /// <summary>
        /// Максимальное количество символов для <see cref="Employee.FullName"/>.
        /// </summary>
        public const int MaxLengthFullName = 80;

        /// <summary>
        /// Максимальное количество символов для <see cref="Employee.Post"/>.
        /// </summary>
        public const int MaxLengthPost = 40;

        /// <summary>
        /// Максимальное значение для <see cref="Employee.Salary"/>
        /// </summary>
        public const int MaxValueSalary = 1000000;

        /// <summary>
        /// Минимальное значение для <see cref="Employee.Salary"/>
        /// </summary>
        public const int MinValueSalary = 0;
    }
}