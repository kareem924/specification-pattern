namespace SpecificationPattern.Demo.Specification.UserSpecification
{
    internal class ColorSpecification : ISpecification<User>
    {
        private readonly EyeColor _color;

        public ColorSpecification(EyeColor color)
        {
            _color = color;
        }

        public bool IsStatisfied(User user)
        {
            return user.EyeColor == _color;
        }
    }
}
