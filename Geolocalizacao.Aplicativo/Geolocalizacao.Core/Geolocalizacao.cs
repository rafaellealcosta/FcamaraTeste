using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geolocalizacao.Amigo;

namespace Geolocalizacao.Core
{
    public class Geolocalizacao : IAmigo
    {
        /// <summary>
        /// Efetua o cálculo de distância entre os amigos
        /// </summary>
        /// <param name="amigos"></param>
        /// <returns>Dicionário de amigos com a distância calculada dos demais</returns>
        public Dictionary<Pessoa, Dictionary<Pessoa, double>> CalcularDistancia(List<Pessoa> amigos)
        {

            var retorno = new Dictionary<Pessoa, Dictionary<Pessoa, double>>();            

            amigos.ForEach(item =>
            {
                var sCoord = new GeoCoordinate(item.latitude, item.longitude);           

                retorno.Add(item, amigos.Where(y => y.id != item.id)
                                .ToDictionary(y => y, y => sCoord.GetDistanceTo(new GeoCoordinate(y.latitude, y.longitude))));
                
            });                     

            return retorno;
        }
    }
}
