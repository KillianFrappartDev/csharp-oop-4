using System;

namespace Ex.Workflow
{
    public class WorkflowEngine
    {
        private readonly Workflow _workflow;
        public WorkflowEngine(Workflow workflow) => _workflow = workflow;
        public void Run() => _workflow.Start();
    }
}