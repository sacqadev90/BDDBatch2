using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers.UnitTest
{
    class RoverTest
    {
        [Test]
        public void RoverShouldBeAtPosition()
        {
            Rover rover = new Rover();
            rover.SetPosition(new Point(2, 3));
            Assert.AreEqual(new Point(2, 3), rover.GetPosition());
        }
        [Test]
        public void RoverShouldBeAtDirection()
        {
            Rover rover = new Rover();
            rover.SetDirection("E");
            Assert.AreEqual("E", rover.GetDirection());
        }
        
        [Test]
        public void RoverShouldMoveForwardFromNorth()
        {
            Rover rover = new Rover();
            rover.SetDirection("N");
            rover.SetPosition(new Point(3, 6));
            rover.Move();
            Assert.AreEqual("N", rover.GetDirection());
            Assert.AreEqual(new Point(3, 7), rover.GetPosition());
        }

        [Test]

        public void RoverShouldMoveForwardFromSouth()
        {
            Rover rover = new Rover();
            rover.SetDirection("S");
            rover.SetPosition(new Point(3, 6));
            rover.Move();
            Assert.AreEqual("S", rover.GetDirection());
            Assert.AreEqual(new Point(3, 5), rover.GetPosition());
        }

        [Test]
        public void RoverShouldMoveForwardFromEast()
        {
            Rover rover = new Rover();
            rover.SetDirection("E");
            rover.SetPosition(new Point(3, 6));
            rover.Move();
            Assert.AreEqual("E", rover.GetDirection());
            Assert.AreEqual(new Point(4, 6), rover.GetPosition());
        }

        [Test]
        public void RoverShouldMoveForwardFromWest()
        {
            Rover rover = new Rover();
            rover.SetDirection("W");
            rover.SetPosition(new Point(3, 6));
            rover.Move();
            Assert.AreEqual("W", rover.GetDirection());
            Assert.AreEqual(new Point(2, 6), rover.GetPosition());
        }

        [TestCase("E", "N")]
        [TestCase("N", "W")]
        [TestCase("W", "S")]
        [TestCase("S", "E")]
        public void RoverShouldTurnLeft(String intialDirection, String newDirection)
        {
            Rover rover = new Rover();
            rover.SetDirection(intialDirection);
            rover.Turn("L");
            Assert.AreEqual(newDirection, rover.GetDirection());

        }

        [TestCase("E", "S")]
        [TestCase("N", "E")]
        [TestCase("W", "N")]
        [TestCase("S", "W")]
        public void RoverShouldTurnRight(String intialDirection, String newDirection)
        {
            Rover rover = new Rover();
            rover.SetDirection(intialDirection);
            rover.Turn("R");
            Assert.AreEqual(newDirection, rover.GetDirection());
        }
    }
}
