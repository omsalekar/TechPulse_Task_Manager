using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPulse_Task_Manager.DATAACCESS.Interfaces
{
    public interface IUnitOfWork
    {
        public IEmployeeService _employeeService { get; }
    }
}
