using Bayt.Service.DTOs.Users;

namespace Bayt.Service.Interfaces;

public interface IUserService
{
    ValueTask<UserResultDto> AddAsync(UserCreationDto dto);
    ValueTask<UserResultDto> ModifyAsync(UserUpdateDto dto);
    ValueTask<bool> RemoveAsync(Guid id);
    ValueTask<UserResultDto> GetByIdAsync(Guid id);
    ValueTask<IEnumerable<UserResultDto>> GetAllAsync();
}