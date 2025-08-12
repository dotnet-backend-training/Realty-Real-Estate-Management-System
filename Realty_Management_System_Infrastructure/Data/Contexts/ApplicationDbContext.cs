using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Realty_Management_System_Domain.Entities;
using System.Reflection;

namespace Realty_Management_System_Infrastructure.Data.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        // DbSets for all entities

        #region Location Entities
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Zone> Zones { get; set; }
        #endregion

        #region Property Entities
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyCategory> PropertyCategories { get; set; }
        public DbSet<PropertyCategoryAssociation> PropertyCategoryAssociations { get; set; }
        public DbSet<PropertyAmenity> PropertyAmenities { get; set; }
        public DbSet<PropertyFeature> PropertyFeatures { get; set; }
        public DbSet<PropertyFeatureAssociation> PropertyFeatureAssociations { get; set; }
        public DbSet<PropertyImage> PropertyImages { get; set; }
        public DbSet<PropertyReview> PropertyReviews { get; set; }
        public DbSet<PropertyStatus> PropertyStatuses { get; set; }
        #endregion

        #region Amenities & Nearby Places
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<NearbyPlace> NearbyPlaces { get; set; }
        public DbSet<NearbyPlaceType> NearbyPlaceTypes { get; set; }
        #endregion

        #region Contracts & Pricing
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractType> ContractTypes { get; set; }
        public DbSet<PriceUnit> PriceUnits { get; set; }
        public DbSet<PriceUnitType> PriceUnitTypes { get; set; }
        public DbSet<PaymentFrequency> PaymentFrequencies { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        #endregion

        #region Transactions & Invoices
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionStatus> TransactionStatuses { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceStatus> InvoiceStatuses { get; set; }
        #endregion

        #region Property Tours
        public DbSet<PropertyTourRequest> PropertyTourRequests { get; set; }
        public DbSet<PropertyTourRequestStatus> PropertyTourRequestStatuses { get; set; }
        #endregion
    }
}
