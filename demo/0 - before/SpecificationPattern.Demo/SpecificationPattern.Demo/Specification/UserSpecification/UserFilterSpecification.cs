namespace SpecificationPattern.Demo.Specification.UserSpecification
{
    internal class UserFilterSpecification : IFilter<User>
    {
        public IEnumerable<User> Filters(IEnumerable<User> items, ISpecification<User> specification)
        {
            if (items is not null)
            {
                foreach (User? item in items)
                {
                    if (specification.IsStatisfied(item))
                    {
                        yield return item;
                    }
                }
            }
        }
    }
}
