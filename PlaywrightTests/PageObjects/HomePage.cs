using Microsoft.Playwright;

namespace PlaywrightTests.PageObjects;

public class HomePage(IPage page)
{
	public void ClickAllCategories()
	{
		page.GetByText("All Categories").ClickAsync();
	}
}