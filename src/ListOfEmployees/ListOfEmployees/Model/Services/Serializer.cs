using ListOfEmployees.Model.Employees;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using static System.Environment;

namespace ListOfEmployees.Model.Services
{
    /// <summary>
    /// Класс реализует сериализацию и десериализацию данных.
    /// </summary>
    public static class Serializer
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Serializer"/>.
        /// </summary>
        static Serializer()
        {
            Path = $@"{GetFolderPath(SpecialFolder.ApplicationData)}" + "/Medyankin/ListOfEmployees/";
            FileName = "data.json";

            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="employees">Коллекция класса <see cref="Employee"/></param>
        public static void Serialize(List<Employee> employees)
        {
            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            using (StreamWriter writer = new StreamWriter(Path + FileName))
            {
                writer.Write(JsonConvert.SerializeObject(employees));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию сотрудников.</returns>
        public static List<Employee> Deserialize()
        {
            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            var employees = new List<Employee>();

            try
            {
                using (StreamReader reader = new StreamReader(Path + FileName))
                {
                    employees = JsonConvert.DeserializeObject<List<Employee>>(reader.ReadToEnd());
                }

                if (employees == null) employees = new List<Employee>();
            }
            catch
            {
                return employees;
            }

            return employees;
        }

        /// <summary>
        /// Возвращает и задает путь куда будут сериализоватся данные.
        /// </summary>
        public static string Path { get; set; }

        /// <summary>
        /// Возвращает и задает имя файла.
        /// </summary>
        public static string FileName { get; set; }
    }
}