public class MathAssignment : Assignment
{

    // Attributes
    private string _textbookSection;
    private string _problems;

    // Constructor
    public MathAssignment(string studentName, string topic, string bookSection, string problems): base(studentName, topic)
    {
        _textbookSection = bookSection;
        _problems = problems;
    }

    // Methods
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}