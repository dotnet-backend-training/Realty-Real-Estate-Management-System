using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class PaymentFrequencySeedData
    {
        public static PaymentFrequency[] GetPaymentFrequencies()
        {
            return
            [
                new PaymentFrequency
                {
                    Id = SeedIds.PaymentFrequencyMonthly,
                    Name = "Monthly"
                },
                new PaymentFrequency
                {
                    Id = SeedIds.PaymentFrequencyQuarterly,
                    Name = "Quarterly"
                },
                new PaymentFrequency
                {
                    Id = SeedIds.PaymentFrequencyAnnually,
                    Name = "Annually"
                },
                new PaymentFrequency
                {
                    Id = SeedIds.PaymentFrequencyWeekly,
                    Name = "Weekly"
                },
                new PaymentFrequency
                {
                    Id = SeedIds.PaymentFrequencyBiWeekly,
                    Name = "Bi-Weekly"
                }
            ];
        }
    }
}
