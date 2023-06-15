using Newtonsoft.Json;

namespace Malfurion.Common;

public static class Json
{
    public static string Serialize(object obj) => JsonConvert.SerializeObject(obj);

    public static T SafeDeserialize<T>(string json)
        where T : class, new()
    {
        try
        {
            return JsonConvert.DeserializeObject<T>(json) ?? new();
        }
        catch
        {
            return new();
        }
    }
}