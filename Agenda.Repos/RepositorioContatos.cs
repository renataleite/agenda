using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.DAL;

namespace Agenda.Repos
{
    public class RepositorioContatos
    {
        private readonly IContatos _contatos;
        private readonly ITelefones _telefones;

        public RepositorioContatos(IContatos contatos, ITelefones telefones)
        {
            _contatos = contatos;
            _telefones = telefones;
        }
    }
}
