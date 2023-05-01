namespace NeginIBSng.Handlers.perm
{
    public class GetAllPermsOutputModel
    {
        public List<Dictionary<dynamic, getAllPermsDict>> permDict { get; set; }
    }

    public class getAllPermsDict
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
    }
}
