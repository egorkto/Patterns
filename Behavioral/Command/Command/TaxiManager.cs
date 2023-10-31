namespace Command
{
    class TaxiManager
    {
        private ITaxiCommand taxiCommand;

        public void SetTaxiCommand(ITaxiCommand _taxiCommand)
        {
            taxiCommand = _taxiCommand;
        }

        public void CreateCall(Path path)
        {
            taxiCommand.Accept(path);
        }

        public void RefuseCall(Path path)
        {
            taxiCommand.Cancel(path);
        }
    }
}
