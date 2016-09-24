/* Custom using statements */
using DataLayer;


/*
 * The MyObjectFactory class is a very simplistic factory pattern (not really)
 * class for creating instances of the MyObject class
 */
namespace BLL {
    public static class MyObjectFactory{

        /*
        * Creates a new instance of the MyObject class and returns it
        * Uses a default string if none is supplied
        */
        public static MyObject GenerateMyObject(string title = "Some title for my flashy new object instance") {
            return new MyObject{
                Title = title
            };
        }
    }
}