namespace domain.validator

{
    public interface IValidator<E>
    {
         void Validate(E e);
    }
}