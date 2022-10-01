using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using static System.Environment;

namespace ObjectOrientedPractics.Services
{
    public static class ProjectSerializer
    {
        static ProjectSerializer()
        {
            Path = $@"{GetFolderPath(SpecialFolder.ApplicationData)}" + "/Medyankin/ItemSerialize/";
            FileName = "ItemSerialize.json";

            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="items">Коллекция класса <see cref="Employee"/></param>
        public static void Serialize(List<Item> items)
        {
            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            using (StreamWriter writer = new StreamWriter(Path + FileName))
            {
                writer.Write(JsonConvert.SerializeObject(items));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию сотрудников.</returns>
        public static List<Item> Deserialize(Item item)
        {
            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            var items = new List<Item>();

            try
            {
                using (StreamReader reader = new StreamReader(Path + FileName))
                {
                    items = JsonConvert.DeserializeObject<List<Item>>(reader.ReadToEnd());
                }

                if (items == null) items = new List<Item>();
            }
            catch
            {
                return items;
            }

            return items;
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