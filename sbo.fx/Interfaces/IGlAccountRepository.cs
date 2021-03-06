﻿using sbo.fx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sbo.fx.Interfaces
{
    public interface IGlAccountRepository: IRepository<oGlAccount>
    {
        Task<oGlAccount> GetByAccountCode(string accountCode);
        Task<List<oGlAccount>> GetBySegment(string segment);
    }
}
