using AbstractFactory.Core.Models.ProductAbstracts;
using LK.Shared.Constants;

namespace AbstractFactory.Core.Models.Products;

public class VietnamModel : Country
{
    public override string Capital { get; set; } = CapitalConstants.Hanoi;

    public override string Name { get; set; } = CountryConstants.Vietnam;
}