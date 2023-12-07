using System;
using Application.Services.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.Create
{
	public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreatedCategoryResponse>
    {
        ICategoryRepository _categoryRepository;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<CreatedCategoryResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            //command to category
            Category category = new Category();
            category.Id = Guid.NewGuid();
            category.Name = request.Name;
            category.Description = request.Description;

            var createdCategory = await _categoryRepository.AddAsync(category);

            CreatedCategoryResponse createdCategoryResponse = new CreatedCategoryResponse();
            createdCategoryResponse.Id = createdCategory.Id;
            createdCategoryResponse.Name = createdCategory.Name;
            createdCategoryResponse.Description = createdCategory.Description;
            createdCategoryResponse.CreatedDate = createdCategory.CreatedDate;

            return createdCategoryResponse;
        }
    }
}

