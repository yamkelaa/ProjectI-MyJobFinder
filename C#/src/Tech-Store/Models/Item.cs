using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Tech_Store.Models;

public partial class Item
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
