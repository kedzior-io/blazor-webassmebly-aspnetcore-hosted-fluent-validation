using FluentValidation;

namespace BlazorFluentValidation.Shared
{
    public class Address
    {
        public string City { get; set; }
        public string Country { get; set; }
    }

    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(p => p.City).NotEmpty().WithMessage("You must enter a city");
            RuleFor(p => p.Country).NotEmpty().WithMessage("You must enter a county");
        }
    }
}