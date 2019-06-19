using System;

using OffSync.Apps.Codegen.Domain.ApplicationModels;

namespace OffSync.Apps.Codegen.Application.Interfaces
{
    public interface ITypeResolver
    {
        Type Resolve(
            ApplicationModel application,
            string type);
    }
}
