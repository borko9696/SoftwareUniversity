namespace UniversityLearningSystem.Contracts
{
    using System.Collections.Generic;

    public interface IRoute
    {
        string ActionName { get; }

        string ControllerName { get; }

        IDictionary<string, string> Parameters { get; }
    }
}