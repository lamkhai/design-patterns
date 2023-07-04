﻿using FactoryMethod.Core.Models.Abstracts;

namespace FactoryMethod.Core.Models.Concretes;

/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
public class SpainModel : CountryModel
{
    public override string Name => "Spain";
}