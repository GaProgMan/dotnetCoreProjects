using BLL;

namespace Program {
    public class Program {
        public static void Main(string[] args) {

            /*
             * Create an instance of the LogicContoller class,
             * give it a new instance of the MyObject class,
             * then call the RunLogic method on the instance of
             * the LogicController class 
             */
            var myObject = MyObjectFactory.GenerateMyObject();
            var logicController = new LogicController(myObject);
            logicController.RunLogic();
        }
    }
}
