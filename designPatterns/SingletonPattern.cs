public sealed class SingletonPattern{
	private static SingletonPattern _instance = null;
	
	private SingletonPattern(){

	}
	
	public static SingletonPattern Instance{
		get{
			lock(_instance){
				_instance = _instance ?? new SingletonPattern();
				return _instance;
			}
		}
	}
}