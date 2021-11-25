using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TaskType
    {
        public TaskType()
        {
            OrderTasks = new HashSet<OrderTask>();
        }

        public string TaskTypeId { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<OrderTask> OrderTasks { get; set; }
    }
}
