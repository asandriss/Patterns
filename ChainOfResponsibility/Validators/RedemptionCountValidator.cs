namespace ChainOfResponsibility.Validators;

public class RedemptionCountValidator : IReceiver<Voucher>
{
    public bool Validate(Voucher voucher)
    {
        return voucher.RedemptionCount > 0 && voucher.RedemptionCount % 2 == 0;
    }
}