package main;
import java.util.HashMap;
import java.util.Map;
import java.util.Set;

import org.reflections.Reflections;


public class FigurFactoryLoader {

	  public static Map<Character, FigurFactory> loadFigureFactories() {
	    Set<Class<? extends FigurFactory>> figurFactoryClasses = findAvailableFigurFactoryClasses();
	    return createFigurFactoryMap(figurFactoryClasses);
	  }

	  private static Set<Class<? extends FigurFactory>> findAvailableFigurFactoryClasses() {
	    Reflections reflections = new Reflections("main");
	    return reflections.getSubTypesOf(FigurFactory.class);
	  }

	  private static Map<Character, FigurFactory> createFigurFactoryMap(
	      Set<Class<? extends FigurFactory>> figurFactoryClasses
	  ) {
	    Map<Character, FigurFactory> figurFactoryMap = new HashMap<Character, FigurFactory>();
	    for (Class<? extends FigurFactory> figurFactoryClass : figurFactoryClasses) {
	        createAndPutFigurFactory(figurFactoryClass, figurFactoryMap);
	    }
	    return figurFactoryMap;
	  }

	  private static void createAndPutFigurFactory(
	      Class<? extends FigurFactory> figurFactoryClass,
	      Map<Character, FigurFactory> figurFactoryMap
	  ) {
	    try {
	      FigurFactory figurFactory = (FigurFactory) figurFactoryClass.getConstructor().newInstance();
	      figurFactoryMap.put(figurFactory.getKeyChar(), figurFactory);
	    } catch (Exception e) {
	      e.printStackTrace();
	    }
	  }
}
