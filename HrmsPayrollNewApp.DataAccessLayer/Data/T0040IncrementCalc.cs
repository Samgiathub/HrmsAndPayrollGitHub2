﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class T0040IncrementCalc
{
    public decimal TranId { get; set; }

    public decimal CmpId { get; set; }

    public DateTime ForDate { get; set; }

    public decimal BranchId { get; set; }

    public string? Particulars { get; set; }

    public decimal? LoginId { get; set; }

    public DateTime? Systemdate { get; set; }
}
