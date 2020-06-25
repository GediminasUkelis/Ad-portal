using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.CarService
{
    public class List
    {
        public class Query : IRequest 
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query>
        {
            public Handler()
            {

            }
            public Task<Unit> Handle(Query request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
