namespace TfsForms.TempModels
{
    public class ResponseSessionModel
    {
        public int ReportingEntityId { get; set; }
        public int DesigneeId { get; set; }
        public List<AnswerItem> Answers { get; set; }
    }

    public class AnswerItem
    {
        public int QuestionId { get; set; }
        public string? Answer { get; set; }
        public List<FalsePositive> FalsePositives { get; set; } = new();
    }
}
