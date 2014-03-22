namespace Cros.SubRepoLib.Utilities {
    using ServiceStack;

    public class General {
        public static string SerializeJson(object sourceObject) {
            return ServiceStack.Text.JsonSerializer.SerializeToString(sourceObject, sourceObject.GetType());
        }   
    }
}
