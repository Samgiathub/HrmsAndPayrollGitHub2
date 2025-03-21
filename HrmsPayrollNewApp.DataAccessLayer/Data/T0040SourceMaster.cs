﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class T0040SourceMaster
{
    public decimal SourceId { get; set; }

    public string SourceName { get; set; } = null!;

    public decimal SourceTypeId { get; set; }

    public string? Comments { get; set; }
}
