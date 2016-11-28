using System;

namespace ExemploInjDependencia
{
    public interface ITesteA
    {
        Guid IdReferencia { get; }
    }

    public interface ITesteB
    {
        Guid IdReferencia { get; }
    }
}