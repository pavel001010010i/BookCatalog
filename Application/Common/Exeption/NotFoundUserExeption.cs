using System;
namespace Application.Common.Exeption
{
    public class NotFoundUserException : Exception
    {
        public NotFoundUserException(string name, object code)
            : base($"Entity \"{name}\" not found. Status code: \"{code}\"") { }
    }

}
