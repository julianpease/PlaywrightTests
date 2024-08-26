using Microsoft.Playwright;

namespace PlaywrightTests.PageObjects;

public class Categories(IPage page)
{
	public async Task ClickBread()
	{
		await ClickCategory("Bread");
	}
	
	public async Task  ClickDairy()
	{
		await ClickCategory("Dairy");
	}
	
	public async Task  ClickFruits()
	{
		await ClickCategory("Fruits");
	}
	
	public async Task  ClickSeasoningsAndSpices()
	{
		await ClickCategory("Seasonings and Spices");
	}
	
	public async Task  ClickVegetables()
	{
		await ClickCategory("Vegetables");
	}

	private async Task ClickCategory(string product, string altRoute = "")
	{
		await page.GetByRole(AriaRole.Link, new PageGetByRoleOptions
		{
			NameString = product
		}).ClickAsync();

		var route = string.IsNullOrEmpty(altRoute) 
			? product.ToLower() 
			: altRoute.ToLower();
		
		await page.WaitForURLAsync($"https://agular-test-shop-cb70d.firebaseapp.com/?category={route}");
	}
}