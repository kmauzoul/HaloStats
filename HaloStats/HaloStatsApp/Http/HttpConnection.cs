using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace HaloStatsApp.Http
{
    internal class HttpConnection
    {
        private static HttpClient _httpClient;

        internal static HttpClient HttpClient
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
