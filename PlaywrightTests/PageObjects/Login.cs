using Microsoft.Playwright;

namespace PlaywrightTests.PageObjects;

public class Login(IPage page)
{
	public void ClickLink()
	{
		page.GetByText("Login").ClickAsync();
	}
	public void LoginWithGoogle()
	{
		page.GetByText("Login with Google").ClickAsync();
	}
}