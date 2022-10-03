﻿using MA.CQRS.Domain.Commands.Model.Validations;

namespace MA.CQRS.Domain.Commands.Model
{
    public class NewUserCommand : UserCommand
    {
        public NewUserCommand(string name, string address) : base(name, address)
        {
        }

        public override bool IsValid()
        {
            ValidationResult = new NewUserCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
