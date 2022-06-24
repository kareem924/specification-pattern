namespace SpecificationPattern.Demo
{
    internal class User
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public EyeColor EyeColor { get; set; }

        public int Age { get; set; }

        public DateTime Registered { get; set; }

        public string[] Tags { get; set; }
    }

    internal enum EyeColor
    {
        Green,
        Brown,
        Blue,
    }
}
