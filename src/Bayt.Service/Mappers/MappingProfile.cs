using AutoMapper;
using Bayt.Service.DTOs.Users;
using Bayt.Domain.Entities.Users;
using Bayt.Service.DTOs.Roommates;
using Bayt.Service.DTOs.Companies;
using Bayt.Service.DTOs.Categories;
using Bayt.Service.DTOs.RealEstates;
using Bayt.Domain.Entities.Roommates;
using Bayt.Domain.Entities.Companies;
using Bayt.Domain.Entities.Categories;
using Bayt.Domain.Entities.RealEstates;
using Bayt.Service.DTOs.Addresses.Regions;
using Bayt.Service.DTOs.Addresses.Addresses;
using Bayt.Service.DTOs.Addresses.Countries;
using Bayt.Service.DTOs.Addresses.Districts;
using Bayt.Domain.Entities.Addresses.Regions;
using Bayt.Domain.Entities.Addresses.Addresses;
using Bayt.Domain.Entities.Addresses.Countries;
using Bayt.Domain.Entities.Addresses.Districts;

namespace Bayt.Service.Mappers;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
            //User
            CreateMap<User,UserResultDto>();
            CreateMap<User, UserCreationDto>().ReverseMap();
            CreateMap<User, UserUpdateDto>().ReverseMap();
            
            //Company
            CreateMap<Company, CompanyResultDto>().ReverseMap();
            CreateMap<Company, CompanyUpdateDto>().ReverseMap();
            CreateMap<Company, CompanyCreationDto>().ReverseMap();
            
            //Category
            CreateMap<Category, CategoryResultDto>().ReverseMap();
            CreateMap<Category, CategoryCreationDto>().ReverseMap();
            CreateMap<Category, CategoryUpdateDto>().ReverseMap();
            
            //Roommate
            CreateMap<Roommate, RoommateCreationDto>().ReverseMap();
            CreateMap<Roommate, RoommateResultDto>().ReverseMap();
            CreateMap<Roommate, RoommateUpdateDto>().ReverseMap();
            
            //Real Estate
            CreateMap<RealEstate, RealEstateResultDto>().ReverseMap();
            CreateMap<RealEstate, RealEstateUpdateDto>().ReverseMap();
            CreateMap<RealEstate, RealEstateCreationDto>().ReverseMap();
            
            //Address
            CreateMap<Address, AddressUpdateDto>().ReverseMap();
            CreateMap<Address, AddressCreationDto>().ReverseMap();
            CreateMap<Address, AddressResultDto>().ReverseMap();
            
            //Country
            CreateMap<Country, CountryResultDto>().ReverseMap();
            CreateMap<Country, CountryCreationDto>().ReverseMap();
            CreateMap<Country, CountryUpdateDto>().ReverseMap();
            
            //Region
            CreateMap<Region, RegionUpdateDto>().ReverseMap();
            CreateMap<Region, RegionCreationDto>().ReverseMap();
            CreateMap<Region, RegionResultDto>().ReverseMap();
            
            //District
            CreateMap<District, DistrictUpdateDto>().ReverseMap();
            CreateMap<District, DistrictCreationDto>().ReverseMap();
            CreateMap<District, DistrictResultDto>().ReverseMap();
    }
}