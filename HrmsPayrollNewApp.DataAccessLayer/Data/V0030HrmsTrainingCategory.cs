﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class V0030HrmsTrainingCategory
{
    public decimal TrainingCategoryId { get; set; }

    public decimal CmpId { get; set; }

    public string TrainingCategoryName { get; set; } = null!;

    public decimal? ParentCategoryId { get; set; }

    public string? ParentCategory { get; set; }
}