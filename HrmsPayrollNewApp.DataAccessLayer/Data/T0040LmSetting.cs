﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class T0040LmSetting
{
    public decimal? RowId { get; set; }

    public decimal? CmpId { get; set; }

    public decimal? BranchId { get; set; }

    public DateTime? ForDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? MaxLimit { get; set; }

    public int? TypeId { get; set; }

    public string? EffectiveMonth { get; set; }

    public int? EffectOnCtc { get; set; }

    public int? CalAmountType { get; set; }

    public int? ShowYearly { get; set; }
}