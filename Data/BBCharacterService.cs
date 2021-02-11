using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BreakingBad.Data
{
    class BBCharacterService
    {
        private static readonly string apiRoot = "https://www.breakingbadapi.com/api";
        private static readonly string apiCharacterEndoint = apiRoot + "/characters?name=";
        public static async Task<List<BBCharacter>> GetCharactersFromName(string queryName)
        {
            try
            {
                var newName = queryName.Trim().Replace(' ', '+');
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(apiCharacterEndoint + newName))
                    {
                        using (HttpContent content = res.Content)
                        {
                            var data = await content.ReadAsStringAsync();
                            //If the data isn't null return log convert the data using newtonsoft JObject Parse class method on the data.
                            List<BBCharacter> characters = null;
                            if (data != null) characters = JsonConvert.DeserializeObject<List<BBCharacter>>(data);
                            return characters;
                        }
                    }
                }
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}
