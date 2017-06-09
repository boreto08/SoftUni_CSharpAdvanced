namespace Startup
{
    public class Startup
    {
        public static void Main()
        {
            StudentsRepository.InitilizeData();
            StudentsRepository.GetStudentsScoresFromCourse("Unity", "Ivan");
        }
    }
}
