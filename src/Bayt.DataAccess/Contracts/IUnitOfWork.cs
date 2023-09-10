using Bayt.Domain.Entities.Addresses.Addresses;
using Bayt.Domain.Entities.Addresses.Countries;
using Bayt.Domain.Entities.Addresses.Districts;
using Bayt.Domain.Entities.Addresses.Regions;
using Bayt.Domain.Entities.Attachments;
using Bayt.Domain.Entities.Companies;
using Bayt.Domain.Entities.RealEstates;
using Bayt.Domain.Entities.Roommates;
using Bayt.Domain.Entities.Users;

namespace Bayt.DataAccess.Contracts;

public interface IUnitOfWork:IDisposable
{
    IRepository<User> UserRepository { get; }
    IRepository<Attachment> AttachmentRepository { get; }
    IRepository<Company> CompanyRepository { get; }
    IRepository<Roommate> RoommateRepository { get; }
    IRepository<RealEstate> RealEstateRepository { get; }
    IRepository<Address> AddressRepository { get; }
    IRepository<Country> CountryRepository { get; }
    IRepository<Region> RegionRepository { get; }
    IRepository<District> DistrictRepository { get; }
    Task SaveAsync();
}