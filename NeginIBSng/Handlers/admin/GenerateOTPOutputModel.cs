namespace NeginIBSng.Handlers.admin
{
    public class GenerateOTPoutputModel :BaseModel
    {
        public int id { get; set; }
        public GenerateOTPResult result { get; set; }
        public string error { get; set; }
    }

    public class GenerateOTPResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public List<GenerateOTPData> data { get; set; }
    }
    public class GenerateOTPData
    {
        public string? password { get; set; }
    }
}
