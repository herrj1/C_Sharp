public interface IAdapter{
	void Add();
}

public class ClassOne : IAdapter{
	public void Add(){}
}

public class ClassTwo{
	public void Push(){}
}

public class Adapter : IAdapter{
	private ClassTwo _class2 = new ClassTwo();
	public void Add(){ this._class2.Push();}
}
