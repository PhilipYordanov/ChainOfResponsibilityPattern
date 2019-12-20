namespace ChainOfResponsibilityPattern
{
    public class SoftwareEngineer : RequirementHandler
    {
        public override void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(SoftwareEngineer));
            base.Handle(requirement);
        }
    }
}
