﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class V0100AdGradeBranchWise
{
    public decimal TranId { get; set; }

    public decimal? CmpId { get; set; }

    public decimal? AdId { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public decimal? GrdId { get; set; }

    public decimal? BranchId { get; set; }

    public decimal? AdAmount { get; set; }

    public DateTime? SysDatetime { get; set; }

    public decimal? UserId { get; set; }

    public string? BranchName { get; set; }

    public string GrdName { get; set; } = null!;

    public string AdName { get; set; } = null!;

    public string AdCalculateOn { get; set; } = null!;
}