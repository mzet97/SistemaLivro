﻿using System.Security.Claims;

namespace SistemaLivro.Application.UseCases.Auth.ViewModels;

public class ClaimViewModel
{
    public string Value { get; set; }
    public string Type { get; set; }


    public ClaimViewModel(Claim claim)
    {
        Value = claim.Value;
        Type = claim.Type;
    }

    public ClaimViewModel(string value, string type)
    {
        Value = value;
        Type = type;
    }

    public ClaimViewModel()
    {
        
    }
}
