namespace SpecificationPattern.Demo.Specification
{
    internal abstract class NotSpecifcation<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _specification;
        protected NotSpecifcation(
            ISpecification<T> specification)
        {
            _specification = specification;
        }

        public bool IsStatisfied(T item)
        {
            return !_specification.IsStatisfied(item);
        }
    }
}
