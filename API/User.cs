using Newtonsoft.Json.Linq;
using TornSharp.API.Classes;
using TornSharp.Settings;

namespace TornSharp.API {
    internal class User {

        // Create our http client to send requests to the API
        private static readonly HttpClient client = new HttpClient();

        internal static async Task<ApiUserBasic?> GetUserBasic() {
            try {
                HttpResponseMessage response = await client.GetAsync($"https://api.torn.com/v2/user/basic?striptags=false&comment=TornSharp&key={UserSettings.Default.ApiKey}");
                response.EnsureSuccessStatusCode();

                string responseString = await response.Content.ReadAsStringAsync();
                JObject responseJson = JObject.Parse(responseString);
                return responseJson["profile"]?.ToObject<ApiUserBasic>();
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message, "TornSharp Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        internal static async Task<ApiUserBars?> GetUserBars() {
            try {
                HttpResponseMessage response = await client.GetAsync($"https://api.torn.com/v2/user/bars?comment=TornSharp&key={UserSettings.Default.ApiKey}");
                response.EnsureSuccessStatusCode();

                string responseString = await response.Content.ReadAsStringAsync();
                JObject responseJson = JObject.Parse(responseString);
                return responseJson["bars"]?.ToObject<ApiUserBars>();
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message, "TornSharp Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        internal static async Task<ApiUserMoney?> GetUserMoney() {
            try {
                HttpResponseMessage response = await client.GetAsync($"https://api.torn.com/v2/user/money?comment=TornSharp&key={UserSettings.Default.ApiKey}");
                response.EnsureSuccessStatusCode();

                string responseString = await response.Content.ReadAsStringAsync();
                JObject responseJson = JObject.Parse(responseString);
                return responseJson["money"]?.ToObject<ApiUserMoney>();
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message, "TornSharp Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}