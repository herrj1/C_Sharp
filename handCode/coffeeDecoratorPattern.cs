public interface ICoffee{
	string getDescription();
	double getCost();
}

public abstract class CondimentDecorator : ICoffee{
	ICoffee _coffee;
	
	protected string _name = "Undefined condiment.";
	protected double _price = 0.0;

	public CondimentDecorator(ICoffee coffee){
		_coffee = coffee;
	}
	
	public string getDescription(){
		return string.Format("{0}, {1}", _coffee.getDescription, _name);
	}
	
	public double getCost(){
		return _coffee.getCost() + _price;
	}
}

public class MilkDecorator : CondimentDecorator{
	public MilkDecorator(ICoffee coffee) :base(coffee){
		_name = "Milk";
		_price = 0.19;
	}
}

public class ChocolateDecorator : CondimentDecorator{
	public ChocolateDecorator(ICoffee coffee) :base(coffee){
		_name = "Chocolate";
		_price = 0.29;
	}
}

//testing. Place it in main driver to test. 
public void coffeeDecoratorPattern(){
	var beverages = new List{
		new ChocolateDecorator(new Filtered()),
		new ChocolateDecorator(new MilkDecorator(new Espresso()))
	};
	
	var filteredWithChocolate = beverages.First();
	Assert.AreEqual("Filtered with care, Chocolate", filteredWithChocolate.GetDescription());
	Assert.AreEqual(1.99 + 0.29, filteredWithChocolate.GetCost());
	
	var espressoWithMilkAndChocolate = beverages.Skip(1).First();
	Assert.AreEqual("Espresso made with care, Milk, Chocolate", espressoWithMilkAndChocolate.GetDescription());
	Assert.AreEqual(2.99 + 0.19 + 0.29, espressoWithMilkAndChocolate.GetCost());
}