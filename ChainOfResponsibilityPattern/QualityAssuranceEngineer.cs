namespace ChainOfResponsibilityPattern
{
    class QualityAssuranceEngineer : RequirementHandler
    {
        public override void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(QualityAssuranceEngineer));
           base.Handle(requirement);
        }
    }
}
