using Homework2.Motherboard;
using Homework2.Procesor;
using Homework2.RAM;
using Homework2.VideoCard;
//Motherboards:Esonic("Esonic G41CPL3", 2 , 8 ), ASRock("ASRock H310CM-DVS", 2, 32)
//Processor:AMD("AMD Ryzen 3 1200", 4, 3.1), Intel("Intel Core i3 9100F", 4, 3.6)
//RAM:Kingston("Kingston HyperX FURY Black", 5, 1), NeoForza("Neo Forza ENCKE", 8, 1")
//VideoCard:ASUS("ASUS GeForce GT 710 Silent LP", 1, 21), MSI("MSI GeForce 210", 1, 6.4)
namespace Homework2
{
    public class Computer : IGetInfo
    {
        List<IGetInfo> components = new List<IGetInfo>()
        {   
            new Esonic("Esonic G41CPL3", 2 , 8 ),
            new AMD("AMD Ryzen 3 1200", 4, 3.1),
            new ASUS("ASUS GeForce GT 710 Silent LP", 1, 21),
            new NeoForza("Neo Forza ENCKE", 8, 1)
         };
        public string GetComponentInfo()
        {
            foreach ( IGetInfo component in components)
            {
                Console.WriteLine( component.GetComponentInfo());
            }
            return "Not all data is entered";
        }
    }
}
