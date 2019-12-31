namespace ChainOfResponsibilityPattern
{
    using System;
    using ChainOfResponsibilityPattern.Enums;

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
            Requirement requirement = new Requirement()
            {
                // represents the person who can finish/close the requirement 
                Type = RequirementType.DevOpsEngineer
            };
            Requirement requirement2 = new Requirement()
            {
                Type = RequirementType.SoftwareEngineer
            };

            // our Business Analyst retrieves two requirements from our client
            boddy.Handle(requirement);
            boddy.Handle(requirement2);

            // first requirement is finished/closed by our DevOpsEngineer
            foreach (var operation in requirement.OperationsDone)
            {
                Console.WriteLine(operation);
            }
            Console.WriteLine("================================================");
            // second requirement is finished/closed by our SoftwareEngineer
            foreach (var operation in requirement2.OperationsDone)
            {
                Console.WriteLine(operation);
            }
        }
    }
}
