using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;

namespace SuperParser.Core
{
    class ParserWorker<T> where T : class 
    {
        IParser<T> parser;
        IParserSettings parserSettings;
        HtmlLoader loader;
        bool isActive;

        public IParser<T> Parser
        {
            get { return parser; }
            set { parser = value; }
        }

        public IParserSettings Settings
        {
            get { return parserSettings; }
            set
            {
                    parserSettings = value; //Новые настройки парсера
                    loader = new HtmlLoader(value);
            }
        }

        public bool IsActive 
        {
            get { return IsActive; }
        }

        public event Action<object, T> OnNewData; //Это событие возвращает спаршенные за итерацию данные( первый аргумент ссылка на парсер, и сами данные вторым аргументом)
        public event Action<object> OnComplited; //Это событие отвечает информирование при завершении работы парсера.

        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Stop()
        {
            isActive = false;
        }

        public async void Worker()
        {
            for (int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++)
            {
                if (IsActive)
                {
                    string source = await loader.GetSourceByPage(i);
                    HtmlParser domParser = new HtmlParser();

                    IHtmlDocument document = await domParser.ParseDocumentAsync(source);

                    var result = parser.Parse(document);
                }
                return;
            }

            OnComplited?.Invoke(this);
            isActive = false;
        }
    }
}
