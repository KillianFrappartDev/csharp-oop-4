using System;
using System.Collections.Generic;
using Ex.Workflow;

namespace csharp_oop_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var mailSender = new MailSender();
            var videoUploader = new VideoUpload();
            var webService = new WebService();

            var workflow = new Workflow(new List<IActivity>() { mailSender, videoUploader, webService });
            var workflowEngine = new WorkflowEngine(workflow);
            workflowEngine.Run();
        }
    }
}
