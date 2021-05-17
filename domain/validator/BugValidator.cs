using LinqToDB.Common;

namespace domain.validator
{
    public class BugValidator : IValidator<Bug>
    {
        public void Validate(Bug e)
        {
            string errors = "";
            if (e.description.IsNullOrEmpty())
                errors += "Description cannot be null!\n";
            if (e.name.IsNullOrEmpty())
                errors += "Name cannot be null!\n";
            if (e.foundBy.IsNullOrEmpty())
                errors += "Bug founder cannot be null!";
            if (errors.Length > 0)
                throw new ValidationException(errors);
        }
    }
}