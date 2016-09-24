using Newtonsoft.Json;

using BLL;
using DataLayer;

namespace Program {
    public class Program {
        public static void Main(string[] args) {

            /*
             * New code to test out loading of a json file from disk
             */
            var fileReader = new MyFileReader();
            var fileContent = fileReader.ParseFile("medicationAttempt1.json");
            var parsedMedication = JsonConvert.DeserializeObject<Medication>(fileContent);

            #if DEBUG
            System.Console.WriteLine(parsedMedication.HumanReadableName);
            #endif

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
