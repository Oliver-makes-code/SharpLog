using System;

namespace SharpLog {
    public class Logger {
        public string id {get; private set;}
        public bool debug {get; private set;}
        public Logger(string id, bool debug = false) {
            this.id = id;
            this.debug = debug;
        }

        private void WriteId(string append = "Info") {
            Console.Write("["+id+", "+append+"] ");
        }

        public void Info(Object text) {
            WriteId("Info");
            Console.WriteLine(text);
        }

        public void Debug(Object text) {
            if (debug) {
                WriteId("Debug");
                Console.WriteLine(text);
            }
        }

        public void Warn(Object text) {
            WriteId("Warn");
            Console.WriteLine(text);
        }

        public void Error(Object text) {
            WriteId("Error");
            Console.Error.WriteLine(text);
        }
    }
}