using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс реализует сериализацию и десериализацию данных.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Возвращает и задает путь куда будут сериализоватся данные.
        /// </summary>
        public static string Path { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ProjectSerializer"/>.
        /// </summary>
        static ProjectSerializer()
        {
            Path = @"..\..\Data\";
        }

        public static bool IsFile(string nameFile)
        {
            return File.Exists(Path + nameFile);
        }

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="listObject">Коллекция класса <see cref="Item"/></param>
        public static void Serialize<T>(string nameFile, List<T> listObject)
        {
            using (StreamWriter writer = new StreamWriter(Path + nameFile))
            {
                writer.Write(JsonConvert.SerializeObject(listObject));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию товаров.</returns>
        public static List<T> Deserialize<T>(string nameFile)
        {
            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            var items = new List<T>();
            
            using (StreamReader reader = new StreamReader(Path + nameFile))
            {
                    items = JsonConvert.DeserializeObject<List<T>>(reader.ReadToEnd());
            }
            return items;
        }
    }
}