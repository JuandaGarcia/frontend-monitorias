namespace Frontend.Pages
{
    public partial class Monitoria
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string faculty { get; set; }
        public string day { get; set; }
        public string init { get; set; }
        public string end { get; set; }
        public string livingRoom { get; set; }
        public int availableQuotas { get; set; }
        public int initialQuotas { get; set; }
        public string description { get; set; }
        public string[] students { get; set; }
    }
}