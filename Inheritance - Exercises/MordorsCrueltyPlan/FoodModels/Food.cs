namespace MordorsCrueltyPlan.FoodModels
{
    public abstract class Food
    {
        private int pointOfHappines;

        protected Food(int pointOfHappines)
        {
            this.PointOfHappines = pointOfHappines;
        }

        public virtual int PointOfHappines
        {
            get { return this.pointOfHappines; }
            protected set { this.pointOfHappines = value; }
        }
    }
}
