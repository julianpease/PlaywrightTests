using Microsoft.Playwright;
using PlaywrightTests.Selectors;

namespace PlaywrightTests.PageObjects;

public class Dairy(IPage page) : Product
{
	public void AddCheese()
	{
		AddProductToCart(page, AddToCart.Cheese);
	}
}