﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Domain {
    public interface IActivatable {
        bool Active { get; set; }
    }

    public interface IDbEntity {
        int Id { get; set; }
    }
}
