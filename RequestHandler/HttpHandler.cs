using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ConvertionEntities.Entities;
using System.Collections;

namespace RequestHandler
{
    public class HttpHandler : IHttpHandler
    {
        private readonly HttpClient client;
        public HttpHandler(HttpClient client)
        {
            this.client = client;
        }
        /// <summary>
        /// Post Api calls
        /// </summary>
        /// <typeparam name="TIn">Request body</typeparam>
        /// <typeparam name="TOut">Response</typeparam>
        /// <param name="uri">Request url</param>
        /// <param name="content">Request body</param>
        /// <param name="accessToken">Token for authentication</param>
        /// <returns></returns>
        public async Task<TOut> PostRequestForAllCreations<TIn, TOut>(string uri, Dictionary<string, string> keyValuePairs, string accessToken)
        {
            try
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var byteArray = Encoding.ASCII.GetBytes(accessToken);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));


                using (HttpResponseMessage response = await client.PostAsync(uri, new FormUrlEncodedContent(keyValuePairs)))
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        return JsonConvert.DeserializeObject<TOut>(responseBody);
                        //throw new Exception(responseBody);
                    }
                    if (response.StatusCode == HttpStatusCode.FailedDependency)
                    {

                    }

                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        throw new Exception("UNAUTHORIZED");
                    }
                    // check if error exist before serialization
                    return JsonConvert.DeserializeObject<TOut>(responseBody);
                }
            }
            catch (Exception ex)
            {
                // PASAuthorization.GeneratePASTokens(this.PASconfig);
                //await  this.PostRequest<TIn, TOut>(uri, content, PASAuthorization.authorizeToken);
                throw ex;
            }
        }

        private void createnewmothod(Dictionary<string, string> res)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///Get Api calls
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="uri">Request url</param>
        /// <param name="accessToken">Token for authentication</param>
        /// <returns></returns>
        public async Task<T> GetRequest<T>(string uri, string accessToken)
        {
            try
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var byteArray = Encoding.ASCII.GetBytes(accessToken);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                //client.DefaultRequestHeaders.Add("Authorization", accessToken);
                //if (!string.IsNullOrEmpty(accessToken))
                //{
                //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken.Replace("Bearer", ""));
                //}
                using (HttpResponseMessage response = await client.GetAsync(uri))
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    if (response.StatusCode.ToString() != HttpStatusCode.OK.ToString() && response.StatusCode.ToString() != HttpStatusCode.NoContent.ToString())
                    {
                        if (response.StatusCode == HttpStatusCode.NotFound)
                        {
                            return JsonConvert.DeserializeObject<T>(responseBody);
                            //throw new Exception(responseBody);
                        }

                        if (!string.IsNullOrEmpty(responseBody))
                        {
                            throw new Exception(responseBody);
                        }
                    }
                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {

                        throw new Exception("UNAUTHORIZED");
                    }

                    return JsonConvert.DeserializeObject<T>(responseBody);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Post Api calls
        /// </summary>
        /// <typeparam name="TIn">Request body</typeparam>
        /// <typeparam name="TOut">Response</typeparam>
        /// <param name="uri">Request url</param>
        /// <param name="content">Request body</param>
        /// <param name="accessToken">Token for authentication</param>
        /// <returns></returns>
        public async Task<TOut> PostRequest<TIn, TOut>(string uri, TIn content, string accessToken)
        {
            //FormUrlEncodedContent gg = new FormUrlEncodedContent(new Directory<string,string>(content));



            try
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var byteArray = Encoding.ASCII.GetBytes(accessToken);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                //  var req = JsonConvert.SerializeObject(content);
                // req = req.Replace(@"\", string.Empty);
                var serialized = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/x-www-form-urlencoded");

                using (HttpResponseMessage response = await client.PostAsync(uri, serialized))
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        return JsonConvert.DeserializeObject<TOut>(responseBody);
                        //throw new Exception(responseBody);
                    }
                    if (response.StatusCode == HttpStatusCode.FailedDependency)
                    {

                    }

                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        throw new Exception("UNAUTHORIZED");
                    }
                    // check if error exist before serialization
                    return JsonConvert.DeserializeObject<TOut>(responseBody);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<TOut> PostFormUrlEncodedRequest<TIn, TOut>(string uri, TIn content, string accessToken)
        {
            //FormUrlEncodedContent gg = new FormUrlEncodedContent(new Directory<string,string>(content));
            try
            {
                var json = JsonConvert.SerializeObject(content);
                var Tin = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);


                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var byteArray = Encoding.ASCII.GetBytes(accessToken);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                var serilize = new FormUrlEncodedContent(Tin);
                //var serialized = new StringContent(content, Encoding.UTF8, "application/x-www-form-urlencoded");

                using (HttpResponseMessage response = await client.PostAsync(uri, serilize))
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        return JsonConvert.DeserializeObject<TOut>(responseBody);
                        throw new Exception(responseBody);
                    }
                    if (response.StatusCode == HttpStatusCode.FailedDependency)
                    {

                    }
                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        throw new Exception("UNAUTHORIZED");
                    }
                    // check if error exist before serialization
                    return JsonConvert.DeserializeObject<TOut>(responseBody);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Delete Api calls
        /// </summary>
        /// <typeparam name="T">Response</typeparam>
        /// <param name="uri">Request url</param>
        /// <param name="accessToken">Token for authentication</param>
        /// <returns></returns>
        public async Task<T> DeleteRequest<T>(string uri, string accessToken)
        {
            try
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var byteArray = Encoding.ASCII.GetBytes(accessToken);

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                var response = await client.DeleteAsync(uri).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    response.Content?.Dispose();
                    throw new Exception(content);
                }
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseBody);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        #region Need to Remove Origin Code
        //       public async Task<TOut> PostRequestForCreateMessage<TIn, TOut>(string uri, CreateMessageTIn createMessage, string accessToken)
        //       {

        //           try
        //           {
        //               client.DefaultRequestHeaders.Clear();
        //               client.DefaultRequestHeaders.Accept.Add(
        //                   new MediaTypeWithQualityHeaderValue("application/json"));

        //               client.DefaultRequestHeaders.Accept.Clear();
        //               client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //               var byteArray = Encoding.ASCII.GetBytes(accessToken);

        //               client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

        //               using (HttpResponseMessage response = await client.PostAsync(uri, new FormUrlEncodedContent(new Dictionary<string, string>(){
        //{ "To", createMessage.to },
        //{ "From", createMessage.from },
        //{ "Body", createMessage.body } })))
        //               {
        //                   string responseBody = await response.Content.ReadAsStringAsync();
        //                   if (response.StatusCode == HttpStatusCode.BadRequest)
        //                   {
        //                       return JsonConvert.DeserializeObject<TOut>(responseBody);
        //                   }
        //                   if (response.StatusCode == HttpStatusCode.FailedDependency)
        //                   {

        //                   }

        //                   else if (response.StatusCode == HttpStatusCode.Unauthorized)
        //                   {
        //                       throw new Exception("UNAUTHORIZED");
        //                   }
        //                   return JsonConvert.DeserializeObject<TOut>(responseBody);
        //               }
        //           }
        //           catch (Exception ex)
        //           {
        //               throw ex;
        //           }
        //       }
        //       public async Task<TOut> PostRequestForCall<TIn, TOut>(string uri, CallMaking callMaking, string accessToken)
        //       {

        //           try
        //           {
        //               client.DefaultRequestHeaders.Clear();
        //               client.DefaultRequestHeaders.Accept.Add(
        //                   new MediaTypeWithQualityHeaderValue("application/json"));

        //               client.DefaultRequestHeaders.Accept.Clear();
        //               client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //               var byteArray = Encoding.ASCII.GetBytes(accessToken);

        //               client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

        //               using (HttpResponseMessage response = await client.PostAsync(uri, new FormUrlEncodedContent(new Dictionary<string, string>(){
        //{ "To", callMaking.to },
        //{ "From", callMaking.from },
        //{ "Twiml", callMaking.twiml },//"Twiml" is Optional or May not Required
        //{ "ApplicationSid", callMaking.applicationSid },
        //{ "Url", callMaking.url } })))//"Url" is Optional or May not Required
        //               {
        //                   string responseBody = await response.Content.ReadAsStringAsync();
        //                   if (response.StatusCode == HttpStatusCode.BadRequest)
        //                   {
        //                       return JsonConvert.DeserializeObject<TOut>(responseBody);
        //                   }
        //                   if (response.StatusCode == HttpStatusCode.FailedDependency)
        //                   {

        //                   }

        //                   else if (response.StatusCode == HttpStatusCode.Unauthorized)
        //                   {
        //                       throw new Exception("UNAUTHORIZED");
        //                   }
        //                   return JsonConvert.DeserializeObject<TOut>(responseBody);
        //               }
        //           }
        //           catch (Exception ex)
        //           {
        //               throw ex;
        //           }
        //       }
        //       public async Task<TOut> PostRequestForCallRecord<TIn, TOut>(string uri, CallRecordEntity callRecord, string accessToken)
        //       {

        //           try
        //           {
        //               client.DefaultRequestHeaders.Clear();
        //               client.DefaultRequestHeaders.Accept.Add(
        //                   new MediaTypeWithQualityHeaderValue("application/json"));

        //               client.DefaultRequestHeaders.Accept.Clear();
        //               client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //               var byteArray = Encoding.ASCII.GetBytes(accessToken);

        //               client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

        //               using (HttpResponseMessage response = await client.PostAsync(uri, new FormUrlEncodedContent(new Dictionary<string, string>(){
        //{ "To", callRecord.CallSid },
        //{ "From", callRecord.AcountSid },
        // })))
        //               {
        //                   string responseBody = await response.Content.ReadAsStringAsync();
        //                   if (response.StatusCode == HttpStatusCode.BadRequest)
        //                   {
        //                       return JsonConvert.DeserializeObject<TOut>(responseBody);
        //                   }
        //                   if (response.StatusCode == HttpStatusCode.FailedDependency)
        //                   {

        //                   }

        //                   else if (response.StatusCode == HttpStatusCode.Unauthorized)
        //                   {
        //                       throw new Exception("UNAUTHORIZED");
        //                   }
        //                   return JsonConvert.DeserializeObject<TOut>(responseBody);
        //               }
        //           }
        //           catch (Exception ex)
        //           {
        //               throw ex;
        //           }
        //       }
        #endregion
    }
}
