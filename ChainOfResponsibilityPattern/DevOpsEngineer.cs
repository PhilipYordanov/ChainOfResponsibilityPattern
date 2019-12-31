namespace ChainOfResponsibilityPattern
{
    using ChainOfResponsibilityPattern.Enums;

    public class DevOpsEngineer : RequirementHandler
    {
        public override void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(DevOpsEngineer));
            if (requirement.Type == RequirementType.DevOpsEngineer)
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
