namespace OOP_6.Exceptions
{
    public sealed class NotFoundException : Exception
    {
        public NotFoundException(string name) : base($"Entity not found. Name: {name}") { }
    }
}
