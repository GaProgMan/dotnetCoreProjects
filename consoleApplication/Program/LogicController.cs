/* .Net specific using statements */
using System;

/* Custom using statements */
using DataLayer;

namespace Program {
    public class LogicController{

        private MyObject customObject { get; set; }
        private string medicationFileName { get; set; }
        private Medication medication { get; set; }

        public LogicController (MyObject inObject) {
            customObject = inObject;
        }

        public LogicController(Medication medicationToUse) {
            medication = medicationToUse;
        }

        public void RunLogic() {
            Console.WriteLine(".Net on a Mac? Heresy");
            if (customObject != null) {
                Console.WriteLine($"{nameof(customObject)}.Title = {customObject.Title}");
            }

            if (medication != null) {
                Console.WriteLine($"{nameof(medication)}.Human Readable Name = {medication.HumanReadableName}");
            }
        }
    }
}
