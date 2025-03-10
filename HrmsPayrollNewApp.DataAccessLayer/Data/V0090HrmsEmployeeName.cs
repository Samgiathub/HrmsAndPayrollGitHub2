﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class V0090HrmsEmployeeName
{
    public decimal LoginId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public DateTime ForDate { get; set; }

    public decimal CmpId { get; set; }

    public decimal? BranchId { get; set; }

    public decimal ApprIntId { get; set; }

    public decimal Status { get; set; }
}
