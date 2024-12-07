using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models;

public partial class TblDesignation
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }
}
