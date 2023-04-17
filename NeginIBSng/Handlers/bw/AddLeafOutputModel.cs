namespace NeginIBSng.Handlers.bw
{
    public class Extra_ChargeOutputModel :BaseModel
    {
        public int id { get; set; }
        public AddLeafResult result { get; set; }
        public string error { get; set; }
    }

    public class AddLeafResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
