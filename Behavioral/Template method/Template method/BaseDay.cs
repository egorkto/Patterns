namespace Template_method
{
    abstract class BaseDay
    {
        public void GetRoutine()
        {
            Morning();
            Day();
            Evening();
            Night();
        }

        protected abstract void Morning();
        protected abstract void Day();
        protected abstract void Evening();
        protected abstract void Night();
    }
}
