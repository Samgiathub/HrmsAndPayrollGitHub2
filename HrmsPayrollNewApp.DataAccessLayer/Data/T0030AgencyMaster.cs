﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class T0030AgencyMaster
{
    public decimal AgencyId { get; set; }

    public decimal StateId { get; set; }

    public string AgencyName { get; set; } = null!;

    public string? AgencyCity { get; set; }

    public string? AgencyAddress { get; set; }

    public string AgencyPhone { get; set; } = null!;

    public string? AgencyMobile { get; set; }

    public string? Comment { get; set; }

    public decimal CmpId { get; set; }
}