namespace GitDemoLibrary
{
    public class SomeManagerClass
    {
        private readonly Service1 _service1;

        public SomeManagerClass(Service1 service1)
        {
            _service1 = service1;
        }
        public string Property1 { get; set; }

        public string Property2 => _service1.Prop2;
    }
}