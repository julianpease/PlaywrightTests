using Microsoft.Playwright;

namespace PlaywrightTests;

public class Product
{
	protected void AddProductToCart(IPage page, string selector)
	{
		page.Locator(selector)
			.GetByRole(AriaRole.Button, new LocatorGetByRoleOptions
			{
				NameString = "Add to Cart"
			}).ClickAsync();
	}
	
	public void Plus(IPage page)
	{
		page.GetByRole(AriaRole.Button, new PageGetByRoleOptions
		{
			NameString = "+"
		}).ClickAsync();
	}
	
	public void Minus(IPage page)
	{
		page.GetByRole(AriaRole.Button, new PageGetByRoleOptions
		{
			NameString = "-"
		}).ClickAsync();
	}
}