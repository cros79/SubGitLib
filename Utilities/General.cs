namespace Cros.SubRepoLib.Utilities {
    using Newtonsoft.Json;

    public class General {
        public static string SerializeJson(object sourceObject) {
            return JsonConvert.SerializeObject(sourceObject);
        }   
    }
}
