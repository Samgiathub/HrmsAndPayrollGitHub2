﻿using System;
using System.Collections.Generic;

namespace HrmsPayrollNewApp.DataAccessLayer.Data;

public partial class T0040ProductMaster
{
    public decimal ProductId { get; set; }

    public decimal CmpId { get; set; }

    public decimal LoginId { get; set; }

    public string ProductName { get; set; } = null!;

    public DateTime? SystemDate { get; set; }

    public virtual T0010CompanyMaster Cmp { get; set; } = null!;

    public virtual ICollection<T0040SubProductMaster> T0040SubProductMasters { get; set; } = new List<T0040SubProductMaster>();

    public virtual ICollection<T0050EmpSubProductDetail> T0050EmpSubProductDetails { get; set; } = new List<T0050EmpSubProductDetail>();
}