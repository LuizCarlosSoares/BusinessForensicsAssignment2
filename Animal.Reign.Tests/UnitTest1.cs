using Animal.Reign.Application;
using Animal.Reign.Domain;
using Animal.Reign.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Animal.Reign.Tests
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestSharkCommonFeedBehaviour()
        {            
            Shark shark = new Shark() { Name = "The great White Shark", IsDangerous=true};            
            Tarantula tarantula = new Tarantula() {Name = "Rose hair tarantula" };     
            
            var actual = shark.Feed();
            Assert.IsNotNull(actual);
        }

         [TestMethod]
        public void TestTarantulaSpecificFeedBehaviour()
        {        
            var expected= "specific way that a tarantula feed";
            Tarantula tarantula = new Tarantula() {Name = "Rose hair tarantula" };           
            var actual = tarantula.Feed();

            Assert.AreEqual(actual,expected);
        }

        [TestMethod]
        public void TestGetDangerousAnimals()
        {
            var expected = 1;
            var repository = new Repository<AnimalInfo>();
            Shark shark = new Shark() { Name = "The great White Shark", IsDangerous=true};            
            Tarantula tarantula = new Tarantula() {Name = "Rose hair tarantula" };

            var tarantulaInfo = new AnimalInfo(tarantula);
            tarantulaInfo.Image = "Some base64 tarantula image";
            var sharkInfo = new AnimalInfo(shark);
            sharkInfo.Image = "Some base64 of great white shark image";

            repository.Insert(sharkInfo);
            repository.Insert(tarantulaInfo);

            var actual = repository.GetDangerous().Count;

            Assert.AreEqual(expected,actual);

        }
    }
}
