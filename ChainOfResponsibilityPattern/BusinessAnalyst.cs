namespace ChainOfResponsibilityPattern
{
    using ChainOfResponsibilityPattern.Enums;

    public class BusinessAnalyst : RequirementHandler
    {
        public override void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(BusinessAnalyst));
            if (requirement.Type == RequirementType.BusinessAnalyst)
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
