﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class V0050RepositoryMaster
{
    public decimal RepositoryId { get; set; }

    public string? RepositoryName { get; set; }

    public decimal? CmpId { get; set; }

    public string? BranchId { get; set; }

    public string? BranchName { get; set; }

    public int? ComplianceId { get; set; }

    public string? ComplianceName { get; set; }

    public string? Month { get; set; }

    public string? Year { get; set; }

    public DateTime? SubmissionDate { get; set; }

    public string? Remark { get; set; }

    public string? AttachmentPath { get; set; }
}
