using System;
using Application.Services.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commands.Create
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        IBrandRepository _brandRepository;

        public CreateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            //command to brand
            Brand brand = new Brand();
            brand.Id = Guid.NewGuid();
            brand.Name = request.Name;

            var createdBrand = await _brandRepository.AddAsync(brand);

            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Id = createdBrand.Id;
            createdBrandResponse.Name = createdBrand.Name;
            createdBrandResponse.CreatedDate = createdBrand.CreatedDate;

            return createdBrandResponse;
        }
    }
}

