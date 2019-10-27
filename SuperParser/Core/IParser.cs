using AngleSharp.Html.Dom;

namespace SuperParser
{
    interface IParser<T> where T : class //класс реализующие этот интерфейс смогут возвращаться данные любого ссылочного типа
    {
        T Parse(IHtmlDocument document); // тип T при реализации будет заменяться на любой другой тип
    }
}
