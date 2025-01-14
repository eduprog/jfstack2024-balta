﻿using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

public class UpdateCategoryRequest : Request
{
    [Required(ErrorMessage = "Id não pode ser nulo")]
    public long Id { get; set; }
    
    [Required(ErrorMessage = "Título inválido")]
    [MaxLength(80, ErrorMessage = "Título deve conter no máximo 80 caracteres")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Descrição inválida")]
    public string Description { get; set; } = string.Empty;
}