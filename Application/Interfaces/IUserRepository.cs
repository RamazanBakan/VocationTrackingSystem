﻿using Domain.Core;

namespace Application.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> AddAsync(User user);
        Task<User> GetUserByUsernameAndPasswordAsync(string username, string password);
        Task<User> GetUserByUsernameAsync(string username);
        Task<bool> UpdateAsync(User user);
        Task<IEnumerable<User>> GetUsersByAdminIdAsync(int adminId);

        Task<User> GetUserByIdAsync(int existingRequestUserId);
    }
}