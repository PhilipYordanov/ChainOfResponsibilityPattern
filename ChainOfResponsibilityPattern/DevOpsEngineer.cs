namespace ChainOfResponsibilityPattern
{
    public class DevOpsEngineer : RequirementHandler
    {
        public override void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(DevOpsEngineer));
        }
    }
}
