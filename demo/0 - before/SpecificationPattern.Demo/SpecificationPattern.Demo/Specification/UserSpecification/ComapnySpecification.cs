namespace SpecificationPattern.Demo.Specification.UserSpecification
{
    internal class ComapnySpecification : ISpecification<User>
    {
        private readonly string _companyName;

        public ComapnySpecification(string name)
        {
            _companyName = name;
        }

        public bool IsStatisfied(User user)
        {
            return user.Email.Split('@')[1].StartsWith(_companyName);
        }
    }
}
