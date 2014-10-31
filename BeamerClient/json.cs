using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace BeamerClient
{
    public static class Json<T>
    {
        public static string Serialize(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                serializer.WriteObject(ms, obj);
                var json = ms.ToArray();

                return Encoding.UTF8.GetString(json, 0, json.Length);
            }
        }

        public static T Deserialize(string json)
        {
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                return (T)serializer.ReadObject(ms);
            }
        }
    }
}
