using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChlodnyWebApi
{
    using System.IO;
    using System.Net.Http.Formatting;
    using System.Threading.Tasks;
    using ChlodnyWebApi.Controllers;


    public class MyJSONPMediaTypeFormatter : MediaTypeFormatter
    {
        protected override bool CanWriteType(Type type)
        {
            if (type == typeof(ValuesController.JsonPReturn))
            {
                return true;
            }

            return base.CanWriteType(type);
        }

        protected override Task OnWriteToStreamAsync(Type type, object value, Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, FormatterContext formatterContext, System.Net.TransportContext transportContext)
        {

            return Task.Factory.StartNew(
                (o) =>
                    {
                        var td = o as TaskData;
                        var sw = new StreamWriter(td.Stream, UTF8Encoding.Default);
                        sw.Write("{0}({1});", td.JsonP.CallbackName, td.JsonP.Json);
                        sw.Flush();
                    },
                new TaskData { JsonP = (ValuesController.JsonPReturn)value, Stream = stream });
        }
    }
}
