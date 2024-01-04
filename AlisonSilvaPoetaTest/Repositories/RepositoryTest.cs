using AlisonSilvaPoeta;
using AlisonSilvaPoeta.Interfaces.Repositories;
using AlisonSilvaPoeta.Models;
using AlisonSilvaPoeta.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisonSilvaPoetaTest.Repositories
{
    [TestClass]
    public class RepositoryTest
    {
        public LivrariaContext context;
        public IUsuarioRepository repository;
        public RepositoryTest() 
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=AlisonSilvaPoeta;Trusted_Connection=True;";

            context = new LivrariaContext(new DbContextOptionsBuilder<LivrariaContext>()
                .UseSqlServer(connectionString)
                .Options);

            repository = new UsuarioRepository(context);
        }
        [TestMethod]
        public async Task Adicionar()
        {
            Usuario usuario = new Usuario(0, "Gustavo", "gsoey2019123@gmail.com", "1010", "+55 (11) 98174-6450",
                "Administrador", "17.809.774-3", "503.094.170-31");
            Usuario usuario1 = new Usuario(0, "Alison", "alisonsilvapoeta@gmail.com", "2020", 
                "+55 (11) 98174-6450", "Administrador", "43.118.736-8", "612.671.660-45");

            await repository.Add(usuario);
            await repository.Add(usuario1);

            Usuario resultado = await repository.Find(1);

            Assert.AreEqual(usuario.EMail, resultado.EMail);
            Assert.AreEqual(usuario.Senha, resultado.Senha);
        }

        [TestMethod]
        public async Task ConsultarTodos()
        {
            List<Usuario> lista = await repository.All();

            Assert.AreEqual(lista.Count, 2);
        }

        [TestMethod]
        public async Task ConsultarPorId()
        {
            Usuario usuario = await repository.Find(1);

            Assert.AreEqual(usuario.EMail, "gsoey2019123@gmail.com");
            Assert.AreEqual(usuario.Senha, "1010");
        }

        [TestMethod]
        public async Task ModificarDados()
        {
            Usuario usuario = new Usuario(1, "Marcello Muller", "marcellomuller39@gmail.com", "1010", 
                "+55 (11) 98174-6450", "Administrador", "17.809.774-3", "503.094.170-31");

            await repository.Update(usuario);

            Usuario resultado = await repository.Find(1);

            Assert.AreEqual(resultado.Nome, usuario.Nome);
            Assert.AreEqual(resultado.EMail, usuario.EMail);
        }

        [TestMethod]
        public async Task RemoverDados()
        {
            await repository.Delete(2);

            Usuario resultado = await repository.Find(2);

            Assert.IsNull(resultado);
        }
    }
}
