using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models.Contracts
{
    public interface IEngineer : ISpecialisedSoldier
    { 
        IReadOnlyCollection<IRepair> Repairs { get; }
    }
}
