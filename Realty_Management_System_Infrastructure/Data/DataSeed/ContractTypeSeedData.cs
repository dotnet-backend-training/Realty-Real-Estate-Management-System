using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class ContractTypeSeedData
    {
        public static ContractType[] GetContractTypes()
        {
            return
            [
                new ContractType
                {
                    Id = SeedIds.ContractType1,
                    Name = "Sale"
                },
                new ContractType
                {
                    Id = SeedIds.ContractType2,
                    Name = "Rent"
                },
                new ContractType
                {
                    Id = SeedIds.ContractType3,
                    Name = "Lease"
                }
            ];
        }
    }
}
