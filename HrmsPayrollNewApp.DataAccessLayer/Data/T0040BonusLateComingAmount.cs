﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class T0040BonusLateComingAmount
{
    public int TranId { get; set; }

    public decimal? CmpId { get; set; }

    public decimal? EmpId { get; set; }

    public DateTime? ForDate { get; set; }

    public DateTime? InTime { get; set; }

    public DateTime? OutTime { get; set; }

    public string? LateComingDuration { get; set; }

    public decimal? Amount { get; set; }
}
