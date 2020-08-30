﻿using DataAccess.Model;
using DataAccess.Model.SharedModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Data.Abstract
{
    public interface IRegistrationService
    {
        public string RegisterOrUpdate(RegisterTeam registerTeam);
        List<RegisteredTeam> GetRegisteredTeams(Dictionary<string, string> searchValues, string sortColumn, string sortDir, int start, int length, out int filteredCount, out int totalCount);
        List<string> GetLocations();
    }
}