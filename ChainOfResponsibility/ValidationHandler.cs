using System;
using System.Collections.Generic;
using Ardalis.GuardClauses;

namespace ChainOfResponsibility;

public class ValidationHandler
{
    private readonly IList<IReceiver<Voucher>> _receivers;

    public ValidationHandler(params IReceiver<Voucher>[] receivers)
    {
        _receivers = receivers;
    }

    public void Handle(Voucher voucher)
    {
        foreach (var receiver in _receivers)
        {
            Console.WriteLine($"Running: {receiver.GetType().Name}.");

            if (receiver.Validate(voucher)) continue;

            Console.WriteLine("Validation failed.");
            return;
        }

        Console.WriteLine("Validation successful");
    }

    public void SetNext(IReceiver<Voucher> next)
    {
        Guard.Against.Null(next, nameof(next));
        _receivers.Add(next);
    }
}