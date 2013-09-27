using ArenaNet.GuildWars2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2
{
    public sealed class Gw2JsonDeserializer : IGw2JsonDeserializer
    {
        private readonly Dictionary<Type, Type> _interfaceMapping = new Dictionary<Type, Type>()
        {
#region Collections
            {typeof(List<IWorldVsWorldObjective>), typeof(List<WorldVsWorldObjective>)},
            {typeof(List<IWorldVsWorldMatches>), typeof(List<WorldVsWorldMatches>)},
            {typeof(List<IWorldVsWorldMatchDetails>), typeof(List<WorldVsWorldMatchDetails>)},
            {typeof(List<IWorldVsWorldMatch>), typeof(List<WorldVsWorldMatch>)},
            {typeof(List<IWorldVsWorldMap>), typeof(List<WorldVsWorldMap>)},
            {typeof(List<IWorld>), typeof(List<World>)},
            {typeof(List<IWeaponAttribute>), typeof(List<WeaponAttribute>)},
            {typeof(List<IWeapon>), typeof(List<Weapon>)},
            {typeof(List<ITask>), typeof(List<Task>)},
            {typeof(List<ISkillChallenge>), typeof(List<SkillChallenge>)},
            {typeof(List<ISector>), typeof(List<Sector>)},
            {typeof(List<IRegion>), typeof(List<Region>)},
            {typeof(List<IRecipeDetails>), typeof(List<RecipeDetails>)},
            {typeof(List<IPointsOfInterest>), typeof(List<PointsOfInterest>)},
            {typeof(List<IObjectiveName>), typeof(List<ObjectiveName>)},
            {typeof(List<IMetal>), typeof(List<Metal>)},
            {typeof(List<IMapRegionDetails>), typeof(List<MapRegionDetails>)},
            {typeof(List<IMapFloor>), typeof(List<MapFloor>)},
            {typeof(List<IMapDetails>), typeof(List<MapDetails>)},
            {typeof(List<IMapDescriptions>), typeof(List<MapDescriptions>)},
            {typeof(List<IMap>), typeof(List<Map>)},
            {typeof(List<ILocation>), typeof(List<Location>)},
            {typeof(List<ILeather>), typeof(List<Leather>)},
            {typeof(List<IItemDetails>), typeof(List<ItemDetails>)},
            {typeof(List<IIngredient>), typeof(List<Ingredient>)},
            {typeof(List<IInfixUpgrade>), typeof(List<InfixUpgrade>)},
            {typeof(List<IGuild>), typeof(List<Guild>)},
            {typeof(List<IEventName>), typeof(List<EventName>)},
            {typeof(List<IEventDetail>), typeof(List<EventDetail>)},
            {typeof(List<IEventDescriptions>), typeof(List<EventDescriptions>)},
            {typeof(List<IEvent>), typeof(List<Event>)},
            {typeof(List<IEmblem>), typeof(List<Emblem>)},
            {typeof(List<IDynamicEvents>), typeof(List<DynamicEvents>)},
            {typeof(List<IDiscoveredRecipes>), typeof(List<DiscoveredRecipes>)},
            {typeof(List<IDiscoveredItems>), typeof(List<DiscoveredItems>)},
            {typeof(List<IContinentDescriptions>), typeof(List<ContinentDescriptions>)},
            {typeof(List<IContinent>), typeof(List<Continent>)},
            {typeof(List<IColors>), typeof(List<Colors>)},
            {typeof(List<IColorDescriptions>), typeof(List<ColorDescriptions>)},
            {typeof(List<ICloth>), typeof(List<Cloth>)},
            {typeof(List<IBuild>), typeof(List<Build>)},
	#endregion
#region Single items
		    {typeof(IWorldVsWorldObjective), typeof(WorldVsWorldObjective)},
            {typeof(IWorldVsWorldMatches), typeof(WorldVsWorldMatches)},
            {typeof(IWorldVsWorldMatchDetails), typeof(WorldVsWorldMatchDetails)},
            {typeof(IWorldVsWorldMatch), typeof(WorldVsWorldMatch)},
            {typeof(IWorldVsWorldMap), typeof(WorldVsWorldMap)},
            {typeof(IWorld), typeof(World)},
            {typeof(IWeaponAttribute), typeof(WeaponAttribute)},
            {typeof(IWeapon), typeof(Weapon)},
            {typeof(ITask), typeof(Task)},
            {typeof(ISkillChallenge), typeof(SkillChallenge)},
            {typeof(ISector), typeof(Sector)},
            {typeof(IRegion), typeof(Region)},
            {typeof(IRecipeDetails), typeof(RecipeDetails)},
            {typeof(IPointsOfInterest), typeof(PointsOfInterest)},
            {typeof(IObjectiveName), typeof(ObjectiveName)},
            {typeof(IMetal), typeof(Metal)},
            {typeof(IMapRegionDetails), typeof(MapRegionDetails)},
            {typeof(IMapFloor), typeof(MapFloor)},
            {typeof(IMapDetails), typeof(MapDetails)},
            {typeof(IMapDescriptions), typeof(MapDescriptions)},
            {typeof(IMap), typeof(Map)},
            {typeof(ILocation), typeof(Location)},
            {typeof(ILeather), typeof(Leather)},
            {typeof(IItemDetails), typeof(ItemDetails)},
            {typeof(IIngredient), typeof(Ingredient)},
            {typeof(IInfixUpgrade), typeof(InfixUpgrade)},
            {typeof(IGuild), typeof(Guild)},
            {typeof(IEventName), typeof(EventName)},
            {typeof(IEventDetail), typeof(EventDetail)},
            {typeof(IEventDescriptions), typeof(EventDescriptions)},
            {typeof(IEvent), typeof(Event)},
            {typeof(IEmblem), typeof(Emblem)},
            {typeof(IDynamicEvents), typeof(DynamicEvents)},
            {typeof(IDiscoveredRecipes), typeof(DiscoveredRecipes)},
            {typeof(IDiscoveredItems), typeof(DiscoveredItems)},
            {typeof(IContinentDescriptions), typeof(ContinentDescriptions)},
            {typeof(IContinent), typeof(Continent)},
            {typeof(IColors), typeof(Colors)},
            {typeof(IColorDescriptions), typeof(ColorDescriptions)},
            {typeof(ICloth), typeof(Cloth)},
            {typeof(IBuild), typeof(Build)}, 
	#endregion
        };
        public T Deserialize<T>(System.IO.Stream input)
        {
            var jsonSerializer = JsonSerializer.CreateDefault();
            using (var streamReader = new System.IO.StreamReader(input))
            {
                using (var jsonTextReader = new JsonTextReader(streamReader))
                {
                    T instanceOfT = default(T);
                    if (_interfaceMapping.ContainsKey(typeof(T)))
                    {
                        instanceOfT = (T)jsonSerializer.Deserialize(jsonTextReader, _interfaceMapping[typeof(T)]);
                    }
                    else
                    {
                        instanceOfT = jsonSerializer.Deserialize<T>(jsonTextReader);
                    }
                    return instanceOfT;
                }
            }
        }

        public object Deserialize(System.IO.Stream input, Type targetType)
        {
            var jsonSerializer = JsonSerializer.CreateDefault();
            using (var streamReader = new System.IO.StreamReader(input))
            {
                using (var jsonTextReader = new JsonTextReader(streamReader))
                {
                    object instance = null;
                    if (_interfaceMapping.ContainsKey(targetType))
                    {
                        instance = jsonSerializer.Deserialize(jsonTextReader, _interfaceMapping[targetType]);
                    }
                    else
                    {
                        instance = jsonSerializer.Deserialize(jsonTextReader, targetType);
                    }
                    return instance;
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
