using System;
using FluentValidation;
using SchoolManager.API.Models;

namespace SchoolManager.API.Validators
{
    public class AddStudentValidator : AbstractValidator<AddStudentInputModel>
    {
        public AddStudentValidator()
        {
            RuleFor(m => m.FullName)
                .NotEmpty()
                    .WithMessage("Full name must not be null or empty")
                .MaximumLength(50)
                    .WithMessage("Full name length must be less than 50")
                .MinimumLength(5)
                    .WithMessage("Full name length must be more than 5");
            
            RuleFor(m => m.BirthDate)
                .LessThan(DateTime.Now.Date)
                .WithMessage("Birth date must be older than today");

            RuleFor(m => m.Document)
                .Must(d => d.IsValidDocument())
                .WithMessage("Document is invalid");
        }
    }
}