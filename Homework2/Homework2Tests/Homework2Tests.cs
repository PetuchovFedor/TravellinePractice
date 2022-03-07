using NUnit.Framework;
using Homework2;
using System.Collections.Generic;

namespace Homework2Tests
{
    public class ComputerTests
    {
        [Test]
        public void AvailabilityComputerComponents_InititalizedComputerComponents_FourOrMoreComponents()
        {
            //Arrange
            List<IGetAndCheckComponentInfo> components = new List<IGetAndCheckComponentInfo>()
            {
                new Esonic(),
                new AMD(),
                new ASUS(),
                new NeoForza()
            };
            //Act&Assert
            if (components.Count < 4)
            {
                Assert.Fail();
            }
        }
        [Test]
        public void NumberProcessorCores_InititalizedProcessors_TwoOrMoreCores()
        {
            //Arrange
            List<Procesor> procesors = new()
            {
                new AMD(),
                new Intel()
            };
            //Act$Assert
            foreach (var procesor in procesors)
            {
                Assert.GreaterOrEqual(procesor.numberCores, 2);
            }
        }          
        [Test]
        public void MotherboadMemorySlots_InititalizedMotherboards_TwoOrMoreSlots()
        {
            //Arrange
            List<MotherBoard> motherboards = new()
            {
                new Esonic(),
                new ASRock()
            };
            //Act&Assert
            foreach (var motherboard in motherboards)
            {
                Assert.GreaterOrEqual(motherboard.numberMemorySlots, 2);
            }
        }
        [Test]
        public void VideoCardMaximumMemoryBandwidth_InititalizedVideoCards_TenOrMore()
        {
            //Arrange
            List<VideoCard> videocards = new()
            {
                new MSI(),
                new ASUS()
            };
            //Act&Assert
            foreach (var videocard in videocards)
            {
                Assert.GreaterOrEqual(videocard.maximumMemoryBandwidth, 5);
            }
        }
        [Test]
        public void RAMMemoryModuleCapaCapacity_InititalizedRAMs_More512MgByte()
        {
            //Arrange
            const double MegaByte = 1 / 1024 * 512;
            List<RAM> rams = new()
            {
                new NeoForza(),
                new Kingston()
            };
            //Act&Assert
            foreach (var ram in rams)
            {
                Assert.GreaterOrEqual(ram.memoryModuleCapacity, MegaByte);
            }
        }
    }
}