namespace NeginIBSng.Handlers.extra_charge
{
    public class GetExtraChargeProfilesOutputModel : BaseModel
        {
            public int id { get; set; }
            public GetExtraChargeProfilesResult result { get; set; }
            public string error { get; set; }
    }

    public class GetExtraChargeProfilesResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public List<Item> item { get; set; }
    }
    public class Item
    {
        public int profile_id { get; set; }
        public string profile_name { get; set; }
        public string comment { get; set; }
        public string effective_hour { get; set; }
        public List<RulesDic> rules { get; set; }
    }
    public class RulesDic
    {
        public int rule_id { get; set; }
        public start_from start_from { get; set; }
        public string description { get; set; }
        public period period { get; set; }
        public period_value period_value { get; set; }
        public change_target change_target { get; set; }
        public change_action change_action { get; set; }
        public float amount { get; set; }
        public bool negate_credit { get; set; }
        public bool pay_back { get; set; }
        public bool ignore_first_time { get; set; }
    }
}
