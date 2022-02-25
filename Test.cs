using SharpLog;

public class Test {
    public static void Main(string[] args) {
        Logger logger = new Logger("test");

        logger.Info("Test");
        logger.Debug("Test 2");
        logger.Warn("Test 3");
        logger.Error("Test 4");
    }
}