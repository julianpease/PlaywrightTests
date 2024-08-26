using Microsoft.Playwright;

namespace PlaywrightTests.PageObjects;

public class ShoppingCart(IPage page)
{
	public void ClickCheckout()
	{
		page.GetByText("Check Out").ClickAsync();
	}

	public void RemoveProduct(string productName, int countInCart, decimal price)
	{
		AddRemoveProduct(productName, countInCart, price, false);
	}
	
	public void AddProduct(string productName, int countInCart, decimal price)
	{
		AddRemoveProduct(productName, countInCart, price, true);
	}

	public void ClearCart()
	{
		page.GetByText("Clear Shopping Cart ").ClickAsync();
	}
	
	public void OpenCart()
	{
		page.GetByText(" Shopping Cart ").ClickAsync();
	}

	private void AddRemoveProduct(string productName, int countInCart, decimal price, bool add)
	{
		var productOperator = add ? "+" : "-";
		
		page
			.GetByRole(AriaRole.Row, new PageGetByRoleOptions { NameString = $"No Image {productName} - {countInCart} in cart + ${price}" })
			.GetByRole(AriaRole.Button, new LocatorGetByRoleOptions { NameString = productOperator }).ClickAsync();
	}
	
	public void Plus()
	{
		page.GetByRole(AriaRole.Button, new PageGetByRoleOptions { NameString = "+" }).ClickAsync();
	}
	
	public void Minus()
	{
		page.GetByRole(AriaRole.Button, new PageGetByRoleOptions { NameString = "-" }).ClickAsync();
	}
}