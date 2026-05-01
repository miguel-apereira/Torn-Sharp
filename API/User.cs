using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Specialized;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TornSharp.API.Classes;
using TornSharp.Settings;

namespace TornSharp.API {
    internal class User {

        // Create our http client to send requests to the API
        private static readonly HttpClient client = new HttpClient();

        internal static async Task<UserBasic?> GetBasicInfo() {
            try {
                HttpResponseMessage response = await client.GetAsync($"https://api.torn.com/v2/user/basic?striptags=false&comment=TornSharp&key={UserSettings.Default.ApiKey}");
                response.EnsureSuccessStatusCode();

                string responseString = await response.Content.ReadAsStringAsync();
                JObject responseJson = JObject.Parse(responseString);
                return responseJson["profile"]?.ToObject<UserBasic>();
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message, "TornSharp Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

    }
}