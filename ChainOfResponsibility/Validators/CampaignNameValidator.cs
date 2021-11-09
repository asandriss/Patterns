namespace ChainOfResponsibility.Validators;

public class CampaignNameValidator : IReceiver<Voucher>
{
    public bool Validate(Voucher voucher)
    {
        return !string.IsNullOrEmpty(voucher.CampaignName);
    }
}