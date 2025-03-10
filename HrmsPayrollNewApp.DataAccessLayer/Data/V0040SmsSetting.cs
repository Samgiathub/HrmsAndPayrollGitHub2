﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class V0040SmsSetting
{
    public decimal BdId { get; set; }

    public decimal CmpId { get; set; }

    public decimal? BranchId { get; set; }

    public string BranchName { get; set; } = null!;

    public string? Url { get; set; }

    public string? UserId { get; set; }

    public string? Password { get; set; }

    public string? SenderId { get; set; }

    public string? MessageText { get; set; }

    public string? AnniversaryText { get; set; }

    public string? AttendanceText { get; set; }

    public string? ForgotPasswordText { get; set; }
}
