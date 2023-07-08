﻿using AbstractFactory.Core.Models.ProductAbstracts;
using LK.Shared.Constants;

namespace AbstractFactory.Core.Models.Products;

public class VietnameseModel : LanguageModel
{
    public override string Hello { get; set; } = LanguageConstants.Hello_Vietnamese;
}