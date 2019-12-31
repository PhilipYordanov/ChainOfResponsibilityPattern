namespace ChainOfResponsibilityPattern
{
    using ChainOfResponsibilityPattern.Enums;

    public class SoftwareEngineer : RequirementHandler
    {
        public override void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(SoftwareEngineer));
            if (requirement.Type == RequirementType.SoftwareEngineer)
            {
                var operations = requirement.OperationsDone;
                operations[operations.Count - 1] = $"{operations[operations.Count - 1]} close the requirement";
            }
            else
            {
                base.Handle(requirement);
            }
        }
    }
}
