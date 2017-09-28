namespace GitDemoLibrary
{
    public class SomeManagerClass
    {
        private readonly Service1 _service1;
        private readonly Service2 _service2;
        private readonly Service7 _service7;
        private readonly Service8 _service8;

        public SomeManagerClass(Service1 service1,
                                Service2 service2,
                                Service7 service7,
                                Service8 service8
                                )
        {
            _service1 = service1;
            _service2 = service2;
            _service7 = service7;
            _service8 = service8;
        }
        public string Property1 { get; set; }

        public string Property5 => _service1.Prop3;

        public string Property3 => _service1.Prop4;

        public string PropertyConflict => _service1.Prop5;
    }
}