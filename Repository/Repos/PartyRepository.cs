﻿using Contracts.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repos
{
    public class PartyRepository : RepositoryBase<Party>, IPartyRepository
    {
        public PartyRepository(RepositoryContext repositoryContext):base(repositoryContext) { }

        public async Task<IEnumerable<Party>> GetAllPartiesAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(a => a.FullName).ToListAsync();
        }
    }
}
