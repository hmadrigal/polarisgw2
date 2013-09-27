namespace ArenaNet.GuildWars2
{
    using UriParameter = System.Collections.Generic.KeyValuePair<string, object>;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Gw2WebClient : IGw2WebClient
    {
        private readonly IEnumerable<UriParameter> EmptyUriParameters = Enumerable.Empty<UriParameter>();
        private readonly IRouteManager _routeManager;
        private readonly IGw2HttpClient _httpClient;
        private readonly IGw2JsonDeserializer _jsonDeserializer;

        public Gw2WebClient(IGw2HttpClient httpClient, IGw2JsonDeserializer jsonDeserializer)
        {
            _routeManager = Gw2ApiWebMethods.RouteManager;
            _httpClient = httpClient;
            _jsonDeserializer = jsonDeserializer;
        }

        protected virtual async System.Threading.Tasks.Task<T> GetJsonFromUri<T>(System.Uri uri)
        {
            using (var stream = await _httpClient.GetStreamAsync(uri))
            {
                var instanceOfT = (T)_jsonDeserializer.Deserialize(stream, typeof(T) );
                return instanceOfT;
            }
        }

        protected virtual async System.Threading.Tasks.Task<object> GetJsonFromUri(System.Uri uri, System.Type targetType)
        {
            using (var stream = await _httpClient.GetStreamAsync(uri))
            {
                var instanceOfT = _jsonDeserializer.Deserialize(stream, targetType);
                return instanceOfT;
            }
        }

        protected IEnumerable<T> GetEnumerable<T>(object instance)
        {
            IEnumerable<T> collection = instance as IEnumerable<T>;
            if (collection != null)
            {
                return collection;
            }
            if (instance is System.Collections.IEnumerable)
            {
                var enumerable = (instance is System.Collections.IEnumerable);
                collection = (instance as System.Collections.IEnumerable).OfType<T>();
            }
            return collection;
        }

        

        #region CRASH TEST CODE
#if CRASH_TEST

        internal const string InvalidUriString = @"https://api.invalidguildwars2.com";
        internal const double CrashProbability = 0.1;

        static System.Random _randomGenerator = new System.Random();


        private System.Uri GetCrashTestUri(System.Uri uri)
        {
            if (_randomGenerator.NextDouble() <= CrashProbability)
            {
                return new System.Uri(InvalidUriString);
            }
            else
            {
                return uri;
            }
        }

#endif
        #endregion


    }
}
