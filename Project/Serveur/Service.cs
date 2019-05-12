using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Serveur
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Service : IService
    {
        private Cache<List<City>> cities;
        private Cache<List<Station>> stationByCity;

        private const String BASE_URL = "https://api.jcdecaux.com/vls/v1/";
        private const String CONTRACTS = "contracts/";
        private const String STATIONS = "stations/";
        private const String API_KEY = "apiKey=0b671de844c71548f714dea830547975a19ea09f";

        public Service()
        {
            cities = new Cache<List<City>>(0, new RequesterCity(BASE_URL + CONTRACTS, API_KEY));
            stationByCity = new Cache<List<Station>>(1, new RequesterStations(BASE_URL + STATIONS, API_KEY));
        }

        public List<City> GetCities()
        {
            return cities.GetResource("");
        }

        public Task<List<City>> GetCitiesAsync()
        {
            return Task<List<City>>.Run(() =>
            {
                return GetCities();
            });
        }

        public Station GetNeerestStation(string city, Position pos)
        {
            return null;
        }

        public Station GetStation(String city ,int id)
        {
            List<Station> stations = stationByCity.GetResource(city);
            try
            {
                return stations.Where(s => id == s.number).First();
            } catch (Exception e)
            {
                return null;
            }
        }

        public Task<Station> GetStationAsync(String city, int id)
        {
            return Task<Station>.Run(() =>
            {
                return GetStation(city, id);
            });
        }

        public List<Station> GetStations(string city)
        {
            return stationByCity.GetResource(city);
        }

        public Task<List<Station>> GetStationsAsync(string city)
        {
            return Task<List<Station>>.Run(() => {
                return GetStations(city);
            });
        }

        public Task<Station> GetNeerestStationAsync(string city, Position pos)
        {
            throw new NotImplementedException();
        }
    }
}
