using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class TransactionSeedData
    {
        public static Transaction[] GetTransactions()
        {
            return
            [
                new Transaction
                {
                    Id = SeedIds.Transaction1,
                    AmountPaid = 1500.00m,
                    PaymentMethodId = SeedIds.PaymentMethodCash,
                    InvoiceId = SeedIds.Invoice1,
                    TransactionStatusId = SeedIds.TransactionStatus1,
                    PropertyReviewId = null
                },
                new Transaction
                {
                    Id = SeedIds.Transaction2,
                    AmountPaid = 3000.00m,
                    PaymentMethodId = SeedIds.PaymentMethodCreditCard,
                    InvoiceId = SeedIds.Invoice2,
                    TransactionStatusId = SeedIds.TransactionStatus2,
                    PropertyReviewId = null
                },
                new Transaction
                {
                    Id = SeedIds.Transaction3,
                    AmountPaid = 2000.00m,
                    PaymentMethodId = SeedIds.PaymentMethodBankTransfer,
                    InvoiceId = SeedIds.Invoice3,
                    TransactionStatusId = SeedIds.TransactionStatus3,
                    PropertyReviewId = null
                },
                new Transaction
                {
                    Id = SeedIds.Transaction4,
                    AmountPaid = 4500.00m,
                    PaymentMethodId = SeedIds.PaymentMethodMobileWallet,
                    InvoiceId = SeedIds.Invoice4,
                    TransactionStatusId = SeedIds.TransactionStatus4,
                    PropertyReviewId = null
                },
                new Transaction
                {
                    Id = SeedIds.Transaction5,
                    AmountPaid = 5000.00m,
                    PaymentMethodId = SeedIds.PaymentMethodPayPal,
                    InvoiceId = SeedIds.Invoice5,
                    TransactionStatusId = SeedIds.TransactionStatus1,
                    PropertyReviewId = null
                }
            ];
        }
    }
}
