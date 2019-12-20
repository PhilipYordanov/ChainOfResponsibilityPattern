namespace ChainOfResponsibilityPattern
{
    public class SoftwareArchitect : RequirementHandler
    {

        public override void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(SoftwareArchitect));
            base.Handle(requirement);
        }
    }
}
