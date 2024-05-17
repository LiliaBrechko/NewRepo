namespace CaloriesCalculator.Models
{
    public class User
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public double Weight {  get; set; }
        public double Growth {  get; set; }
        public ActivityLevel ActivityLevel { get; set; }
        public double DailyCalorie {  get; set; }



    }
}
