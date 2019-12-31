namespace ChainOfResponsibilityPattern
{
    using System.Collections.Generic;
    using ChainOfResponsibilityPattern.Enums;

    public class Requirement
    {
        public List<string> OperationsDone { get; set; } = new List<string>();

        public RequirementType Type { get; set; }
    }
}
