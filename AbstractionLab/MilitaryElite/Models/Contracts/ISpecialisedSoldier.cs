using MilitaryElite.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models.Contracts
{
   public interface ISpecialisedSoldier :IPrivate
    {
        Corps Corps { get; }
    }
}
