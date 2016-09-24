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
            if (customObject != null) {
                Console.WriteLine(".Net on a Mac? Heresy");
                Console.WriteLine($"{nameof(customObject)}.Title = {customObject.Title}");
                Console.Write(Environment.NewLine);
            }

            if (medication != null) {
                Console.WriteLine("medico has awoken!");
                Console.WriteLine($"{nameof(medication)}.Human Readable Name = {medication.HumanReadableName}");
                Console.Write(Environment.NewLine);
            }
        }
    }
}
