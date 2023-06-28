using Builder.Core.Models.Abstracts;
using Builder.Core.Services;

namespace Builder.Infratructure.Services;

/// <summary>
/// The 'Director'
/// </summary>
public class BuilderService : IBuilderService
{
    public void Construct(AbstractCultureBuilderModel builder)
    {
        builder.BuildCapital();
        builder.BuildCountry();
        builder.BuildCurrency();
        builder.BuildLanguage();
    }
}