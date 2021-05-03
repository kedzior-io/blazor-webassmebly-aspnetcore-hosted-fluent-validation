using FluentValidation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorFluentValidation.Shared
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Address> Adresses { get; set; } = new List<Address>();
    }

    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FirstName)
            .NotEmpty().WithMessage("You must enter your first name")
            .MaximumLength(50).WithMessage("First name cannot be longer than 50 characters");

            RuleFor(p => p.LastName)
            .NotEmpty().WithMessage("You must enter your last name")
            .MaximumLength(50).WithMessage("Last name cannot be longer than 50 characters");
         }
    }
}