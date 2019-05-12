using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Serveur
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        List<City> GetCities();

        [OperationContract]
        Station GetNeerestStation(String city, Position pos, bool start);

        [OperationContract]
        Station GetStation(String city, int id);

        [OperationContract]
        List<Station> GetStations(String city);
    }

}
