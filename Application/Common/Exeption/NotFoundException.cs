using System;
namespace Application.Common.Exeption
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string name, object id)
            : base($"Entity \"{name}\" ({id}) not found.") { }

    }
}
