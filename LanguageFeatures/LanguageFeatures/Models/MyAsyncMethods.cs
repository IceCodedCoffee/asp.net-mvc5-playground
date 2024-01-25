using System.Net.Http;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();

            var httpMessage = await client.GetAsync("http://apress.com");

            // we could do other things in the CALLING CONTEXT while we are waiting
            // for the HTTP request to complete, await DID send control back to caller of method GetPageLength()

            return httpMessage.Content.Headers.ContentLength;
        }

        //public async static Task<long?> GetPageLength()
        //{
        //    HttpClient client = new HttpClient();

        //    Task<HttpResponseMessage> task = client.GetAsync("http://apress.com");

        //    // we could do other things RIGHT HERE BEFORE we start waiting
        //    // for the HTTP request to complete, await WILL send control back to caller of method GetPageLength()

        //    await task;

        //    we could do other things in the CALLING CONTEXT while we are waiting
        //    for the HTTP request to complete, await DID send control back to caller of method GetPageLength()

        //    return task.Result.Content.Headers.ContentLength;
        //}
    }
}