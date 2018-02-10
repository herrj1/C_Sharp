public abstract class Subject{
	private ArrayList observers = new ArrayList();
	
	public void attach(IObserver o){
		observers.Add(o);
	}
	
	public void detach(IObserver o){
		observers.Remove(o);
	}
	
	public void notify(){
		foreach(IObserver o in observers){
			o.Update();
		}
	}
}

public class ConcreteSubject : Subject{
	private string state;
	
	public string getState(){
		return state;
	}
	
	public void setState(string newState){
		state = newState;
		notify();
	}
}

public interface IObserver{
	void Update();
}

public class ConcreteObserver : IObserver{
	private ConcreteSubject subject;
	
	public ConcreteObserver(ConcreteSubject sub){
		subject = sub;
	}
	
	public void update(){
		string subjectState = subject.GetState();
		Console.WriteLine(subjectState);
	}
}