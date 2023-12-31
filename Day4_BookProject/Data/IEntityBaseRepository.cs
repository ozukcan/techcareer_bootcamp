﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Data;

public interface IEntityBaseRepository<TEntity,TId>
{
    void Add(TEntity category);
    void Delete(TId id);

    List<TEntity> GetAll();

    TEntity? GetById(TId id);

}
