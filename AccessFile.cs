using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MKcrud
{
    class AccessFile<T>
    {

        public static List<T> GetFile(string file)
        {
            var Mjson = File.ReadAllText(file);
            var list = JsonSerializer.Deserialize<List<T>>(Mjson);
            return list;
        }
        public static void SetFile(List<T> T, string file)
        {
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(T, options);
            File.WriteAllText(file, json);
        }

    }
}
