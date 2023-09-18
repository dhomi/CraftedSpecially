﻿namespace AndroidApi.Infrastructure.DTOs;

internal class RegisterProductCommand
{
    public RegisterProductCommand(string name, string description)
    {
        Name = name;
        Description = description;

    }
    public string Name { get; private set; }
    public string Description { get; private set; }
}