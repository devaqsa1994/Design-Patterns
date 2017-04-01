package prototype.dp.com;

public class TestCloning 
	{
		public static void main(String[] args){
		// Handles routing makeCopy method calls to the 
		// right subclasses of Animal
		cloneFactory animalMaker = new cloneFactory();
		Sheep sally = new Sheep();
		Sheep clonedSheep = (Sheep) animalMaker.getClone(sally);
		System.out.println(sally);
		System.out.println(clonedSheep);
		System.out.println("Sally HashCode: " + System.identityHashCode(System.identityHashCode(sally)));
		System.out.println("Clone HashCode: " + System.identityHashCode(System.identityHashCode(clonedSheep)));
		}
}
