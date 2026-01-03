// C#
using Microsoft.AspNetCore.Mvc.RazorPages;
using GetWeather.Service;
using System.Xml.Linq;

public class IndexModel : PageModel
{
    private readonly ICallWeatherApiService _callWeatherApiService;

    public WeatherItem Weather { get; private set; }
    public string ErrorMessage { get; private set; } = string.Empty;

    public IndexModel(ICallWeatherApiService callWeatherApiService)
    {
        _callWeatherApiService = callWeatherApiService;
    }

    public async Task OnGetAsync()
    {
        try
        {
            var parameter = new WeatherQueryParams
            {
                NumOfRows = "10",
                PageNo = "1",
                BaseDate = "20260103",
                BaseTime = "0600",
                Nx = "55",
                Ny = "127",
                AuthKey = "ulrgkFceT4Ka4JBXHo-CuQ"
            };
            var xmlWeather = await _callWeatherApiService.GetWeatherAsync(parameter);
            var item = XDocument.Parse(xmlWeather)
                .Descendants("item")
                .FirstOrDefault(item => item.Element("category")?.Value == "T1H");

            Weather = new WeatherItem
            {
                BaseDate = item.Element("baseDate")?.Value,
                BaseTime = item.Element("baseTime")?.Value,
                Category = item.Element("category")?.Value,
                Nx = item.Element("nx")?.Value,
                Ny = item.Element("ny")?.Value,
                ObsrValue = item.Element("obsrValue")?.Value
            };

        }
        catch(Exception ex)
        {
            ErrorMessage = $"날씨 정보를 불러오는 중 오류가 발생했습니다. {ex.Message}";
        }
    }
}