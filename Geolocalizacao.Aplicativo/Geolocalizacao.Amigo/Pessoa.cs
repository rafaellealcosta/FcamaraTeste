using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geolocalizacao.Amigo
{
    public class Pessoa
    {

        /// <summary>
        /// Código de identificação
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        public string nome { get; set; }

        /// <summary>
        /// Endereço
        /// </summary>
        public string endereco { get; set; }

        /// <summary>
        /// Latitude
        /// </summary>
        public double latitude { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        public double longitude { get; set; }        


    }
}
