﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class T0030DistrictMaster
{
    public decimal DistId { get; set; }

    public string? DistName { get; set; }

    public decimal? StateId { get; set; }

    public decimal? CmpId { get; set; }

    public decimal? LocId { get; set; }
}