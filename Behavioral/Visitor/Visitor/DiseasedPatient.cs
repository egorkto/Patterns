namespace Visitor
{
    public class DiseasedPatient : PatientBase
    {
        public DiseasedPatient(string problem) : base(problem) 
        { 

        }

        public override void AddToArchive(IPatientArchive archive)
        {
            archive.WritePatient(this);
        }
    }
}
