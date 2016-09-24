using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

using DataLayer;

namespace BLL {
    public class MyFileReader {

        /*
         * Used to attempt to read the contents of the passed in file.
         * If the file cannot be found or read, then we return false.
         * Otherwise we return true.
         */
        public bool TryParseFile (string fileName, out string fileContent) {
            fileContent = string.Empty;

            try {
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
                using (var reader = File.OpenText(filePath)) {
                    fileContent = reader.ReadToEnd();
                }

                return !System.String.IsNullOrEmpty(fileContent);
            }
            catch {
                return false;
            }
        }
    }
}