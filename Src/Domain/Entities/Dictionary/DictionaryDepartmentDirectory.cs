using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Dictionary
{
    public class DictionaryDepartmentDirectory
    {
        public Guid DepartmentDirectoryId { get; set; }
        public string DepartmentDirectory { get; set; }
        public Guid DepartmentManagerId { get; set; }

        public virtual ClientProfile DepartmentManager { get; set; }
    }
}
