using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2
{
    public sealed class Gw2JsonDeserializer : IGw2JsonDeserializer
    {
        public T Deserialize<T>(System.IO.Stream input)
        {
            var jsonSerializer = JsonSerializer.CreateDefault();
            using (var streamReader = new System.IO.StreamReader(input))
            {
                using (var jsonTextReader = new JsonTextReader(streamReader))
                {
                    var instanceOfT = jsonSerializer.Deserialize<T>(jsonTextReader);
                    return instanceOfT;
                }
            }
        }

        private void InitializeGw2JsonDeserializer()
        {
        }

        #region Singleton Pattern w/ Constructor
        private Gw2JsonDeserializer()
            : base()
        {
            InitializeGw2JsonDeserializer();
        }
        public static Gw2JsonDeserializer Instance
        {
            get
            {
                return SingletonGw2JsonDeserializerCreator._Instance;
            }
        }
        private class SingletonGw2JsonDeserializerCreator
        {
            private SingletonGw2JsonDeserializerCreator() { }
            public static Gw2JsonDeserializer _Instance = new Gw2JsonDeserializer();
        }
        #endregion


    }
}
