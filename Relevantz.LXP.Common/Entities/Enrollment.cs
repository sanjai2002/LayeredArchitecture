﻿using System;
using System.Collections.Generic;
namespace Relevantz.LXP.Common.Entities;
public partial class Enrollment
{
    public Guid EnrollmentId { get; set; }

    public Guid LearnerId { get; set; }

    public Guid CourseId { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public bool EnrollStatus { get; set; }

    public sbyte CompletedStatus { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public decimal? CourseCompletionPercentage { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Learner Learner { get; set; } = null!;
}
