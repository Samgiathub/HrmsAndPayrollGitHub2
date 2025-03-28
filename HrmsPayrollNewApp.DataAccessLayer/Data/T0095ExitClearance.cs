﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class T0095ExitClearance
{
    public decimal TranId { get; set; }

    public decimal CmpId { get; set; }

    public decimal EmpId { get; set; }

    public decimal? DeptId { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public decimal? CenterId { get; set; }

    public decimal? BranchId { get; set; }
}
