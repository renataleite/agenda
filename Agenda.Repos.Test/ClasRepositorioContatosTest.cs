using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.DAL;
using Agenda.Repos;
using Agenda.Domain;
using NUnit.Framework;
using Moq;

namespace Agenda.Repos.Test
{
    [TestFixture]
    public class ClasRepositorioContatosTest
    {
        Mock<IContatos> _contatos;
        Mock<ITelefones> _telefones;
        RepositorioContatos _repositorioContatos;

        [SetUp]
        public void Setup()
        {
            _contatos = new Mock<IContatos>();
            _telefones = new Mock<ITelefones>();
            _repositorioContatos = new RepositorioContatos(_contatos.Object, _telefones.Object);
        }

        [Test]
        public void DeveSerPossivelObterContatoComListaTelefone()
        {
            //Monta
                //Criar Moq de IContato
                //Moq da função ObterPorId de IContatos
                //Criar Moq de Itelefone
                //Moq da funcao ObterTodosDoContato de Itelefones
            //Excuta
                //chama o metodo ObterPorId de RepositorioContatos
            //Verifica
                //Verificar se o Conato retornado contém os mesmos dados do Moq Icontato com a lista de Telefones do Moq Itelefone

        }

        [TearDown]
        public void TearDown()
        {

        }

    }
}
