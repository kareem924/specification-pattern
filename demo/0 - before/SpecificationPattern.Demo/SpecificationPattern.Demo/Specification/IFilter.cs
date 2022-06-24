namespace SpecificationPattern.Demo.Specification
{
    internal interface IFilter<T>
    {
        public IEnumerable<T> Filters(IEnumerable<T> items, ISpecification<T> specification);
    }
}
