namespace SpecificationPattern.Demo.Specification
{
    internal interface ISpecification<T>
    {
        bool IsStatisfied(T item);
    }
}
