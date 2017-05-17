using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongManager.Tests
{
    [TestClass()]
    public class JugadorTests
    {
        [TestMethod()]
        public void JugadorTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Jugador player = new Jugador("1", null);
            Assert.IsNotNull(player.ToString());
        }

        [TestMethod()]
        public void ToStringTestNotNull()
        {
            Jugador player = new Jugador("Player 1");
            Assert.IsTrue(player.ToString() != null);

        }

        [TestMethod()]
        public void getPuntosTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getJugadosTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getPartidosPorDosTest()
        {
            Jugador player = new Jugador("1", null);
            player.setJugados(2);

            Assert.IsTrue(player.getJugados() > 0);
        }

        [TestMethod()]
        public void getPuntuacionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void setPuntosTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void setJugadosTest()
        {
            Assert.Fail();
        }
    }
}