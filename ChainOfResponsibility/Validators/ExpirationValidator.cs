using System;

namespace ChainOfResponsibility.Validators;

public class ExpirationValidator : IReceiver<Voucher>
{
    public bool Validate(Voucher voucher)
    {
        return voucher.ExpirationDate > DateTime.UtcNow;
    }
}