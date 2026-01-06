using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechPulse_Task_Manager.DATAACCESS.Interfaces;
using TechPulse_Task_Manager.WebAPI.Data;

namespace TechPulse_Task_Manager.DATAACCESS.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public TaskDbContext _dbContext { get; private set; }
        public IEmployeeService _employeeService { get; private set; }

        public UnitOfWork(TaskDbContext dbContext, IEmployeeService _employeeService) 
        {
             _dbContext = dbContext;
            this._employeeService = _employeeService;
        }
    }
}
