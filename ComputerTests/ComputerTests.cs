using NUnit.Framework;
using Homework2;
using System.Collections.Generic;
using Homework2.Motherboard;
using Homework2.Procesor;
using Homework2.VideoCard;
using Homework2.RAM;

namespace Homework2Tests
{
    public class ComputerTests
    {
        [Test]
        public void AvailabilityComputerComponents_InititalizedComputerComponents_FourOrMoreComponents()
        {
            //Arrange
            List<IGetInfo> components = new List<IGetInfo>()
            {
                new Esonic("Esonic G41CPL3", 2 , 8 ),
                new AMD("AMD Ryzen 3 1200", 4, 3.1 ),
                new ASUS("ASUS GeForce GT 710 Silent LP", 1, 21),
                new NeoForza("Neo Forza ENCKE", 8, 1)
            };
            //Act&Assert
            if ( components.Count < 4 )
            {
                Assert.Fail();
            }
        }
        [Test]
        public void RepeatMotherboards_InititalizedMotherboards_NoTwoOrMoreMotherboards()
        {
            //Arrange
            List<IGetInfo> components = new List<IGetInfo>()
            {
                new Esonic("Esonic G41CPL3", 2 , 8 ),
                new AMD("AMD Ryzen 3 1200", 4, 3.1 ),
                new ASUS("ASUS GeForce GT 710 Silent LP", 1, 21),
                new NeoForza("Neo Forza ENCKE", 8, 1)             
            };
            int count = 0;
            //Act&Assert
            foreach ( var component in components )
            {
                if (  component is MotherBoard )
                {
                    count++;
                }
                if ( count >= 2 )
                {
                    Assert.Fail();
                }             
            }
        }
        [Test]
        public void RepeatRAMs_InititalizedRAMs_NoTwoOrMoreRAMs()
        {
            //Arrange
            List<IGetInfo> components = new List<IGetInfo>()
            {
                new Esonic("Esonic G41CPL3", 2 , 8 ),
                new AMD("AMD Ryzen 3 1200", 4, 3.1 ),
                new ASUS("ASUS GeForce GT 710 Silent LP", 1, 21),
                new NeoForza("Neo Forza ENCKE", 8, 1)              
            };
            int count = 0;
            //Act&Assert
            foreach ( var component in components )
            {
                if ( component is RAM )
                {
                    count++;
                }
                if ( count >= 2 )
                {
                    Assert.Fail();
                }
            }
        }
        [Test]
        public void RepeatProcesors_InititalizedProcesors_NoTwoOrMoreProcesors()
        {
            //Arrange
            List<IGetInfo> components = new List<IGetInfo>()
            {
                new Esonic("Esonic G41CPL3", 2 , 8 ),
                new AMD("AMD Ryzen 3 1200", 4, 3.1 ),
                new ASUS("ASUS GeForce GT 710 Silent LP", 1, 21),
                new NeoForza("Neo Forza ENCKE", 8, 1)
            };
            int count = 0;
            //Act&Assert
            foreach ( var component in components )
{
                if ( component is Procesor )
                {
                    count++;
                }
                if ( count >= 2 )
                {
                    Assert.Fail();
                }
            }
        }
        [Test]
        //Arrange
        public void RepeatVideocards_InititalizedVideocards_NoTwoOrMoreVideocards()
        {

            List<IGetInfo> components = new List<IGetInfo>()
            {
                new Esonic("Esonic G41CPL3", 2 , 8 ),
                new AMD("AMD Ryzen 3 1200", 4, 3.1 ),
                new ASUS("ASUS GeForce GT 710 Silent LP", 1, 21),
                new NeoForza("Neo Forza ENCKE", 8, 1)
            };
            int count = 0;
            //Act&Assert
            foreach ( var component in components )
            {
                if ( component is VideoCard )
                {
                    count++;
                }
                if ( count >= 2 )
                {
                    Assert.Fail();
                }
            }
        }
    }
}