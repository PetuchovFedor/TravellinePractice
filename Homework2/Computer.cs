namespace Homework2
{
    public class Computer
    {
        public void WriteComponentInfo()
        {
            try
            {
                Console.WriteLine("Computer component information:");
                List<IGetComponentInfo> components = new List<IGetComponentInfo>()
                {
                    new Esonic(),
                    new AMD(),
                    new ASUS(),
                    new NeoForza()
                };
                foreach (IComponentCheck component in components)
                {
                    component.ComponentCkeck();                  
                }
                foreach (var component in components)
                {
                    component.GetComponentInfo();
                    Console.WriteLine();
                }               
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
