namespace Homework2
{
    public class Computer: IGetAndCheckComponentInfo
    {
         List<IGetAndCheckComponentInfo> components = new List<IGetAndCheckComponentInfo>()
         {
            new Esonic(),
            new AMD(),
            new ASUS(),
            new NeoForza()
         };
        public void GetComponentInfo()
        {            
            foreach (IGetAndCheckComponentInfo component in components)
            {
                component.GetComponentInfo();
            }
        }
        public void ComponentCkeck()
        {          
            foreach (IGetAndCheckComponentInfo component in components)
            {
                component.ComponentCkeck();                
            }
        }
    }
}
