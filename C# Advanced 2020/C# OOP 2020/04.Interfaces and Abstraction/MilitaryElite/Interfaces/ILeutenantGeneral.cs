using System.Collections.Generic;

namespace MilitaryElite.Interfaces
{
    public interface ILeutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }

    }
}
