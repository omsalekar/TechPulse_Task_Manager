using Microsoft.EntityFrameworkCore;
using TechPulse_Task_Manager.MODELS.Models;


namespace TechPulse_Task_Manager.DATAACCESS.ApplicationDbContext
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        {
        }
        public DbSet<Employees> EmployeeTasks { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<TaskScreenshots> TaskScreenshots { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<TaskCounts> TaskCounts { get; set; }
        public DbSet<AuditLogs> AuditLogs { get; set; }


        }
}
