namespace NeginIBSng.Handlers.extra_charge
{
    public class UpdateExtraChargeProfileInputModel
    {
        public int profile_id { get; set; }
        public string profile_name { get; set; }
        public string comment { get; set; }
        public string effective_hour { get; set; }
        public List<rules> rule { get; set; }

    }
    public class rule
    {
        public int rule_id { get; set; }
        public start_from start_from { get; set; }
        public string description { get; set; }
        public period_value period_value { get; set; }
        public change_target change_target { get; set; }
        public change_action change_action { get; set; }
        public float amount { get; set; }

    }
   
}
