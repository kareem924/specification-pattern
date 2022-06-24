namespace SpecificationPattern.Demo
{
    internal class UserFilter
    {

        public IEnumerable<User> FilterUsersByName(IEnumerable<User> users, string name)
        {
            foreach (User? user in users)
            {
                if (user.Name.ToLower().StartsWith(name.ToLower()))
                {
                    yield return user;
                }
            }
        }

        public IEnumerable<User> FilterUsersByEyeColor(IEnumerable<User> users, EyeColor eyeColor)
        {
            foreach (User? user in users)
            {
                if (user.EyeColor == eyeColor)
                {
                    yield return user;
                }
            }
        }

        public IEnumerable<User> FilterUsersByCompany(IEnumerable<User> users, string companyDomain)
        {
            foreach (User? user in users)
            {
                if (user.Email.Split('@')[1].StartsWith(companyDomain))
                {
                    yield return user;
                }
            }
        }
    }
}
