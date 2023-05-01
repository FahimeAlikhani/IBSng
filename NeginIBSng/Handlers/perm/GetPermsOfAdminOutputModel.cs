namespace NeginIBSng.Handlers.perm
{
    public class getPermsOfAdminOutputModel
    {
        public List<Dictionary<dynamic, GetParamsItems>> item { get; set; }
    }
    public class GetParamsItems
    {
        public List<string> affected_pages { get; set; }
        public Category category { get; set; }
        public List<string> dependencies { get; set; }

        public string description { get; set; }

        public string name { get; set; }

        public bool should_inherit { get; set; }

        public string tpl_name { get; set; }

        public dynamic value { get; set; }

        public Value_type value_type { get; set; }
        public List<bool> value_candidates { get; set; }
        // Optional : True
    }
    public enum Category
    {
        USER,
        ADMIN,
        RAS,
        CHARGE,
        GROUP,
        LOCATION,
        MISC,
        SETTING,
        REPORT,
    }

    public enum Value_type
    {
        MULTIVALUE,
        COMPOUND,
        NOVALUE,
    }
}
