﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using NexusSaaS.Data;
using NexusSaaS.Entity;
using NexusSaaS.Models;
using NexusSaaS.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace NexusSaaS.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly NexusSaaSDbContext _context;
        private readonly IMapper _mapper;

        public RoleRepository(NexusSaaSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public HttpStatusCode Delete(int id)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var obj = _context.Roles.Find(id);
                    if (obj != null)
                    {
                        _context.Remove(obj);
                        _context.SaveChanges();
                        transaction.Commit();
                        return HttpStatusCode.OK;
                    }
                    return HttpStatusCode.NotFound;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return HttpStatusCode.InternalServerError;
                }
            }
        }

        public HttpStatusCode Delete(string id)
        {
            throw new NotImplementedException();
        }

        public RoleModel GetById(int id)
        {
            var obj = _context.Roles
                .ProjectTo<RoleModel>(_mapper.ConfigurationProvider)
                .FirstOrDefault(f => f.RoleId == id);

            if (obj != null)
            {
                return obj;
            }
            return null;
        }

        public RoleModel GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoleModel> List()
        {
            var list = _context.Roles
                .ProjectTo<RoleModel>(_mapper.ConfigurationProvider)
                .ToList();

            if (list != null || list.Count() > 0)
            {
                return list;
            }
            return null;
        }

        public HttpStatusCode Save(RoleModel objModel)
        {
            if (objModel != null)
            {
                try
                {
                    var objEntity = _mapper.Map<Role>(objModel);
                    _context.Roles.Add(objEntity);
                    _context.SaveChanges();
                    return HttpStatusCode.OK;
                }
                catch
                {
                    return HttpStatusCode.InternalServerError;
                }
            }
            return HttpStatusCode.BadRequest;
        }

        public HttpStatusCode Update(RoleModel objModel)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    if (objModel != null)
                    {
                        var objEntity = _mapper.Map<Role>(objModel);
                        _context.Update(objEntity);
                        _context.SaveChanges();
                        transaction.Commit();
                        return HttpStatusCode.OK;
                    }
                    return HttpStatusCode.BadRequest;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return HttpStatusCode.InternalServerError;
                }
            }
        }
    }
}
