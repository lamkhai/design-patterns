using Builder.Core.Models.BuilderAbstracts;

namespace Builder.Core.Models.Directors;

public class CultureDirectorModel
{
    public static void Construct(CultureBuilder builder)
    {
        builder.BuildCapital();
        builder.BuildCountry();
        builder.BuildCurrency();
        builder.BuildLanguage();
    }
}