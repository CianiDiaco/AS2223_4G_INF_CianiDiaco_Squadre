using Library;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddPlayers()
        {
            // TODO U.1
        }

        [Test]
        public void AddCaptain()
        {
            Team team = new Team("Squadra 1");
            Assert.That(team.AddCaptain(new Player("Cognome 1", "Nome 1", Player.ERole.Rosa)), IS.True);
            Assert.That(team.AddCaptain(new Player("Cognome 1", "Nome 1", Player.ERole.Riserva)), Is.False);
        }
    }
}