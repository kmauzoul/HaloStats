﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace HaloStats.Http
{
    /// <summary>
    /// This will be a collection of async REST calls to various end points
    /// Primary Key: 85f2f9f177344b15b17510261707e347
    /// Secondary Key: eadb9e3c2e754194a80dc8ff9d33d967
    /// </summary>
    public class HttpREST
    {
        const string ContentType = "application/json";

        #region Methods
        private void InitializeClient()
        {
            HttpConnection.HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpConnection.HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ContentType));
            HttpConnection.HttpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "85f2f9f177344b15b17510261707e347");
        }

        public async Task<System.IO.Stream> GetImage(string EndPoint)
        {
            InitializeClient();
            
            try
            {
                HttpResponseMessage response = await HttpConnection.HttpClient.GetAsync(EndPoint);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    return await response.Content.ReadAsStreamAsync();
                else
                    throw new Exception($"{response.StatusCode} - {response.ReasonPhrase}");
            }
            catch
            {
                throw;
            }
        }

        public async Task<T> GetItem<T>(string EndPoint)
        {
            InitializeClient();

            try
            {
                HttpResponseMessage response = await HttpConnection.HttpClient.GetAsync(EndPoint);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                else
                    throw new Exception($"{response.StatusCode} - {response.ReasonPhrase}");
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
