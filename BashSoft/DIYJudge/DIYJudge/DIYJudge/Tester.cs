namespace DIYJudge
{
   public static  class Tester
    {
        public static void CompareContent(string userOutputPath, string expectedOutputPath)
        {

        }

        private static string GetMismatchedPath(string expectedOutputPath)
        {
            int indexOf = expectedOutputPath.LastIndexOf('\\');
            string directoryPath = expectedOutputPath.Substring(0, indexOf);
            string finalPath = directoryPath + @"Mismatched.txt";
            return finalPath;
        }

       
    }
}
