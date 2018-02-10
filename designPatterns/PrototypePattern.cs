public abstract class PrototypePattern{
	public abstract PrototypePattern Clone();
}

public class ConcretePrototypeOne : PrototypePattern{
	public override PrototypePattern Clone(){
		return (PrototypePattern)this.MemberwiseClone();
	}
}

public class ConcretePrototypeTwo : PrototypePattern{
	public override PrototypePattern Clone(){
		return (PrototypePattern)this.MemberwiseClone();
	}
}
