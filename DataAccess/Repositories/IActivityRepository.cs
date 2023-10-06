using StudyTracker.DataAccess.Models;

namespace DataAccess.Repositories
{
    public interface IActivityRepository
    {
        Task<Activity> AddActivityAsync(Activity activity);
        Task DeleteActivityAsync(int id);
        Task FindActivityByIdAsync(int id);
        Task<IEnumerable<Activity>> GetAllActivitiesAsync();
        Task UpdateActivityAsync(Activity activity);
    }
}