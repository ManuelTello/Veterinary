using System.Text.RegularExpressions;
using FluentResults;

namespace Veterinary.Backend.Domain.ObjectValues
{
    public partial record Email
    {
        private const string RegexEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        public string EmailValue { get; init; }

        private Email(string emailValue)
        {
            this.EmailValue = emailValue;
        }

        public static Result<Email> Create(string emailValue)
        {
            if (string.IsNullOrEmpty(emailValue) || string.IsNullOrWhiteSpace(emailValue))
            {
                return Result.Fail("Field required");
            }
            else if (!Validate().IsMatch(emailValue))
            {
                return Result.Fail("Invalid email address");
            }
            else
            {
                var email = new Email(emailValue);
                return Result.Ok(email);
            }
        }

        [GeneratedRegex(RegexEmail)]
        private static partial Regex Validate();
    }
}

