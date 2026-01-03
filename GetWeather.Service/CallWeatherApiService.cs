using Refit;

namespace GetWeather.Service
{
    public class WeatherQueryParams
    {
        [AliasAs("authKey")]
        public string AuthKey { get; set; } = string.Empty;

        [AliasAs("base_date")]
        public string BaseDate { get; set; } = string.Empty;

        [AliasAs("base_time")]
        public string BaseTime { get; set; } = string.Empty;

        [AliasAs("numOfRows")]
        public string NumOfRows { get; set; } = string.Empty;

        [AliasAs("nx")]
        public string Nx { get; set; } = string.Empty;

        [AliasAs("ny")]
        public string Ny { get; set; } = string.Empty;

        [AliasAs("pageNo")]
        public string PageNo { get; set; } = string.Empty;
    }

    public class WeatherItem
    {
        public string BaseDate { get; set; } = string.Empty;
        public string BaseTime { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Nx { get; set; } = string.Empty;
        public string Ny { get; set; } = string.Empty;
        public string ObsrValue { get; set; } = string.Empty;

    }

    public interface ICallWeatherApiService
    {
        [Get("/getUltraSrtNcst")]
        Task<string> GetWeatherAsync([Query] WeatherQueryParams parameter);
    }
}