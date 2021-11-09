// See https://aka.ms/new-console-template for more information

using System;
using ChainOfResponsibility;
using ChainOfResponsibility.Validators;

var voucher = new Voucher
{
    Id = Guid.NewGuid(),
    CampaignName = "My test campaign",
    ExpirationDate = DateTime.UtcNow.AddDays(2),
    RedemptionCount = 2
};

var validation = new ValidationHandler(
    new RedemptionCountValidator(),
    new ExpirationValidator(),
    new CampaignNameValidator());

validation.Handle(voucher);