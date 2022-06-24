namespace SpecificationPattern.Demo.Specification
{
    internal abstract class OrSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _firstSpecification;
        private readonly ISpecification<T> _secondSpecification;

        protected OrSpecification(
            ISpecification<T> secondSpecification,
            ISpecification<T> firstSpecification)
        {
            _secondSpecification = secondSpecification;
            _firstSpecification = firstSpecification;
        }

        public bool IsStatisfied(T item)
        {
            return _firstSpecification.IsStatisfied(item) || _secondSpecification.IsStatisfied(item);
        }
    }
}
