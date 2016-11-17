using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denuncias.Model
{
    public class Denuncia
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Texto { get; set; }

        public string Endereco { get; set; }
    }
}
