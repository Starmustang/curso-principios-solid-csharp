using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation
{
    public class Developer : IDevelopActivities, IWorkingActivities
    {
        public Developer()
        {
        }

        public void Plan()
        {
            throw new ArgumentException();
        }

        public void Comunicate()
        {
            throw new ArgumentException();
        }
        public void Develop()
        {
            Console.WriteLine("I'm developing the functionalities required");
        }
    }
}