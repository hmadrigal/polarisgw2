using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ArenaNet.GuildWars2
{
    public sealed class Gw2HttpClient : IGw2HttpClient
    {
        public async Task<Stream> GetStreamAsync(Uri uri)
        {
            var webRequest = WebRequest.CreateHttp(uri);
            // NOTE: Even though WebResponse is IDisposable, on Desktop/Store apps it will return a disposed stream if disposed into this method. On Phone it can be disposed and the code still working well
            var webResponse = await Task<WebResponse>.Factory.FromAsync(webRequest.BeginGetResponse, webRequest.EndGetResponse, TaskCreationOptions.None);
            return webResponse.GetResponseStream();
        }

        private void InitializeHttpClient()
        {
        }

        #region Singleton Pattern w/ Constructor
        private Gw2HttpClient()
            : base()
        {
            InitializeHttpClient();
        }
        public static Gw2HttpClient Instance
        {
            get
            {
                return SingletonHttpClientCreator._Instance;
            }
        }
        private class SingletonHttpClientCreator
        {
            private SingletonHttpClientCreator() { }
            public static Gw2HttpClient _Instance = new Gw2HttpClient();
        }
        #endregion
    }
}
