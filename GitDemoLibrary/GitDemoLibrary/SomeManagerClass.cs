namespace GitDemoLibrary
{
    public class SomeManagerClass
    {
        private readonly Service1 _service1;
        private readonly Service2 service2;

        public SomeManagerClass(Service1 service1,
                                 Service2 service2)
        {
            _service1 = service1;
            this.service2 = service2;
        }
        public string Property1 { get; set; }

        public string Property5 => _service1.Prop3;

        public string Property3 => _service1.Prop4;
    }
}