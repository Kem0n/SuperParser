namespace SuperParser
{
    interface IParserSettings
    {
        string BaseUrl { get; set; } //url сайта
        string Prefix { get; set; }
        int StartPoint { get; set; } //c какой страницы парсим данные
        int EndPoint { get; set; } //по какую страницу парсим данные
    }
}
