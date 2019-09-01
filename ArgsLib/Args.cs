namespace ArgsLib
{
    public class Args
    {
        private Schemas _schema;
        private Praser _paraser;

        public Args(string schemas, string command)
        {
            _schema = new Schemas(schemas);
            _paraser = new Praser(command);
        }

        public object GetValue(string name)
        {
            return _schema.GetValue(name, _paraser.GetValue(name));
        }
    }
}