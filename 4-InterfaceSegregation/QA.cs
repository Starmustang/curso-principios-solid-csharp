using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation
{
    public class QA : IWorkingActivities, IQAActivities
    {
        public void Analyze()
        {
            throw new NotImplementedException();
        }

        public void Comunicate()
        {
            throw new NotImplementedException();
        }

        public void Plan()
        {
            throw new NotImplementedException();
        }
    }
}