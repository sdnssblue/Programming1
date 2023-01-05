using System.IO;
using Newtonsoft.Json;
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

        private static JsonSerializerSettings settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        };

        /// <summary>
        /// Проверка на существование файла.
        /// </summary>
        /// <param name="nameFile">Имя файла.</param>
        /// <returns></returns>
        public static bool IsFile(string nameFile)
        {
            return File.Exists(Path + nameFile);
        }

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="nameFile">Имя файла для сохранения.</param>
        /// <param name="obj">Имя объекта для сохранения.</param>
        public static void Serialize(string nameFile, object obj)
        {
            using (StreamWriter writer = new StreamWriter(Path + nameFile))
            {
                writer.Write(JsonConvert.SerializeObject(obj, settings));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <param name="nameFile">Имя файла для загрузки объектов.</param>
        /// <returns>Объект типа <see cref="Store"/></returns>
        public static Store Deserialize(string nameFile)
        {
            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            Store store;
            
            using (StreamReader reader = new StreamReader(Path + nameFile))
            {
                    store = JsonConvert.DeserializeObject<Store>(reader.ReadToEnd());
            }

            return store;
        }
    }
}