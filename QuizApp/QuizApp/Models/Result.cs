namespace QuizApp.Models
{
    public class Result
    {
        public int id { get; set; }
        public string correct_answer { get; set; } = string.Empty;
        public string selected_answer { get; set; } = string.Empty;
        public int points { get; set; } = 0;

    }
}
