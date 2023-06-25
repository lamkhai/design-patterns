using AbstractFactory.Core.Factories.Abstracts;

namespace AbstractFactory.Core.Services;

public interface IAbstractFactoryService
{
    void Run(AbstractCultureFactory cultureFactory);
}