using System;
using MediatR;

namespace Application.Features.Brands.Commands.Create
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        public Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new CreatedBrandResponse { Name = request.Name });
        }
    }
}

