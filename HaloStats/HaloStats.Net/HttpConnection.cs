using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace HaloStats.Http
{
    internal class HttpConnection
    {
        private static HttpClient _httpClient;

        public static HttpClient HttpClient
        {
            get
            {
                if (_httpClient == null)
                    _httpClient = new HttpClient() { BaseAddress = new Uri("https://www.haloapi.com/") };
                return _httpClient;
            }
        }
    }
}
