namespace ChainOfResponsibilityPattern
{
    using System;
    using ChainOfResponsibilityPattern.Enums;

    public class Program
    {
        public static void Main()
        {
            // Build up the team (chain).
            BusinessAnalyst businessAnalyst = new BusinessAnalyst();
            SoftwareArchitect softwareArchitect = new SoftwareArchitect();
            SoftwareEngineer softwareEngineer = new SoftwareEngineer();
            QualityAssuranceEngineer qualityAssuranceEngineer = new QualityAssuranceEngineer();
            DevOpsEngineer devOpsEngineer = new DevOpsEngineer();

            // introduce the team and the cycle of developing (building the chain)
            businessAnalyst.SetNext(softwareArchitect);
            softwareArchitect.SetNext(softwareEngineer);
            softwareEngineer.SetNext(qualityAssuranceEngineer);
            qualityAssuranceEngineer.SetNext(devOpsEngineer);

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
            businessAnalyst.Handle(requirement);
            businessAnalyst.Handle(requirement2);

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
