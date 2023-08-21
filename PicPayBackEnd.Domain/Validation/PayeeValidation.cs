﻿using FluentValidation;
using PicPayBackEnd.Domain.Entities;
using PicPayBackEnd.Domain.Validation.ValueObjects;

namespace PicPayBackEnd.Domain.Validation
{
    public class PayeeValidation : AbstractValidator<Payee>
    {
        public PayeeValidation()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("Payer ID must not be empty");

            RuleFor(p => p.User).SetValidator(new UserValidation());
        }
    }
}
