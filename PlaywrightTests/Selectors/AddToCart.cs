namespace PlaywrightTests.Selectors;

public static class AddToCart
{
	// Bread
	public const string Pita = "product-card:has-text(\"Pita$7.00Add to Cart\")";
	public const string Baguette = "product-card:has-text(\"Fresh French Baguette$3.00Add to Cart\")";
	
	// Dairy
	public const string Cheese = "product-card:has-text(\"Cheese$12.00Add to Cart\")";
	
	// Fruits
	public const string Peer = "product-card:has-text(\"peer$5.70Add to Cart\")";
	public const string Tomato = "product-card:has-text(\"Tomato$5.00Add to Cart\")";
	public const string Banana = "product-card:has-text(\"Banana$4.50Add to Cart\")";
	public const string Kiwi = "product-card:has-text(\"Kiwi$10.00Add to Cart\")";
	
	// Seasonings and Spices
	public const string CookingSpices = "product-card:has-text(\"Cooking Spices (Base set)$10.00Add to Cart\")";
	
	// Vegetables
	public const string Cucumber = "product-card:has-text(\"Cucumber$2.50Add to Cart\")";
	public const string Carrot = "product-card:has-text(\"Carrot$3.50Add to Cart\")";
	public const string Spinach = "product-card:has-text(\"Spinach$2.00Add to Cart\")";
}