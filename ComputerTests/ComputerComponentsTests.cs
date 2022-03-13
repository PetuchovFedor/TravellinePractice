using NUnit.Framework;
using Homework2.Motherboard;
using Homework2.Procesor;
using Homework2.VideoCard;
using Homework2.RAM;
using System.Collections.Generic;

namespace Homework2Tests
{
    public class ComputerComponentsTests
    {
        [Test]
        public void NumberAMDCores_InititalizedAMD_TwoOrMoreCores()
        {
            //Arrange          
            AMD amd = new ( "AMD Ryzen 3 1200", 4, 3.1 );
            //Act&Assert
            Assert.GreaterOrEqual( amd.CoresCount, 2 );
            
        }
        public void NumberIntelCores_InititalizedIntel_TwoOrMoreCores()
        {
            //Arrange          
            Intel intel = new ( "Intel Core i3 9100F", 4, 3.6 );
            //Act&Assert
            Assert.GreaterOrEqual( intel.CoresCount, 2 );
        }
        [Test]
        public void EsonicMemorySlots_InititalizedEsonic_TwoOrMoreSlots()
        {
            //Arrange
            Esonic esonic = new( "Esonic G41CPL3", 2, 8 );
            //Act&Assert
            Assert.GreaterOrEqual( esonic.MemorySlotsCount, 2 );            
        }
        [Test]
        public void ASRockMemorySlots_InititalizedASRock_TwoOrMoreSlots()
        {
            //Arrange
            ASRock asrock = new( "ASRock H310CM-DVS", 2, 32 );
            //Act&Assert
            Assert.GreaterOrEqual( asrock.MemorySlotsCount, 2 );
        }
        [Test]
        public void MSIMaximumMemoryBandwidth_InititalizedMSI_FiveOrMore()
        {
            //Arrange
            MSI msi = new( "MSI GeForce 210", 1, 6.4 );
            //Act&Assert           
            Assert.GreaterOrEqual( msi.MaximumMemoryBandwidth, 5 );           
        }
        [Test]
        public void ASUSMaximumMemoryBandwidth_InititalizedASUS_FiveOrMore()
        {
            //Arrange
            ASUS asus = new( "ASUS GeForce GT 710 Silent LP", 1, 21 );
            //Act&Assert           
            Assert.GreaterOrEqual( asus.MaximumMemoryBandwidth, 5 );
        }
        [Test]
        public void NeoForzaMemoryModuleCapaCapacity_InititalizedNeoForza_More512MgByte()
        {
            //Arrange
            const double Min = 1 / 1024 * 512;
            NeoForza neoForza = new( "Neo Forza ENCKE", 8, 1 );
            //Act&Assert
            Assert.GreaterOrEqual(neoForza.MemoryModuleCapacity*1024, Min );
        }
        [Test]
        public void KingstonMemoryModuleCapaCapacity_InititalizedKingston_More512MgByte()
        {
            //Arrange
            const double Min = 1 / 1024 * 512;
            Kingston kingston = new("Kingston HyperX FURY Black", 5, 1);
            //Act&Assert
            Assert.GreaterOrEqual( kingston.MemoryModuleCapacity * 1024, Min );
        }
    }
}
