using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using FluentResults;

namespace Veterinary.Backend.Domain.ObjectValues
{
    public partial record Name
    {
        private const string RegexName = @"^([a-zA-Z]\s{1})+$";

        private const int MaxLength = 250;

        public string NameValue { get; init; }

        private Name(string nameValue)
        {
            this.NameValue = nameValue;
        }

        public static Result<Name> Create(string nameValue)
        {
            if (string.IsNullOrEmpty(nameValue) || string.IsNullOrWhiteSpace(nameValue))
            {
                return Result.Fail("Field is required");
            }
            else if (nameValue.Length > MaxLength)
            {
                return Result.Fail("Name too long");
            }
            else if (!Validate().IsMatch(nameValue))
            {
                return Result.Fail("Invalid name");
            }
            else
            {
                var name = new Name(nameValue);
                return name;
            }
        }

        [GeneratedRegex(RegexName)]
        private static partial Regex Validate();
    }
}