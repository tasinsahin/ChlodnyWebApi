using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChlodnyWebApi.WebServices
{
    using ChlodnyWebApi.Models;

    using DataAccess;

    using DomainClasses.EntitiesChinook;

    /// <summary>
    /// Summary description for CustomerHandler
    /// </summary>
    public class ArtistHandler : IHttpHandler
    {
        private string methodName = string.Empty;

        private string callBackMethodName = string.Empty;

        private object parameter = string.Empty;

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/x-javascript";
            this.methodName = context.Request.Params["method"];
            this.parameter = context.Request.Params["param"];
            this.callBackMethodName = context.Request.Params["callbackmethod"];

            switch (this.methodName.ToLower())
            {
                case "getartist":
                    context.Response.Write(GetArtist());
                    break;

            }
        }

        private string GetArtist()
        {
            var response = new JsonResponseMessage();
            var jSearializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            try
            {
                List<Artist> results;
                using (var ormContext = new ChinookContext())
                {
                    results = ormContext.Artists.ToList();
                }
                // var results = this.contexts1.Artists.ToList();
                response.IsSucess = true;
                response.Message = string.Empty;
                response.CallBack = this.callBackMethodName;
                response.ResponseData = results;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.IsSucess = false;
            }
            return jSearializer.Serialize(response);
        }
    }
}