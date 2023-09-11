using Bayt.Domain.Configurations;
using Bayt.Domain.Entities.Roommates;
using Bayt.Domain.Enums;
using Bayt.Service.DTOs.RealEstates;
using Bayt.Service.DTOs.Roommates;
using Bayt.Service.DTOs.Users;

namespace Bayt.Service.Interfaces;

public interface IUserService
{
    ValueTask<UserResultDto> AddAsync(UserCreationDto dto);
    ValueTask<UserResultDto> ModifyAsync(UserUpdateDto dto);
    ValueTask<bool> RemoveAsync(Guid id);
    ValueTask<UserResultDto> GetByIdAsync(Guid id);
    ValueTask<IEnumerable<UserResultDto>> GetByRoleAsync(Role role);
    ValueTask<IEnumerable<RealEstateResultDto>> GetByRealEstateAsync(Guid userId);
    ValueTask<IEnumerable<RoommateResultDto>> GetByRoommateAsync(Guid userId);
    ValueTask<IEnumerable<UserResultDto>> GetAllAsync();
    ValueTask<IEnumerable<UserResultDto>> GetAllAsync(PaginationParams @params);
}