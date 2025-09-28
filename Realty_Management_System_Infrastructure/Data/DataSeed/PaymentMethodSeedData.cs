using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class PaymentMethodSeedData
    {
        public static PaymentMethod[] GetPaymentMethods()
        {
            return
            [
                new PaymentMethod
                {
                    Id = SeedIds.PaymentMethodCash,
                    Name = "Cash"
                },
                new PaymentMethod
                {
                    Id = SeedIds.PaymentMethodCreditCard,
                    Name = "Credit Card"
                },
                new PaymentMethod
                {
                    Id = SeedIds.PaymentMethodBankTransfer,
                    Name = "Bank Transfer"
                },
                new PaymentMethod
                {
                    Id = SeedIds.PaymentMethodMobileWallet,
                    Name = "Mobile Wallet"
                },
                new PaymentMethod
                {
                    Id = SeedIds.PaymentMethodPayPal,
                    Name = "PayPal"
                }
            ];
        }
    }
}
