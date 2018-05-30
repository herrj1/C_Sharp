public class Person{
	public string name;
	
	public Person(){
		name = "Jake";
	}
	
	public Person(string nm){
		name=nm;
	}
	
	public void setName(string newName){
		name = newName;
	}
}

class TestPersonR2{
	static void main(){
		Person person1 = new Person();
		Console.WriteLine(person1.name);
		
		person1.setName("Maria Morales");
		Console.WriteLine(person1.name);
		
		Person person2 = new Person("Josh Brown");
		Console.WriteLine(person2.name);
		
		Console.WriteLine("Press any key to exit...");
		Console.Readkey();
	}
}