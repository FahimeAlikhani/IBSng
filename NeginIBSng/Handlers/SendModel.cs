namespace NeginIBSng.Handlers
{
    public class SendModel<Param>
    {
        public string method { get; set; }
        public List<Param> @params { get; set; }
    }
    public class Param
        {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
        public List<Choice> Choice { get; set; }
    }
    public class Choice
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }
    public class Method
    {
        public string Name { get; set; }
        public string Auth_type { get; set; }
        public string Requires_perm { get; set; }
        public string Comment { get; set; }
    }
}
