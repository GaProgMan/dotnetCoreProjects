using Newtonsoft.Json;

using BLL;
using DataLayer;

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

            /*
             * Create an instance of the FileReader class;
             * Parse the contents of the medicationAttempt1.json;
             * Create a new instance of the LogicController and pass
             * it the parsed medication object;
             * Call the RunLogic method of the LogicController
             */
            var fileReader = new MyFileReader();
            var fileContent = string.Empty;
            // Only run the logic if we could read the file
            if (fileReader.TryParseFile("medicationAttempt1.json", out fileContent)) {
                var parsedMedication = JsonConvert.DeserializeObject<Medication>(fileContent);
                var medsLogicController = new LogicController(parsedMedication);
                medsLogicController.RunLogic();
            }
        }
    }
}
