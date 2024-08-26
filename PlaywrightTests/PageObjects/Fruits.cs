using Microsoft.Playwright;
using PlaywrightTests.Selectors;

namespace PlaywrightTests.PageObjects;

public class Fruits(IPage page) : Product
{
	public void AddPeer()
	{
		AddProductToCart(page, AddToCart.Peer);
	}
	
	public void AddTomato()
	{
		AddProductToCart(page, AddToCart.Tomato);
	}
	
	public void AddBanana()
	{
		AddProductToCart(page, AddToCart.Banana);
	}
	
	public void AddKiwi()
	{
		AddProductToCart(page, AddToCart.Kiwi);
	}
}