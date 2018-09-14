using Newtonsoft.Json;
using System;
namespace Numerek.Core
{
    /// <summary>
    /// Serialize results to JSON
    /// </summary>
    public class ZomJsonOutputStrategy
    {
        /// <summary>
        /// Method take Kolejki type as parameter and serialize it to JSON string
        /// </summary>
        /// <param name="data"></param>
        /// <returns>string type with JSON</returns>
        public string Execute(Kolejki data)
        {
            var result = JsonConvert.SerializeObject(data);
            Console.WriteLine(result);
            return result;

        }
        
    }
}
