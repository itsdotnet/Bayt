using Bayt.DataAccess.Contexts;
using Bayt.DataAccess.Contracts;
using Bayt.Domain.Entities.Addresses.Addresses;
using Bayt.Domain.Entities.Addresses.Countries;
using Bayt.Domain.Entities.Addresses.Districts;
using Bayt.Domain.Entities.Addresses.Regions;
using Bayt.Domain.Entities.Attachments;
using Bayt.Domain.Entities.Companies;
using Bayt.Domain.Entities.RealEstates;
using Bayt.Domain.Entities.Roommates;
using Bayt.Domain.Entities.Users;

namespace Bayt.DataAccess.Repositories;

public class UnitOfWork:IUnitOfWork
{
    private readonly BaytDbContext _context;
    
    public UnitOfWork(BaytDbContext context, IRepository<User> userRepository, 
        IRepository<Attachment> attachmentRepository,IRepository<Company> companyRepository,
        IRepository<Roommate> roommateRepository, IRepository<RealEstate> realEstateRepository, 
        IRepository<Address> addressRepository, IRepository<Country> countryRepository, 
        IRepository<Region> regionRepository, IRepository<District> districtRepository)
    {
        _context = context;
        UserRepository = userRepository;
        AttachmentRepository = attachmentRepository;
        CompanyRepository = companyRepository;
        RoommateRepository = roommateRepository;
        RealEstateRepository = realEstateRepository;
        AddressRepository = addressRepository;
        CountryRepository = countryRepository;
        RegionRepository = regionRepository;
        DistrictRepository = districtRepository;
    }

    public IRepository<User> UserRepository { get; }
    public IRepository<Attachment> AttachmentRepository { get; }
    public IRepository<Company> CompanyRepository { get; }
    public IRepository<Roommate> RoommateRepository { get; }
    public IRepository<RealEstate> RealEstateRepository { get; }
    public IRepository<Address> AddressRepository { get; }
    public IRepository<Country> CountryRepository { get; }
    public IRepository<Region> RegionRepository { get; }
    public IRepository<District> DistrictRepository { get; }
    
    public async ValueTask SaveAsync() => await _context.SaveChangesAsync();
    
    public void Dispose()
    {
        GC.SuppressFinalize(true);
    }
}