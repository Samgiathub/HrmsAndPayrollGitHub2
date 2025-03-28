﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class T0090EmpDependantDetail
{
    public decimal EmpId { get; set; }

    public decimal RowId { get; set; }

    public decimal CmpId { get; set; }

    public string Name { get; set; } = null!;

    public string RelationShip { get; set; } = null!;

    public DateTime? BirthDate { get; set; }

    public decimal? DAge { get; set; }

    public string? Address { get; set; }

    public decimal? Share { get; set; }

    public decimal? IsResi { get; set; }

    public string? NomineeFor { get; set; }

    public string? PanCardNo { get; set; }

    public string? AdharCardNo { get; set; }

    public virtual T0010CompanyMaster Cmp { get; set; } = null!;

    public virtual T0080EmpMaster Emp { get; set; } = null!;
}
