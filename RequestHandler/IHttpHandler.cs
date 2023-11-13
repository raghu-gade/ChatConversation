using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestHandler
{
    public interface IHttpHandler
    {
        Task<TOut> PostRequestForAllCreations<TIn, TOut>(string uri, Dictionary<string, string> content, string accessToken);
        Task<T> GetRequest<T>(string uri, string accessToken);
        Task<TOut> PostRequest<TIn, TOut>(string uri, TIn content, string accessToken);

        //Task<TOut> PostRequestForCreateMessage<TIn, TOut>(string uri, CreateMessageTIn content, string accessToken);
        //Task<TOut> PostRequestForCall<TIn, TOut>(string uri, CallMaking content, string accessToken);
        //Task<TOut> PostRequestForCallRecord<TIn, TOut>(string uri, CallRecordEntity content, string accessToken);
        Task<T> DeleteRequest<T>(string uri, string accessToken);        
    }
}
