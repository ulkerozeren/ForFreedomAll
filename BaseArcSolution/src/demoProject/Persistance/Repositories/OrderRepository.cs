using Application.RepositoryInterfaces;
using Core.Persistance;
using Domain.Entities;
using Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class OrderRepository : BaseRepository<Order, BaseDbContext>, IOrderRepository
    {
        public OrderRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
