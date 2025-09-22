namespace Estrategia
{
  public interface IDiscountStrategy
  {

    // Este metodo debe ser implementado por todas las estrategias concretas
    decimal ApplyDiscount(decimal total);
  }
}