namespace GitDemoLibrary
{
    public class SomeManagerClass
    {
        private readonly Service1 _service1;
        private readonly Service2 service2;
        private readonly Service3 _service3;

        public SomeManagerClass(Service1 service1,
                                 Service2 service2,
                                 Service3 service3)
        {
            _service1 = service1;
            this.service2 = service2;
            _service3 = service3;
        }
        public string Property1 { get; set; }

        public string Property5 => _service1.Prop3;

        public string Property3 => _service1.Prop4;
    }
}