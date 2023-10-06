using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using StudyTracker.DataAccess.Models;
using System.Data;
using Dapper;

namespace DataAccess.Repositories;

public class ActivityRepository : IActivityRepository
{
    //private readonly IConfiguration _config;
    private readonly string connectionString;
    public ActivityRepository()
    {
        //_config = config;
        //connectionString = _config.GetConnectionString("default");
        connectionString = @"server=RAVINDRA\MSSQLSERVER01;database=ActivityTracker;integrated security=true;encrypt=false";
    }
    public async Task<Activity> AddActivityAsync(Activity activity)
    {
        using IDbConnection connection = new SqlConnection(connectionString);
        string sql = "insert into Activity (ActivityDate,TotalHours,Description) values(@ActivityDate,@TotalHours,@Description); select SCOPE_IDENTITY()";
        int createdId = await connection.ExecuteScalarAsync<int>(sql, new
        {
            activity.ActivityDate,
            activity.TotalHours,
            activity.Description
        });
        activity.Id = createdId;
        return activity;
    }

    public async Task UpdateActivityAsync(Activity activity)
    {
        using IDbConnection connection = new SqlConnection(connectionString);
        string sql = "update Activity set ActivityDate=@ActivityDate,TotalHours=@TotalHours,Description=@Description where Id=@Id";
        await connection.ExecuteAsync(sql, activity);
    }

    public async Task DeleteActivityAsync(int id)
    {
        using IDbConnection connection = new SqlConnection(connectionString);
        string sql = "delete from Activity where Id=@id";
        await connection.ExecuteAsync(sql, new { id });
    }

    public async Task FindActivityByIdAsync(int id)
    {
        using IDbConnection connection = new SqlConnection(connectionString);
        string sql = "select * from Activity where Id=@id";
        await connection.QueryFirstOrDefaultAsync<Activity>(sql, new { id });
    }

    public async Task<IEnumerable<Activity>> GetAllActivitiesAsync()
    {
        using IDbConnection connection = new SqlConnection(connectionString);
        string sql = "select * from Activity";
        var activities = await connection.QueryAsync<Activity>(sql);
        return activities;
    }
}
