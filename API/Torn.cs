using Newtonsoft.Json.Linq;
using TornSharp.API.Classes;
using TornSharp.Settings;

namespace TornSharp.API {
    internal class Torn {

        // Create our http client to send requests to the API
        private static readonly HttpClient client = new HttpClient();

        internal static async Task<ApiTornTimestamp?> GetTornTimestamp() {
            try {
                HttpResponseMessage response = await client.GetAsync($"https://api.torn.com/v2/torn/timestamp?comment=TornSharp&key={UserSettings.Default.ApiKey}");
                response.EnsureSuccessStatusCode();

                string responseString = await response.Content.ReadAsStringAsync();
                JObject responseJson = JObject.Parse(responseString);
                return responseJson?.ToObject<ApiTornTimestamp>();
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message, "TornSharp Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

    }
}