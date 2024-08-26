using Microsoft.Playwright;
using PlaywrightTests.Selectors;

namespace PlaywrightTests.PageObjects;

public class SeasoningsAndSpices(IPage page) : Product
{
	public void AddCookingSpices()
	{
		AddProductToCart(page, AddToCart.CookingSpices);
	}
}