using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClassLibrary1CoreService
{
    public class ArithmeticAPIClient
    {
        public static async Task<int> AddNumbersAsync(string input1, string input2)
        {
            if (string.IsNullOrWhiteSpace(input1) || string.IsNullOrWhiteSpace(input2)) return default;

            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync($"http://localhost:60224/api/arithmetic/{input1}/{input2}");

                    response.EnsureSuccessStatusCode();

                    var content = await response.Content.ReadAsStringAsync();

                    //var data = JsonConvert.DeserializeObject<IEnumerable<WeatherForecast>>(content);

                    int.TryParse(content, out int result);

                    return result;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
