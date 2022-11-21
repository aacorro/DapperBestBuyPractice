using System;
using System.Collections.Generic;
using System.Text;

namespace DapperBestBuyPractice
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments(); 
    }
}
