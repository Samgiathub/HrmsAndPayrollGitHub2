﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class V0020PrivilegeMaster
{
    public decimal PrivilegeId { get; set; }

    public decimal CmpId { get; set; }

    public string? PrivilegeName { get; set; }

    public byte? IsActive { get; set; }

    public byte? PrivilegeType { get; set; }

    public decimal? BranchId { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchIdMulti { get; set; }

    public string? VerticalIdMulti { get; set; }

    public string? SubVerticalIdMulti { get; set; }

    public string? BranchName { get; set; }

    public string? DepartmentIdMulti { get; set; }
}
