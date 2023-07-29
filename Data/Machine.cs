namespace BlazorScheduleur.Data
{
    public class Machine
    {
        public int Row { get; set;}
        public string Name {get;set;} = string.Empty;
    }

    public class WorkItem{
        public Machine? Machine {get;set;}

        public Step? Step {get;set;}

        public string Id {get;set;} = string.Empty;

        public int Start {get;set;}

        public int Duration {get; set;} = 1;
    }
}
