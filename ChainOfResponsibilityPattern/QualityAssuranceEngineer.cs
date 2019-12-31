namespace ChainOfResponsibilityPattern
{
    using ChainOfResponsibilityPattern.Enums;

    public class QualityAssuranceEngineer : RequirementHandler
    {
        public override void Handle(Requirement requirement)
        {
            requirement.OperationsDone.Add(nameof(QualityAssuranceEngineer));
            if (requirement.Type == RequirementType.QualityAssuranceEngineer)
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
