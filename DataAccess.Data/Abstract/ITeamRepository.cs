﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Data.Abstract
{
    public interface ITeamRepository
    {
        bool isTeamIdUnique(string TeamId);
    }
}
