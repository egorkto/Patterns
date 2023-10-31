namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "Archive.txt";

            var writer = new PatientWriter(fileName);
            var archive = new MedicalArchive(writer);
            var healthyPatient = new HealthyPatient("Headache");
            var diseasedPatient = new DiseasedPatient("Cold");

            healthyPatient.AddToArchive(archive);
            diseasedPatient.AddToArchive(archive);
        }
    }
}
