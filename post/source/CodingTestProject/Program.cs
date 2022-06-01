using CodingTestProject.DataStructure;

namespace CodingTestProject
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IExecute excute = new GoodNumber();
            excute.Execute();
        }
    }
}
