using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models.Contracts
{
   public interface ILieutenantGeneral :IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }
    }
}
