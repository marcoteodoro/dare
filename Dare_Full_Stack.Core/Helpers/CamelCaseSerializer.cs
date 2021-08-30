using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Dare_Full_Stack.Core.Helpers
{
    public static class CamelCaseSerializer
    {
        public static string Serialize(object data)
        {
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
             new JsonSerializerSettings()
             {
                 ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                 ContractResolver = new CamelCasePropertyNamesContractResolver()
             });

            return json;
        }
    }
}
