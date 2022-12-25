﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Service;

namespace NLayer.API.Controllers
{
    
    public class CategoriesController : CustomBaseController 
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // api/categories/GetSingleCategoriesByIdWithProducts/2
        [HttpGet("[action]/{categoryId}")]
        public async  Task<IActionResult> GetSingleCategoryWithProduct(int categoryId)
        {
            return CreateActionResult(await _categoryService.GetSingleCategoryByIdWithProductAsync(categoryId));
        }
    }
}
