using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Vansah;

namespace Vansah_CSharp_Binding
{
    public class VansahNodeTests
    {
        static void Main(string[] args)
        {
            string caseKey = "TEST-C1";
            Console.WriteLine("This is from tests");

            VansahNode vs = new VansahNode();

            vs.SetVansahToken = Environment.GetEnvironmentVariable("VANSAH_TOKEN") ?? "No Value found!";
            //vs.SetVansahURL = "https://vtrunkus.vansahnode.app";

            vs.JiraIssueKey = "TEST-1";
         

            //vs.AddQuickTestFromJiraIssue("TEST-C1","passed");
            //
            vs.AddTestRunFromJiraIssue(caseKey);
            vs.AddTestLog("passed", "This is First Step #1", 1, ScreenshotFunc());
            vs.UpdateTestLog("failed", "This is updated #1");


        }

        public static string ScreenshotFunc()
        {
            //This is just a sample code to return screenshot file
            //You need to write your own screenshot function to return the screenshot file;

            string screenshotFile = "C:\\Users\\onesh\\OneDrive\\Documents\\GitHub\\Vansah-CSharp-Binding\\img\\screenshot.png"; //This is a sample path

            if (!File.Exists(screenshotFile)) {
                File.Create(screenshotFile).Close();
                return screenshotFile;
            }
            else return screenshotFile;
 
        }
    }
}
