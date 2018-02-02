//declare person object
public class Person{
	public string name;
	
	public Person(){
		name = "unknown";
	}
	
	public Person(string nm){
		name = nm;
	}
	
	public void setName(string newName){
		name = newName;
	}
}

class TestPerson{
	static void Main(){
		Person person1 = new Person();
		Console.WriteLine(person1.name);
		
		person1.setName("Mark Kurt");
		Console.WriteLine(person1.name);
		
		Person person2 = new Person("Maria Ramirez");
		Console.WriteLine(person2.name);
		
		Console.WriteLine("Press any key to exit."):
		Console.ReadKey();
	}
}