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
        public void Test()
        {


        }

        [TearDown]
        public void TearDown()
        {

        }

    }
}
