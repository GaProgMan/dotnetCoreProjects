using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

using DataLayer;

namespace BLL {
    public class MyFileReader {

        /*
         * Used to read the contents of a supplied filename.
         * The file is loaded from the root directory of the code.
         * This will not work in a compiled version of the code
         */
        public string ParseFile (string fileName) {
            var binLocation = System.Reflection.Assembly.GetEntryAssembly().Location;

            // TODO: this, but better
            // Extreme file path stupidity here.
            // Here is the file path layout:
            //  /bin
            //    /debug
            //      /netcoreapp1.0
            //        binLocation is here
            //  /JsonFiles
            //    json file are here
            
            // binLocation + ../ -> netcoreapp1
            // binLocation + ../../ -> debug
            // binLocation + ../../../ -> bin
            // binLocation + ../../../../ - > root
            // binLocation + ../../../../JsonFiles -> JsonFiles
            binLocation = Path.Combine(binLocation, @"../../../../JsonFiles/");
            
            var binDirectory = System.IO.Path.GetDirectoryName(binLocation);
            var filePath = Path.Combine(binDirectory, fileName);

            var fileContent = string.Empty;
            using (var reader = File.OpenText(filePath)) {
                fileContent = reader.ReadToEnd();
            }
            return fileContent;
        }
    }
}