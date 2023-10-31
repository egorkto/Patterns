namespace Visitor
{
    class MedicalArchive : IPatientArchive
    {
        private PatientWriter writer;

        public MedicalArchive(PatientWriter _writer)
        {
            writer = _writer;
        }

        public void WritePatient(HealthyPatient patient)
        {
            writer.Write("Complaint: " + patient.Problem);
        }

        public void WritePatient(DiseasedPatient patient)
        {
            writer.Write("Diagnosis: " + patient.Problem);
        }
    }
}
