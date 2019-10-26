using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace SuperParser
{
    //Предназначение этого класса загружать код HTML страницы из указанных настроек парсера.
    class HtmlLoader
    {
        readonly HttpClient client; //для отправки HTTP запросов и получения HTTP ответов.
        readonly string url; //сюда будем передовать адрес.

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "C# App");
            url = $"{settings.BaseUrl}/{settings.Prefix}/";
        }

        public async Task<string> GetSourceByPage(int id) // id - это id страницы
        {
            string currentUrl = url.Replace("{CurrentId}", id.ToString());//Подменяем {CurrentId} на номер страницы
            HttpResponseMessage responce = await client.GetAsync(currentUrl);
            string source = default;

            if (responce!=null && responce.StatusCode == HttpStatusCode.OK)
            {
                source = await responce.Content.ReadAsStringAsync();
            }
            return source;
        }
    }
}
