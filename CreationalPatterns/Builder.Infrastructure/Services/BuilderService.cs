using Builder.Core.Models.BuilderAbstracts;
using Builder.Core.Models.Builders;
using Builder.Core.Models.Directors;
using Builder.Core.Services;
using LK.Shared.Enums;

namespace Builder.Infrastructure.Services;

public class BuilderService : IBuilderService
{
    public Dictionary<string, string>? GetCultureInformation(CultureEnum cultureType)
    {
        CultureBuilder cultureBuilder;

        switch (cultureType)
        {
            case CultureEnum.enGB:
                cultureBuilder = new EnGBBuilderModel();
                break;
            case CultureEnum.viVN:
                cultureBuilder = new ViVNBuilderModel();
                break;
            default:
                return null;
        }

        CultureDirectorModel.Construct(cultureBuilder);

        return cultureBuilder.Culture.GetInformation();
    }
}