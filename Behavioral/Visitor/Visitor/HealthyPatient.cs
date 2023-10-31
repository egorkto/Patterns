namespace Visitor
{
    public class HealthyPatient : PatientBase
    {
        public HealthyPatient(string problem) : base(problem) 
        {

        }

        public override void AddToArchive(IPatientArchive archive)
        {
            archive.WritePatient(this);
        }
    }
}
