using Microsoft.Playwright;
using PlaywrightTests.Selectors;

namespace PlaywrightTests.PageObjects;

public class Bread(IPage page) : Product
{
	public void AddPita()
	{
		AddProductToCart(page, AddToCart.Pita);
	}
	
	public void AddBaguette()
	{
		AddProductToCart(page, AddToCart.Baguette);
	}
}