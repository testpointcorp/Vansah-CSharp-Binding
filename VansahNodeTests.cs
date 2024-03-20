using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vansah;

namespace Vansah_CSharp_Binding
{
    public class VansahNodeTests
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is from tests");
            VansahNode vs = new VansahNode();

            vs.SetVansahToken = Environment.GetEnvironmentVariable("VANSAH_TOKEN") ?? "No Value found!";
            vs.SetVansahURL = "https://vtrunkus.vansahnode.app";

            vs.JiraIssueKey = "TEST-1";


            vs.AddQuickTestFromJiraIssue("TEST-C1","passed");            


        }
    }
}
