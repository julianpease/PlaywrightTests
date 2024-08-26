using Microsoft.Playwright;
using PlaywrightTests.PageObjects;

namespace PlaywrightTests;

public class TestBase
{
	protected IPage Page = null!;
	private IBrowser _browser = null!;
	private IPlaywright _playwright = null!;
	
	protected Categories Categories = null!;
	protected Login Login =  null!;
	protected Product Product = null!;
	protected ShoppingCart Cart = null!;

	protected Bread Bread = null!;
	protected Dairy Dairy = null!;
	protected Fruits Fruits = null!;
	protected SeasoningsAndSpices SeasoningsAndSpices = null!;
	protected Vegetables Vegetables = null!;
	
	[OneTimeSetUp]
	public async Task OneTimeSetUp()
	{
		await ConfigureBrowser();
		PageObjectsSetup();
	}

	[OneTimeTearDown]
	public async Task OneTimeTearDown()
	{
		await _browser.CloseAsync();
		await _browser.DisposeAsync();
		
		_playwright.Dispose();
	}

	protected static IPageAssertions Expect(IPage page) => Assertions.Expect(page);
	
	private async Task ConfigureBrowser()
	{
		_playwright = await Playwright.CreateAsync();
		
		var chromium = _playwright.Chromium;
		_browser = await chromium.LaunchAsync(new BrowserTypeLaunchOptions
		{
			Headless = false,
		});
		
		Page = await _browser.NewPageAsync();
		// await Page.SetViewportSizeAsync(1920, height: 1080);
	}

	private void PageObjectsSetup()
	{
		Categories = new Categories(Page);
		Login = new Login(Page);
		Product = new Product();
		Cart = new ShoppingCart(Page);

		Bread = new Bread(Page);
		Dairy = new Dairy(Page);
		Fruits = new Fruits(Page);
		SeasoningsAndSpices = new SeasoningsAndSpices(Page);
		Vegetables = new Vegetables(Page);
	}
}