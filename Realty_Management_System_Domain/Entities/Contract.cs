namespace Realty_Management_System_Domain.Entities
{
    public class Contract : BaseEntity
    {
        public Guid PropertyId { get; set; }
        public Property Property { get; set; } = default!;
        public Guid ContractTypeId { get; set; }
        public ContractType ContractType { get; set; } = default!;
    }
}
