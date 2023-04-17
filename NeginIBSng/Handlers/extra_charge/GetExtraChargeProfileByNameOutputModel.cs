namespace NeginIBSng.Handlers.extra_charge
{
    public class GetExtraChargeProfileByNameOutputModel : BaseModel
        {
            public int id { get; set; }
            public GetExtraChargeProfileByNameResult result { get; set; }
            public string error { get; set; }
    }

    public class GetExtraChargeProfileByNameResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public List<Items> item { get; set; }
    }
    public class Items
    {
        public int profile_id { get; set; }
        public string profile_name { get; set; }
        public string comment { get; set; }
        public string effective_hour { get; set; }
        public List<rule> rule { get; set; }
    }
}
