using AutoMapper;
using Bayt.DataAccess.Contracts;
using Bayt.Domain.Configurations;
using Bayt.Domain.Entities.Roommates;
using Bayt.Domain.Entities.Users;
using Bayt.Domain.Enums;
using Bayt.Service.DTOs.RealEstates;
using Bayt.Service.DTOs.Roommates;
using Bayt.Service.DTOs.Users;
using Bayt.Service.Exceptions;
using Bayt.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Bayt.Service.Services;

public class UserService:IUserService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public UserService(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async ValueTask<UserResultDto> AddAsync(UserCreationDto dto)
    {
        var existUser = await _unitOfWork.UserRepository
            .SelectAsync(user => user.PhoneNumber == dto.PhoneNumber);

        if (existUser != null)
            throw new AlreadyExistsException(message: "User is Already exist!");

        var mappedUser = _mapper.Map<User>(source:dto);

        await _unitOfWork.UserRepository.CreateAsync(entity: mappedUser);
        await _unitOfWork.SaveAsync();

        return _mapper.Map<UserResultDto>(source:mappedUser);
    }

    public async ValueTask<UserResultDto> ModifyAsync(UserUpdateDto dto)
    {
        var existUser = await _unitOfWork.UserRepository
                            .SelectAsync(user => user.Id == dto.Id)
                        ?? throw new NotFoundException(message: "User is not found!");

        _mapper.Map(source:dto, destination:existUser);

        _unitOfWork.UserRepository.Update(entity:existUser);
        await _unitOfWork.SaveAsync();

        return _mapper.Map<UserResultDto>(source:existUser);
    }

    public async ValueTask<bool> RemoveAsync(Guid id)
    {
        var existUser = await _unitOfWork.UserRepository
                            .SelectAsync(user => user.Id == id)
                        ?? throw new NotFoundException(message: "User is not found!");

        _unitOfWork.UserRepository.Delete(entity:existUser);
        await _unitOfWork.SaveAsync();

        return true;
    }

    public async ValueTask<UserResultDto> GetByIdAsync(Guid id)
    {
        var existUser = await _unitOfWork.UserRepository
                            .SelectAsync(user => user.Id == id)
                        ?? throw new NotFoundException(message: "User is not found!");

        return _mapper.Map<UserResultDto>(source: existUser);
    }

    public async ValueTask<IEnumerable<UserResultDto>> GetByRoleAsync(Role role)
    {
        var existUsers = await _unitOfWork.UserRepository
                            .SelectAll(user => user.Role == role).ToListAsync()
                        ?? throw new NotFoundException(message: "User is not found!");

        return _mapper.Map<IEnumerable<UserResultDto>>(source: existUsers);
    }

    public async ValueTask<IEnumerable<RealEstateResultDto>> GetByRealEstateAsync(Guid userId)
    {
        var existUser = await _unitOfWork.UserRepository
                            .SelectAsync(user => user.Id == userId)
                        ?? throw new NotFoundException(message: "User is not found!");

        var existRealEstates = await _unitOfWork.RealEstateRepository
            .SelectAll(reaEstate => reaEstate.UserId == userId).ToListAsync();

        return _mapper.Map<IEnumerable<RealEstateResultDto>>(source: existRealEstates);
    }

    public async ValueTask<IEnumerable<RoommateResultDto>> GetByRoommateAsync(Guid userId)
    {
        var existUser = await _unitOfWork.UserRepository
                            .SelectAsync(user => user.Id == userId)
                        ?? throw new NotFoundException(message: "User is not found!");

        var existRoommates = await _unitOfWork.RoommateRepository
            .SelectAll(roommate => roommate.UserId == userId).ToListAsync();

        return _mapper.Map<IEnumerable<RoommateResultDto>>(source: existRoommates);
    }

    public async ValueTask<IEnumerable<UserResultDto>> GetAllAsync()
    {
        var users = await _unitOfWork.UserRepository.SelectAll().ToListAsync();

        return _mapper.Map<IEnumerable<UserResultDto>>(source: users);
    }

    public async ValueTask<IEnumerable<UserResultDto>> GetAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }
}