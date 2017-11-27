using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geolocalizacao.Amigo
{
    /// <summary>
    /// Interface para operações referente à classe amigo
    /// </summary>
    public interface IAmigo
    {
         Dictionary<Pessoa, Dictionary<Pessoa, double>> CalcularDistancia(List<Pessoa> amigos);
    }
}
