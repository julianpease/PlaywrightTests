using Microsoft.Playwright;
using PlaywrightTests.Selectors;

namespace PlaywrightTests.PageObjects;

public class Vegetables(IPage page) : Product
{
	public void AddCucumber()
	{
		AddProductToCart(page, AddToCart.Cucumber);
	}
	
	public void AddCarrot()
	{
		AddProductToCart(page, AddToCart.Carrot);
	}
	
	public void AddSpinach()
	{
		AddProductToCart(page, AddToCart.Spinach);
	}
}