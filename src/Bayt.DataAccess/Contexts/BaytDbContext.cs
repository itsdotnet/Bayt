using Bayt.Domain.Entities.Addresses.Addresses;
using Bayt.Domain.Entities.Addresses.Countries;
using Bayt.Domain.Entities.Addresses.Districts;
using Bayt.Domain.Entities.Addresses.Regions;
using Bayt.Domain.Entities.Attachments;
using Bayt.Domain.Entities.Categories;
using Bayt.Domain.Entities.Companies;
using Bayt.Domain.Entities.RealEstates;
using Bayt.Domain.Entities.Roommates;
using Bayt.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Bayt.DataAccess.Contexts;

public class BaytDbContext:DbContext
{
    public BaytDbContext(DbContextOptions<BaytDbContext> options):base(options)
    { }

    public DbSet<User> Users { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<RealEstate> RealEstates { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Roommate> Roommates { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<District> Districts { get; set; }
}