using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace ChlodnyWebApi.Formatter
{
    public class JsonpMediaFormatter : JsonMediaTypeFormatter
    {
        private static readonly string jsonpCallbackQueryParameter = "callback";
        private static readonly string mediaTypeHeaderTextJavascript = "text/javascript";
        private static readonly string pathExtensionJsonp = "jsonp";

        public JsonpMediaFormatter()
            : base()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue(mediaTypeHeaderTextJavascript));
            MediaTypeMappings.Add(new UriPathExtensionMapping(pathExtensionJsonp, DefaultMediaType));
        }

        protected override Task OnWriteToStreamAsync(Type type, object value, Stream stream, HttpContentHeaders contentHeaders, FormatterContext formatterContext, TransportContext transportContext)
        {
            //JSONP applies only for GET Requests.
            if (formatterContext.Response.RequestMessage.Method == HttpMethod.Get)
            {
                string jsonpCallback = GetJsonpCallbackMethodName(formatterContext.Response.RequestMessage);

                if (!String.IsNullOrEmpty(jsonpCallback))
                {
                    return Task.Factory.StartNew(() =>
                    {
                        var streamWriter = new StreamWriter(stream);
                        streamWriter.Write(jsonpCallback + "(");
                        streamWriter.Flush();
                        base.OnWriteToStreamAsync(type, value, stream, contentHeaders, formatterContext, transportContext).Wait();
                        streamWriter.Write(")");
                        streamWriter.Flush();
                    });
                }
            }

            return base.OnWriteToStreamAsync(type, value, stream, contentHeaders, formatterContext, transportContext);
        }

        private string GetJsonpCallbackMethodName(HttpRequestMessage httpRequestMessage)
        {
            var queryStrings = HttpUtility.ParseQueryString(httpRequestMessage.RequestUri.Query);
            return queryStrings[jsonpCallbackQueryParameter];
        }
    }
}