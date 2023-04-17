namespace NeginIBSng.Handlers.extra_charge
{
    public class AddExtraChargeProfileInputModel
    {
        public string profile_name { get; set; }
        public string comment { get; set; }
        public string effective_hour { get; set; }
        public List<rules> rules { get; set; }
    }

    public class rules
    {
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
    public enum start_from
    {
        user_creation_date,
        user_real_first_login,
        package_first_login,
        user_expiration_date,
        child_user_activation_fee,
        child_user_creation_date,
        child_active_user_creation_date,

    }
    public enum period
    {
        monthly,
        start_of_month,
        daily,
        none,
    }
    public enum period_value
    {
        gregorian,
        jalali,
    }
    public enum change_target
    {
        credit,
        deposit,
        night_free,
    }
    public enum change_action
    {
        SET,
        ADD,
        MULTIPLY,
    }
}
