/* .Net specific using statements */
using System;

/* Custom using statements */
using DataLayer;

namespace Program {
    public class LogicController{

        private MyObject customObject { get; set; }

        public LogicController (MyObject inObject) {
            customObject = inObject;
        }

        public void RunLogic() {
            Console.WriteLine(".Net on a Mac? Heresy");
            Console.WriteLine($"{nameof(customObject)}.Title = {customObject.Title}");
        }
    }
}
