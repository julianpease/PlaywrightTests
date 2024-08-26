using PlaywrightTests.PageObjects;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : TestBase
{
	[SetUp]
	public async Task SetUp()
	{
		// Go to site
		await Page.GotoAsync("https://agular-test-shop-cb70d.firebaseapp.com/");
		await Expect(Page).ToHaveTitleAsync(new Regex("Oshop"));
	}

	[Test]
	public async Task PlaceOrder()
	{
		// Select Bread Category
		await Categories.ClickBread();
		await Expect(Page).ToHaveURLAsync(new Regex(".*bread"));
		
		// Add 2x French Baguettes to your shopping cart
		Bread.AddBaguette();
		Product.Plus(Page);
	
		// Select Dairy Category
		await Categories.ClickDairy();
		await Expect(Page).ToHaveURLAsync(new Regex(".*dairy"));
		
		// Add 3 blocks of cheese
		Dairy.AddCheese();
		Product.Plus(Page);
		Product.Plus(Page);
	
		// Go to the shopping cart and remove 1x cheese
		Cart.OpenCart();
		await Expect(Page).ToHaveURLAsync(new Regex(".*shopping-cart"));
		Cart.RemoveProduct("Cheese", 3, 36.00M);
		
		// Clear shopping cart
		Cart.ClearCart();
	
		// Check out
		Cart.ClickCheckout();
	
		// Login
		Login.ClickLink();
		await Expect(Page).ToHaveURLAsync(new Regex(".*login"));
		Login.LoginWithGoogle();
	}
}