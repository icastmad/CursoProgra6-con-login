using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace WebAplicacion
{
    public static class ExtensionHttp
    {


        public static async Task<T> ServicioGetAsync<T>(this HttpClient client, string url)
        {
            using (var result = client.GetFromJsonAsync<T>(url))
            {
                return await result;
            }

        }



        public static async Task<T> ServicioDeleteAsync<T>(this HttpClient client, string url)
        {
            using (var result = await client.DeleteAsync(url))
            {
                if (!result.IsSuccessStatusCode) throw new Exception(result.ReasonPhrase);

                return await result.Content.ReadFromJsonAsync<T>();
            }

        }


        public static async Task<T> ServicioPostAsync<T>(this HttpClient client, string url)
        {
            using (var result = await client.PostAsJsonAsync(url, ""))
            {
                if (!result.IsSuccessStatusCode) throw new Exception(result.ReasonPhrase);

                return await result.Content.ReadFromJsonAsync<T>();
            }

        }


        public static async Task<TResul> ServicioPostAsync<TSend, TResul>(this HttpClient client, string url, TSend val)
        {
            using (var result = await client.PostAsJsonAsync(url, val))
            {
                if (!result.IsSuccessStatusCode) throw new Exception(result.ReasonPhrase);

                return await result.Content.ReadFromJsonAsync<TResul>();
            }

        }

        public static async Task<TResul> ServicioPostAsync<TResul>(this HttpClient client, string url, TResul val)
        {
            using (var result = await client.PostAsJsonAsync(url, val))
            {
                if (!result.IsSuccessStatusCode) throw new Exception(result.ReasonPhrase);

                return await result.Content.ReadFromJsonAsync<TResul>();
            }

        }

        public static async Task<T> ServicioPutAsync<T>(this HttpClient client, string url)
        {
            using (var result = await client.PutAsJsonAsync(url, ""))
            {
                if (!result.IsSuccessStatusCode) throw new Exception(result.ReasonPhrase);

                return await result.Content.ReadFromJsonAsync<T>();
            }

        }


        public static async Task<TResul> ServicioPutAsync<TSend, TResul>(this HttpClient client, string url, TSend val)
        {
            using (var result = await client.PutAsJsonAsync(url, val))
            {
                if (!result.IsSuccessStatusCode) throw new Exception(result.ReasonPhrase);

                return await result.Content.ReadFromJsonAsync<TResul>();
            }

        }

        public static async Task<TResul> ServicioPutAsync<TResul>(this HttpClient client, string url, TResul val)
        {
            using (var result = await client.PutAsJsonAsync(url, val))
            {
                if (!result.IsSuccessStatusCode) throw new Exception(result.ReasonPhrase);

                return await result.Content.ReadFromJsonAsync<TResul>();
            }

        }




    }
}
