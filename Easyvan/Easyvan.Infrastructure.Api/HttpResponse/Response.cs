using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Easyvan.Infrastructure.Api.HttpResponse
{
    public class Response<T> : IHttpActionResult
        where T : class
    {
        public const string contentType = "application/json";
        public readonly DateTime Date;
        public HttpStatusCode StatusCode { get; set; }
        public string StatusValue {
            get {
                return Enum.IsDefined(typeof(HttpStatusCode), StatusCode) 
                    ? Enum.GetName(typeof(HttpStatusCode), StatusCode) : string.Empty;
            }
        }

        public string Message { get; set; }
        public ICollection<T> Data { get; set; }
        public int Total {
            get {
                return this.Data == null ? 0 : this.Data.Count;
            }
        }

        public Response(HttpStatusCode status, string message,ICollection<T> data) {
            this.StatusCode = Enum.IsDefined(typeof(HttpStatusCode), status) ? status : HttpStatusCode.InternalServerError;
            this.Message = string.IsNullOrEmpty(message) ? string.Empty : message;
            this.Date = DateTime.Now;
            if (data == null)
                this.Data = new List<T>();
            else
                this.Data = data;

        }

        public Response(HttpStatusCode status, string message, IEnumerable<T> data) {
            this.StatusCode = Enum.IsDefined(typeof(HttpStatusCode), status) ? status : HttpStatusCode.InternalServerError;
            this.Message = string.IsNullOrEmpty(message) ? string.Empty : message;
            this.Date = DateTime.Now;
            if (data == null)
                this.Data = new List<T>();
            else
                this.Data = data.ToList();
        }

        public Response(HttpStatusCode status, string message, T data) {
            this.StatusCode = Enum.IsDefined(typeof(HttpStatusCode), status) ? status : HttpStatusCode.InternalServerError;
            this.Message = string.IsNullOrEmpty(message) ? string.Empty : message;
            this.Date = DateTime.Now;
            this.Data = new List<T>();
            if (data == null)
                this.Data.Add(data);
        }

        public Response(HttpStatusCode status, string message) {
            this.StatusCode = Enum.IsDefined(typeof(HttpStatusCode), status) ? status : HttpStatusCode.InternalServerError ;
            this.Message = string.IsNullOrEmpty(message) ? string.Empty : message;
            this.Date = DateTime.Now;
            this.Data = new List<T>();
        }



        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken) {
            var response = new HttpResponseMessage(this.StatusCode);
            response.Content = new StringContent(JsonConvert.SerializeObject(this));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue(contentType);
            return Task.FromResult(response);
        }
    }
}
