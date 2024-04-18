using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class CotacaoMoedas
{
    private readonly HttpClient _httpClient;

    public CotacaoMoedas()
    {
        _httpClient = new HttpClient();
    }

    public async Task<JObject> getAll()
    {
        try
        {
            string url = "https://economia.awesomeapi.com.br/last/USD-BRL,EUR-BRL,ARS-BRL";
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(jsonResponse);
                return data;
            }
            else
            {
                throw new HttpRequestException("ERRO AO ACESSAR API.\nERROR: " + response.StatusCode);
            }
        }
        catch (Exception ex)
        {
            throw new Exception("ERRO AO TENTAR OBTER AS COTAÇÕES.\nERROR: ", ex);
        }
    }
}
