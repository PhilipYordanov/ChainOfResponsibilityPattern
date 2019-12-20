namespace ChainOfResponsibilityPattern
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // Build up the team (chain).
            BusinessAnalyst boddy = new BusinessAnalyst();
            SoftwareArchitect hristo = new SoftwareArchitect();
            SoftwareEngineer filip = new SoftwareEngineer();
            QualityAssuranceEngineer todor = new QualityAssuranceEngineer();
            DevOpsEngineer deivid = new DevOpsEngineer();

            // introduce the team and the cycle of developing (building the chain)
            boddy.SetNext(hristo);
            hristo.SetNext(filip);
            filip.SetNext(todor);
            todor.SetNext(deivid);

            // client gives the requirement to business analyst.
            Requirement requirement = new Requirement();
            boddy.Handle(requirement);

            // test what happens through the chain.
            foreach (var operation in requirement.OperationsDone)
            {
                Console.WriteLine(operation);
            }
        }
    }
}
