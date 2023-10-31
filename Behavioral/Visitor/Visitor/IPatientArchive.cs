namespace Visitor
{
    public interface IPatientArchive
    {
        public void WritePatient(HealthyPatient patient);
        public void WritePatient(DiseasedPatient patient);
    }
}
