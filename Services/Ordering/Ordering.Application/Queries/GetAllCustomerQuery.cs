using MediatR;
using Ordering.Core.Entities;

namespace Ordering.Application.Queries
{
    public record GetAllCustomerQuery : IRequest<List<Customer>>
    {

    }
}