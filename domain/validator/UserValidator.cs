
namespace domain.validator
{
    public class UserValidator : IValidator<User>
    {
        public void Validate(User e)
        {
            string errors = "";
            if (e.username == "")
                errors += "Username cannot be null!\n";
            if (e.password == "")
                errors += "Password cannot be null!";
        }
    }
}