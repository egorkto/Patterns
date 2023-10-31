namespace Visitor
{
    public abstract class PatientBase
    {
        public readonly string Problem;

        public PatientBase(string problem)
        {
            Problem = problem;
        }

        public abstract void AddToArchive(IPatientArchive archive);
    }
}
