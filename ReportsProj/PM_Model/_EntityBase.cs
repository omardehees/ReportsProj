using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ReportsProj.PM_Model;

namespace ReportsProj.PM_Model
{
    public class _EntityBase
    {
        [Key]
        public int Id { get; set; }
        public bool IsEnabled { get; set; } = true;
        public bool IsDefault { get; set; } = false;
        public string Notes { get; set; }

    }
}
