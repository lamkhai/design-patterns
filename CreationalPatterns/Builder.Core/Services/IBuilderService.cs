using Builder.Core.Models.Abstracts;

namespace Builder.Core.Services;

/// <summary>
/// The 'Director'
/// </summary>
public interface IBuilderService
{
    void Construct(AbstractCultureBuilderModel builder);
}