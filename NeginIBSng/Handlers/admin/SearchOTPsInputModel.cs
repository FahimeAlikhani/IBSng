namespace NeginIBSng.Handlers.admin
{
    public class SearchOTPsInputModel
    {
        public string creation_date_from { get; set; }
        public Choice creation_date_from_unit { get; }
        public string creation_date_to { get; set; }
        public Choice creation_date_to_unit { get; set; }
        public string used_date_from { get; set; }
        public Choice used_date_from_unit { get; set; }
        public string used_date_to { get; set; }
        public Choice used_date_to_unit { get; set; }
        public bool expired { get; set; }
        public bool available { get; set; }
        public int _from { get; set; }
        public int to { get; set; }
        public Sort sort_by { get; set; }
        public bool desc { get; set; }


    }
    public enum Choice
    {
        jalali,
        gregorian,
        years,
        months,
        days,
        hours,
        minutes,
    }
    public enum Sort
    {
        otp_id,
        creation_date,
        used_date,
    }
}
