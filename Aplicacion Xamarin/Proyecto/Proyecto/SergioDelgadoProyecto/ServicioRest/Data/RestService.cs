﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SergioDelgadoProyecto.ServicioRest;

namespace SergioDelgadoProyecto
{
    public class RestService : IRestService
    {
        HttpClient _client;

        public List<Model_Post> Items { get; private set; }

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<List<Model_Post>> RefreshDataAsync()
        {
            Items = new List<Model_Post>();

            var uri = new Uri(string.Format("", string.Empty));
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<List<Model_Post>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Items;
        }

        public async Task SaveTodoItemAsync(Model_Post item)
        {
            var uri = new Uri(string.Format("http://192.168.1.21/proyectobdSigma/objetivo", string.Empty));

            try
            {
                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
              
              response = await _client.PutAsync(uri, content);
              

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tTodoItem successfully saved.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }

        public async Task DeleteTodoItemAsync(int id)
        {
            var uri = new Uri(string.Format("", id));

            try
            {
                var response = await _client.DeleteAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tTodoItem successfully deleted.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }

      
    }
}
