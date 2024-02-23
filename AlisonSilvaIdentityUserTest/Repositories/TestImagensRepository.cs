using AlisonSilvaIdentityUser.Data;
using AlisonSilvaIdentityUser.Interfaces.Repositories;
using AlisonSilvaIdentityUser.Models;
using AlisonSilvaIdentityUser.Repositories;
using AlisonSilvaIdentityUser.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisonSilvaIdentityUserTest.Repositories
{
    [TestClass]
    public class TestImagensRepository
    {
        private ApplicationDbContext _dbContext;
        private IImagensRepository _repository;
        public TestImagensRepository()
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=AlisonSilvaPoeta;Trusted_Connection=True;";

            _dbContext = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(connectionString)
                .Options);

            _repository = new ImagensRepository(_dbContext);
        }

        [TestMethod]
        public async Task GetImagemPadrao()
        {
            Imagens imagem = await _repository.GetImagemPadrao(2);

            Assert.AreEqual(2, imagem.ProdutoId);
            Assert.AreEqual("https://drive.google.com/file/d/1JzKy-bPLaqXZem-EYoR9gmWO_GSD5aY3/view?usp=drive_link", imagem.Link);
        }
    }
}
