namespace ChainOfResponsibilityPattern
{
    using ChainOfResponsibilityPattern.Enums;

    public class SoftwareArchitect : RequirementHandler
    {
        public override void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(SoftwareArchitect));
            if (requirement.Type == RequirementType.SoftwareArchitect)
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
