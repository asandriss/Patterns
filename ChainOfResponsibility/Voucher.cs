using System;

namespace ChainOfResponsibility;

public class Voucher
{
    public Guid Id { get; set; }

    public string CampaignName { get; set; } = string.Empty;

    public DateTime ExpirationDate { get; set; }

    public int RedemptionCount { get; set; }
}