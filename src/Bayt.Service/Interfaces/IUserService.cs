using Bayt.Domain.Configurations;
using Bayt.Domain.Entities.Roommates;
using Bayt.Domain.Enums;
using Bayt.Service.DTOs.Users;

namespace Bayt.Service.Interfaces;

public interface IUserService
{
    ValueTask<UserResultDto> AddAsync(UserCreationDto dto);
    ValueTask<UserResultDto> ModifyAsync(UserUpdateDto dto);
    ValueTask<bool> RemoveAsync(Guid id);
    ValueTask<IEnumerable<UserResultDto>> GetByRoleAsync(Role role);
    ValueTask<IEnumerable<UserResultDto>> GetByRealEstateAsync(Guid userId);
    ValueTask<IEnumerable<Roommate>> GetByRoommateAsync(Guid userId);
    ValueTask<IEnumerable<UserResultDto>> GetAllAsync();
    ValueTask<IEnumerable<UserResultDto>> GetAllAsync(PaginationParams @params);
}