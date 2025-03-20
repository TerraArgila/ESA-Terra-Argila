<<<<<<< Updated upstream
using ESA_Terra_Argila.Models;
using ESA_Terra_Argila.Data;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
=======
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ESA_Terra_Argila.Models;
>>>>>>> Stashed changes

namespace ESA_Terra_Argila.Services
{
    public class UserActivityService : IUserActivityService
    {
<<<<<<< Updated upstream
        private readonly ApplicationDbContext _context;

        public UserActivityService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserActivity>> GetUserActivitiesAsync(
            string userId,
            string? activityType = null,
            DateTime? startDate = null,
            DateTime? endDate = null)
        {
            var query = _context.UserActivities
                .Where(a => a.UserId == userId);

            if (!string.IsNullOrEmpty(activityType))
            {
                query = query.Where(a => a.ActivityType == activityType);
            }

            if (startDate.HasValue)
            {
                query = query.Where(a => a.Timestamp >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(a => a.Timestamp <= endDate.Value);
            }

            return await query.OrderByDescending(a => a.Timestamp).ToListAsync();
        }

        public async Task<bool> IsAuthorizedToViewActivitiesAsync(ClaimsPrincipal user, string targetUserId)
        {
            // Admins podem ver todas as atividades
            if (user.IsInRole("Admin"))
            {
                return true;
            }

            // Usuários só podem ver suas próprias atividades
            var currentUserId = user.FindFirstValue(ClaimTypes.NameIdentifier);
            return currentUserId == targetUserId;
        }

        public async Task LogActivityAsync(
            string userId,
            string activityType,
            string description,
            bool isSuccess,
            string? additionalInfo = null)
        {
            var activity = new UserActivity
            {
                UserId = userId,
                ActivityType = activityType,
                Description = description,
                IsSuccess = isSuccess,
                AdditionalInfo = additionalInfo,
                Timestamp = DateTime.UtcNow
            };

            _context.UserActivities.Add(activity);
            await _context.SaveChangesAsync();
=======
        public async Task<IEnumerable<UserActivity>> GetUserActivitiesAsync(string userId, string activityType, DateTime? startDate, DateTime? endDate)
        {
            // Implementação simulada para retornar atividades do usuário
            var activities = new List<UserActivity>
            {
                new UserActivity { Id = 1, UserId = userId, ActivityType = "Login" },
                new UserActivity { Id = 2, UserId = userId, ActivityType = "Logout" }
            };

            return activities;
        }

        public async Task<bool> IsAuthorizedToViewActivitiesAsync(System.Security.Claims.ClaimsPrincipal user, string userId)
        {
            // Implementação simulada para verificar autorização
            return true; // Simulando que o usuário está autorizado
>>>>>>> Stashed changes
        }
    }
} 